using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Verge.Core.Contract;

namespace Verge.Core.Client
{
    public abstract class JsonRequest<T>
     
    {
        protected readonly HttpClient Client;
        protected readonly string Url;
        public async Task<IJsonResponse<T>> Invoke()
        {
            try{
            var response = await Execute();
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    T model = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(content);
                    return new JsonResponse<T>(response, model);
                }
                else
                {
                    var content = await response.Content.ReadAsStringAsync();
                    T model = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(content);
                    return new JsonResponse<T>(response, model);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public JsonRequest(HttpClient client, string url)
        {
            Url = url;
            Client = client;
        }
        public abstract Task<HttpResponseMessage> Execute();
        protected HttpContent Create(object o)
        {
                string content = Newtonsoft.Json.JsonConvert.SerializeObject(o);
                return new StringContent(content, Encoding.UTF8, "application/json");
        }

    }
}
