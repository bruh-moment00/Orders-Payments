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
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        public void LoadOrdersOnGrid(IEnumerable<Order> orders)
        {
            ordersGrid.DataSource = orders;
        }

        private void Invoke(Action action)
        {
            if (action != null) action();
        }
    }
}
