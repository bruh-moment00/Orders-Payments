﻿using Orders_Payments_Client.API.Orders.Models;
using Orders_Payments_Client.Presentation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Client.Presentation.Views
{
    public interface IOrdersView : IView
    {
        void LoadOrdersOnGrid(IEnumerable<Order> orders);
    }
}
