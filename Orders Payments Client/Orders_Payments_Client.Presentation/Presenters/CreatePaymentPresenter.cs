using Orders_Payments_Client.API.Funds.Models;
using Orders_Payments_Client.API.Funds.Repositories.Interfaces;
using Orders_Payments_Client.API.Orders.Models;
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

        private Order _order;
        public CreatePaymentPresenter(IApplicationController controller, ICreatePaymentView view, IPaymentsRepository paymentsRepository, IFundsRepository fundsRepository) : base(controller, view)
        {
            _paymentsRepository = paymentsRepository;
            _fundsRepository = fundsRepository;

            View.CreateFund += () => CreateFund(View.Date, View.Sum);
            View.CreatePayment += () => CreatePayment(_order.Id, View.Fund.Id, View.PaymentSum);
        }
        public override void Run(Order argument)
        {
            _order = argument;
            UpdateFundsList();
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
        private void CreatePayment(int orderId, int fundId, double sum)
        {
            var paymentQuery = new PaymentQuery
            {
                OrderId = orderId,
                FundId = fundId,
                PaymentSum = sum
            };

            if (!_paymentsRepository.PostPayment(paymentQuery))
            {
                View.ShowError("Ошибка создания операции");
            }
            else
            {
                UpdateFundsList();
            }
        }
        private void UpdateFundsList()
        {
            View.LoadFundsOnGrid(_fundsRepository.GetFunds());
        }
    }
}
