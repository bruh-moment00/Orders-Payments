using Orders_Payments_Client.API.Funds.Models;
using Orders_Payments_Client.API.Funds.Repositories.Interfaces;
using Orders_Payments_Client.API.Orders.Models;
using Orders_Payments_Client.API.Orders.Repositories.Interfaces;
using Orders_Payments_Client.API.Payments.Models;
using Orders_Payments_Client.API.Payments.Repositories.Interfaces;
using Orders_Payments_Client.Presentation.Common;
using Orders_Payments_Client.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Client.Presentation.Presenters
{
    class CreatePaymentPresenter : BasePresenter<ICreatePaymentView, Order>
    {
        private readonly IPaymentsRepository _paymentsRepository;
        private readonly IFundsRepository _fundsRepository;
        private readonly IOrdersRepository _ordersRepository;

        private Order _order;
        public CreatePaymentPresenter(

            IApplicationController controller, 
            ICreatePaymentView view, 
            IPaymentsRepository paymentsRepository, 
            IFundsRepository fundsRepository, 
            IOrdersRepository ordersRepository) 
            : base(controller, view)

        {
            _paymentsRepository = paymentsRepository;
            _fundsRepository = fundsRepository;
            _ordersRepository = ordersRepository;

            View.CreateFund += () => CreateFund(View.Date, View.Sum);
            View.CreatePayment += () => CheckDataAndCreatePayment(_order, View.Fund, View.PaymentSum);
        }
        public override void Run(Order argument)
        {
            _order = argument;
            UpdateFundsList();
            UpdateCurrentOrder();
            View.Show();
        }
        private void CreateFund(DateTime date, double sum)
        {
            var fundQuery = new FundQuery
            {
                Date = date,
                Sum = sum
            };

            IEnumerable<FundQuery> funds = new List<FundQuery> { fundQuery };
            if (!_fundsRepository.PostFunds(funds))
            {
                View.ShowError("Ошибка создания прихода");
            }
            else
            {
                UpdateFundsList();
            }
        }
        private void CheckDataAndCreatePayment(Order order, Fund fund, double sum)
        {
            if(IsDataRelevant(order, fund))
            {
                CreatePayment(order.Id, fund.Id, sum);
            }
            else
            {
                if (View.DisplayDataChangedWarning())
                {
                    CreatePayment(order.Id, fund.Id, sum);
                }
            }
            UpdateFundsList();
            UpdateCurrentOrder();
        }
        private void UpdateFundsList()
        {
            View.LoadFundsOnGrid(_fundsRepository.GetFunds());
        }

        private void UpdateCurrentOrder()
        {
            _order = _ordersRepository.GetOrderById(_order.Id);
            View.DisplayCurrentOrder(_order);
        }

        private bool IsDataRelevant(Order order, Fund fund)
        {
            return order.PaidSum == _ordersRepository.GetOrderById(order.Id).PaidSum && fund.Remain == _fundsRepository.GetFundById(fund.Id).Remain;
        }

        private void CreatePayment(int orderId, int fundId, double paymentSum)
        {
            var paymentQuery = new PaymentQuery
            {
                OrderId = orderId,
                FundId = fundId,
                PaymentSum = paymentSum
            };

            if (!_paymentsRepository.PostPayment(paymentQuery))
            {
                View.ShowError("Ошибка создания операции");
            }
            else
            {
                View.ShowSuccess("Оплата привязана успешно");
            }
        }
    }
}
