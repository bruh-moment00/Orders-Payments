using Orders_Payments_Client.API.Payments.Models;
using Orders_Payments_Client.Presentation.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orders_Payments_Client.UI.Forms
{
    public partial class PaymentsForm : Form, IPaymentsView
    {
        public PaymentsForm()
        {
            InitializeComponent();
        }
        public new void Show()
        {
            ShowDialog();
        }
        public void LoadPaymentsOnGrid(IEnumerable<Payment> payments)
        {
            paymentsGrid.DataSource = payments;
        }
    }
}
