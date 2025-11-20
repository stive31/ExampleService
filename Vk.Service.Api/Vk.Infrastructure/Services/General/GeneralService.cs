using Vk.Domain.Services.General;
using System.Net.Http;
using Vk.Infrastructure.Configuration;

namespace Vk.Infrastructure.Services.General
{
    public class GeneralService : IGeneralService
    {
        private HttpClient _httpClient;

        public GeneralService(IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient(ConfigSection.GeneralOptions);
        }

        public async Task ClearMapAsync(string mapName)
        {
            var response = await _httpClient.PostAsync($"/clearmap/{mapName}?api-version=10", null);
            await response.EnsureSuccessAsync();
        }

        public Task ClearRecordsAsync(string mapName, IEnumerable<string> recordKeys)
        {
            throw new NotImplementedException();
        }

        public Task ClearRecordsAsync(string mapName, string recordKeyPart)
        {
            throw new NotImplementedException();
        }
    }
}
