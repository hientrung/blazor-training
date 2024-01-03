using System.Net.Http.Json;

namespace Features.Services
{
    public class AgifyService
    {
        class ResModel
        {
            public string Name { get; set; } = "";
            public int Age { get; set; }
        }

        private HttpClient _httpClient;
        public AgifyService(HttpClient http)
        {
            _httpClient = http;
        }
        async public Task<int> GetAge(string name)
        {
            var res = await _httpClient.GetFromJsonAsync<ResModel>($"https://api.agify.io?name={name}&country_id=VN");
            return res!.Age;
        }
    }
}
