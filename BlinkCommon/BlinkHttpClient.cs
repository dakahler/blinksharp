using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlinkSharp
{
    class BlinkHttpClient : HttpClient
    {
        private readonly string baseAddress = "prod.immedia-semi.com";

        public BlinkHttpClient(string authCode)
        {
            this.DefaultRequestHeaders.Add("Host", baseAddress);
            this.DefaultRequestHeaders.Add("TOKEN_AUTH", authCode);
        }

        public async Task<T> GetJsonAsync<T>(string apiCall)
        {
            var httpResponse = await this.GetAsync($"https://{baseAddress}/{apiCall}");

            // If the response contains content we want to read it!
            if (httpResponse.Content != null)
            {
                string responseContent = await httpResponse.Content.ReadAsStringAsync();

                // From here on you could deserialize the ResponseContent back again to a concrete C# type using Json.Net
                return JsonConvert.DeserializeObject<T>(responseContent);
            }

            return default(T);
        }
    }
}
