using System;
using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using HtmlAgilityPack;
using GeniusAPIWrapper.JsonData;
using GeniusAPIWrapper.JsonData.Search;
using Newtonsoft.Json;

namespace GeniusAPIWrapper.Requests
{
    public class SearchApiRequest : IApiRequest, IDisposable
    {
        private const string SEARCH_CONSTANT = @"\search?q=";
        
        public async Task<IResponse> SendWebRequest(params string[] data) //TODO: To async
        {
            var requestUrl = $"{Path.Combine(APIHandler.BASE_URL, SEARCH_CONSTANT)}{data[0]}";

            var response = await APIHandler.Client.GetAsync(requestUrl);
            
            var result = await response.Content.ReadAsStringAsync();

            IResponse searchResponse = JsonConvert.DeserializeObject<SearchResponse>(result);

            return searchResponse;
        }

        public void Dispose()
        {
            APIHandler.Client.Dispose();
        }
    }
}