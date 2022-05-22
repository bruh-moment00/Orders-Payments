using Orders_Payments_Client.API.ApiClients;
using Orders_Payments_Client.API.ApiClients.Interfaces;
using Orders_Payments_Client.API.Orders.Models;
using Orders_Payments_Client.API.Orders.Repositories;
using Orders_Payments_Client.API.Orders.Repositories.Interfaces;
using Orders_Payments_Client.Presentation.Common;
using Orders_Payments_Client.Presentation.Presenters;
using Orders_Payments_Client.Presentation.Views;
using Orders_Payments_Client.UI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orders_Payments_Client.UI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var controller = new ApplicationController(new LightInjectAdapder())
                .RegisterView<IOrdersView, OrdersForm>()
                .RegisterInstance<IApiClient>(new ApiClient("https://localhost:44304/api/"))
                .RegisterService<IOrdersRepository, OrdersRepository>()
                .RegisterInstance(new ApplicationContext());

            controller.Run<OrdersPresenter>();
        }
    }
}
