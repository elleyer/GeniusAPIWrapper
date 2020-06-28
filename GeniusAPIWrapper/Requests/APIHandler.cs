using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using GeniusAPIWrapper.JsonData;
using GeniusAPIWrapper.JsonData.Search;
using HtmlAgilityPack;
using Newtonsoft.Json;

namespace GeniusAPIWrapper.Requests
{
    public class APIHandler
    {
        public const string BASE_URL = @"https://api.genius.com";
        public const string GENIUS_URL = @"https://genius.com";

        public static HttpClient Client;
        public static string AccessToken { get; private set; }
        
        public APIHandler(string accessToken)
        {
            AccessToken = accessToken;

            Client = new HttpClient {BaseAddress = new Uri(BASE_URL)};
            
            Client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", APIHandler.AccessToken);
        }

        public static async Task<IResponse> SendRequest(ApiRequestType type, params string[] data)
        {
            IApiRequest request;
            
            switch (type)
            {
                case ApiRequestType.Annotations:
                    request = new AnnotationsApiRequest();
                    break;
                case ApiRequestType.Search:
                    request = new SearchApiRequest();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
            
            var req = await request.SendWebRequest(data);

            var lyricsData = string.Empty;

            while (lyricsData == string.Empty)
            { 
                lyricsData = await GetLyrics(req);
            }
            req.Lyrics = lyricsData;
            return req;
        }
        
        private static async Task<string> GetLyrics(IResponse req)
        {
            var htmlPage = new HtmlWeb();
            
            var searchResponse = req as SearchResponse;

            var lyricsPath =  searchResponse?.Response.Hits[0].Result.Url;

            var document = await htmlPage.LoadFromWebAsync(lyricsPath);

            var tl = document.DocumentNode.SelectNodes("//div[@class='" + "lyrics" + "']");

            return tl != null ? tl[0].InnerText.Trim() : string.Empty;
        }
    }
}