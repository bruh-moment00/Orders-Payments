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
        }

        public new void Show()
        {
            _context.MainForm = this;
            Application.Run(_context);
        }

        public DateTime Date { get { return orderDatePicker.Value; } }
        public double Sum { get { return Convert.ToDouble(sumNumeric.Value); } }

        public event Action CreateOrder;
        
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
