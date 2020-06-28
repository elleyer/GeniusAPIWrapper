using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GeniusAPIWrapper.JsonData.Search.Response
{
    public class Response
    {
        [JsonProperty("hits")] public List<Hits> Hits = new List<Hits>();
    }
}