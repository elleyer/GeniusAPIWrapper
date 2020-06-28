using System.Collections.Generic;
using Newtonsoft.Json;

namespace GeniusAPIWrapper.JsonData.Search.Response
{
    public class Hits
    { 
        [JsonProperty("highlights")] public List<Highlights> Highlights;

        [JsonProperty("index")] public string Index;
        [JsonProperty("type")] public string Type;

        [JsonProperty("result")] public Result.Result Result;
    }
}