using Newtonsoft.Json;

namespace GeniusAPIWrapper.JsonData.Search.Response.Result
{
    public class Stats
    {
        [JsonProperty("unreviewed_annotations")] public int UnreviewedAnnotations;
        [JsonProperty("concurrents")] public int Concurrents;

        [JsonProperty("hot")] public bool Hot;

        [JsonProperty("pageviews")] public int PageViews;
    }
}