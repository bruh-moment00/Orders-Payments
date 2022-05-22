using Leaf.xNet;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Orders_Payments_Client.API.ApiClients.Interfaces
{
    public interface IApiClient
    {
        public T Get<T>(string path);
        public HttpStatusCode Post(string path, object body);
    }
}
