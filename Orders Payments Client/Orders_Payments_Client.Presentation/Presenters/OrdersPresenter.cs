using Orders_Payments_Client.API.Orders.Models;
using Orders_Payments_Client.API.Orders.Repositories.Interfaces;
using Orders_Payments_Client.Presentation.Common;
using Orders_Payments_Client.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Client.Presentation.Presenters
{
    public class OrdersPresenter : BasePresenter<IOrdersView>
    {
        private readonly IOrdersRepository _ordersRepository;
        private IEnumerable<Order> _orders;
        public OrdersPresenter(IApplicationController controller, IOrdersView view, IOrdersRepository ordersRepository) : base(controller, view)
        {
            _ordersRepository = ordersRepository;
        }

        public override void Run()
        {
            UpdateOrdersList();
            View.Show();
        }

        private void UpdateOrdersList()
        {
            View.LoadOrdersOnGrid(_ordersRepository.GetOrders());
        }
    }
}
