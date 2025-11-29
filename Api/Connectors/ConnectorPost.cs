using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using KoperasiFufufafa.Operation.Api.Connectors;
using KoperasiFufufafa.Operation.Api.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace KoperasiFufufafa.Api.Connectors
{
    public class ConnectorPost : ApiConnector
    {
        private readonly string _baseUrl = "https://braveman.com/api/";

        public ConnectorPost(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<TResponse> Post<TResponse, TPayload>(string endpoint, TPayload payload)
            where TResponse : ApiResponse
            where TPayload : ApiPayloadBase
        {
            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var json = JsonSerializer.Serialize(payload, options);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var url = _baseUrl + endpoint;
            HttpResponseMessage response = await HttpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();

            string responseJson = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<TResponse>(responseJson, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase, ReferenceHandler = ReferenceHandler.IgnoreCycles });
        }

        public async Task<MemberRegistrationApiResponse> MemberRegistrationApiPost(MemberRegistrationApiPayload payload)
        {
            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var json = JsonSerializer.Serialize(payload, options);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var url = _baseUrl + "memberregistrationapi";
            HttpResponseMessage response = await HttpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();

            string responseJson = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<MemberRegistrationApiResponse>(responseJson, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        }

        public async Task<DeleteApiResponse> DeleteApiPost(DeleteApiPayload payload)
        {
            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var json = JsonSerializer.Serialize(payload, options);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var url = _baseUrl + "deleteapi";
            HttpResponseMessage response = await HttpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();

            string responseJson = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<DeleteApiResponse>(responseJson, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        }

        public async Task<UpdateApiResponse> UpdateApiPost(UpdateApiPayload payload)
        {
            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var json = JsonSerializer.Serialize(payload, options);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var url = _baseUrl + "updateapi";
            HttpResponseMessage response = await HttpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();

            string responseJson = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<UpdateApiResponse>(responseJson, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        }

        public async Task<TransferApiPostResponse> TransferApiPost(TransferApiPayload payload)
        {
            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var json = JsonSerializer.Serialize(payload, options);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var url = _baseUrl + "transferapi";
            HttpResponseMessage response = await HttpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();

            string responseJson = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<TransferApiPostResponse>(responseJson, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        }
    }
}