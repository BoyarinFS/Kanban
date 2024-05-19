using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace Kanban_Release.Components
{
    public class ApiService
    {
        public static async Task<string> PostRequest(string url, object request, string token)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, content);

            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> SendGetRequest(string url, string token)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await client.GetAsync(new Uri(url));

            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> SendDeleteRequest(string url, string token)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await client.DeleteAsync(new Uri(url));

            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> SendPutRequest(string url, object request, string token)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
            var response = await client.PutAsync(new Uri(url), content);

            return await response.Content.ReadAsStringAsync();
        }
    }
}
