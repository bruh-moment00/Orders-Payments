using Orders_Payments_Client.API.Orders.Models;
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
    public partial class OrdersForm : Form, IOrdersView
    {
        private readonly ApplicationContext _context;
        public OrdersForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();

            addNewOrderButton.Click += (sender, args) => Invoke(CreateOrder);
            openPaymentsFormBtn.Click += (sender, args) => Invoke(OpenPayments);
            createPaymentFormBtn.Click += (sender, args) => Invoke(OpenPaymentCreation);
        }

        public new void Show()
        {
            _context.MainForm = this;
            Application.Run(_context);
        }

        public DateTime Date { get { return orderDatePicker.Value; } }
        public double Sum { get { return Convert.ToDouble(sumNumeric.Value); } }
        public Order Order 
        { 
            get 
            {
                return new Order
                {
                    Id = Convert.ToInt32(ordersGrid.CurrentRow.Cells["id"].Value),
                    Date = Convert.ToDateTime(ordersGrid.CurrentRow.Cells["date"].Value),
                    Sum = Convert.ToInt32(ordersGrid.CurrentRow.Cells["sum"].Value),
                    PaidSum = Convert.ToInt32(ordersGrid.CurrentRow.Cells["paidSum"].Value),
                };
            } 
        }

        public event Action CreateOrder;
        public event Action OpenPayments;
        public event Action OpenPaymentCreation;

        public void LoadOrdersOnGrid(IEnumerable<Order> orders)
        {
            ordersGrid.DataSource = orders;
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
