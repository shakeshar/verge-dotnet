using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Verge.Core.Resource
{
    public abstract class BaseHttpResource
    {
        protected readonly HttpClient Client;
        protected readonly string BaseUrl;

        public BaseHttpResource(HttpClient client, string baseUrl)
        {
            this.Client = client;
            this.BaseUrl = baseUrl;
        }
    }
}
