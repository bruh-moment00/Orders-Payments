using Orders_Payments_Client.API.Funds.Models;
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
    public partial class CreatePaymentForm : Form, ICreatePaymentView
    {
        public CreatePaymentForm()
        {
            InitializeComponent();

            addNewFundButton.Click += (sender, args) => Invoke(CreateFund);
            createPaymentButton.Click += (sender, args) => Invoke(CreatePayment);
        }

        public DateTime Date { get { return fundDatePicker.Value; } }
        public double Sum { get { return Convert.ToDouble(sumNumeric.Value); } }
        public event Action CreateFund;

        public double PaymentSum { get { return Convert.ToDouble(paymentSumNumeric.Value); } }
        public Fund Fund { get
            {
                return new Fund
                {
                    Id = Convert.ToInt32(fundsGrid.CurrentRow.Cells["id"].Value),
                    Date = Convert.ToDateTime(fundsGrid.CurrentRow.Cells["date"].Value),
                    Sum = Convert.ToInt32(fundsGrid.CurrentRow.Cells["sum"].Value),
                    Remain = Convert.ToInt32(fundsGrid.CurrentRow.Cells["remain"].Value),
                };
            } }

        
        public event Action CreatePayment;

        public new void Show()
        {
            ShowDialog();
        }
        public void LoadFundsOnGrid(IEnumerable<Fund> funds)
        {
            fundsGrid.DataSource = funds;
        }

        public void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Ошибка");
        }

        private void Invoke(Action action)
        {
            if (action != null) action();
        }
    }
}
