using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace Kanban_Release.Components
{
    public class SendRequest
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public static async Task<string> PostRequest(string url, object request, string token)
        {
            return await SendRequestAsync(HttpMethod.Post, url, request, token);
        }

        public static async Task<string> SendGetRequest(string url, string token)
        {
            return await SendRequestAsync(HttpMethod.Get, url, null, token);
        }

        public static async Task<string> SendDeleteRequest(string url, string token)
        {
            return await SendRequestAsync(HttpMethod.Delete, url, null, token);
        }

        public static async Task<string> SendPutRequest(string url, object request, string token)
        {
            return await SendRequestAsync(HttpMethod.Put, url, request, token);
        }

        private static async Task<string> SendRequestAsync(HttpMethod method, string url, object request, string token)
        {
            try
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                HttpRequestMessage requestMessage = new HttpRequestMessage(method, new Uri(url));

                if (request!= null)
                {
                    var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
                    requestMessage.Content = content;
                }

                var response = await _httpClient.SendAsync(requestMessage);

                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                // Log the error or return a meaningful error message
                return $"Error: {ex.Message}";
            }
        }
    }
}