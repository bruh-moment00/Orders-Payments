using Orders_Payments_Client.API.ApiClients.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;

namespace Orders_Payments_Client.API.ApiClients
{
    public class ApiClient : IApiClient
    {
        private readonly string _apiURL;
        public ApiClient(string apiURL)
        {
            _apiURL = apiURL;
        }

        public object Get(string path)
        {
            HttpClient httpClient = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage();
            request.RequestUri = new Uri(_apiURL + path);
            request.Method = HttpMethod.Get;
            request.Headers.Add("Accept", "application/json");

            HttpResponseMessage response = httpClient.Send(request);

            return JsonConvert.DeserializeObject<object>(response.Content.ToString());
        }

        public HttpStatusCode Post(string path, object body)
        {
            HttpClient httpClient = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage();
            request.RequestUri = new Uri(_apiURL + path);
            request.Method = HttpMethod.Post;
            request.Headers.Add("Accept", "application/json");
            request.Content = new StringContent(JsonConvert.SerializeObject(body));

            HttpResponseMessage response = httpClient.Send(request);

            return response.StatusCode;
        }
    }
}
