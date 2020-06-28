using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GeniusAPIWrapper.JsonData.Search
{
    public class SearchResponse : IResponse
    {
        [JsonProperty("meta")] public Meta Meta;
        [JsonProperty("response")] public Response.Response Response;

        public string Lyrics { get; set; }
    }
}