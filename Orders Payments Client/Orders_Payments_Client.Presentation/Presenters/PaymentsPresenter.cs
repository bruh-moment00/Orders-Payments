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
    public class PaymentsPresenter : BasePresenter<IPaymentsView>
    {
        private readonly IPaymentsRepository _paymentsRepository;
        public PaymentsPresenter(IApplicationController controller, IPaymentsView view, IPaymentsRepository paymentsRepository) : base(controller, view)
        {
            _paymentsRepository = paymentsRepository;
        }
        public override void Run()
        {
            UpdatePaymentsList();
            View.Show();
        }
        private void UpdatePaymentsList()
        {
            View.LoadPaymentsOnGrid(_paymentsRepository.GetPayments());
        }
    }
}
