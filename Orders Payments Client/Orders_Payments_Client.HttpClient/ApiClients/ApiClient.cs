using Orders_Payments_Client.API.ApiClients.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Net.Http;
using Leaf.xNet;
using Newtonsoft.Json;
//using System.Net;

namespace Orders_Payments_Client.API.ApiClients
{
    public class ApiClient : IApiClient
    {
        private readonly string _apiURL;
        public ApiClient(string apiURL)
        {
            _apiURL = apiURL;
        }

        public T Get<T>(string path)
        {
            using(var request = new HttpRequest())
            {
                request.UserAgent = Http.ChromeUserAgent();

                HttpResponse response = request.Get(_apiURL + path);
                return JsonConvert.DeserializeObject<T>(response.ToString());
            }

            

        }

        public HttpResponse Post(string path, object body)
        {
            using (var request = new HttpRequest())
            {
                request.UserAgent = Http.ChromeUserAgent();

                string stringContent = JsonConvert.SerializeObject(body);
                HttpResponse response = request.Post(_apiURL + path, stringContent, "application/json");
                return response;
            }
        }
    }
}
