using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KoperasiFufufafa.Api.Connectors
{
    class ConnectorsGet
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private string _baseUrl = "http://localhost:20254/";

        public async Task<CoopApiResponse?> GetCoopAsync()
        {
            var response = await _httpClient.GetAsync(_baseUrl + "coop/list");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<CoopApiResponse>(json);
        }
    public async Task<MemberApiResponse> MemberGetAsync(string memberId)
        {
            var response = await _httpClient.GetAsync(_baseUrl + "Member/" + memberId);
            response.EnsureSuccessStatusCode();
        }
    }
}


