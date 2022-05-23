using Orders_Payments_Client.API.Funds.Models;
using Orders_Payments_Client.Presentation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Client.Presentation.Views
{
    public interface ICreatePaymentView : IView
    {
        DateTime Date { get; }
        double Sum { get; }
        event Action CreateFund;
        double PaymentSum { get; }
        Fund Fund { get; }
        event Action CreatePayment;
        void LoadFundsOnGrid(IEnumerable<Fund> funds);
        void ShowError(string errorMessage);
    }
}
