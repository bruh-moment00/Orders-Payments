using Orders_Payments_Client.API.Payments.Models;
using Orders_Payments_Client.Presentation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Client.Presentation.Views
{
    public interface IPaymentsView : IView
    {
        void LoadPaymentsOnGrid(IEnumerable<Payment> payments);
    }
}
