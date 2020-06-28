using Newtonsoft.Json;

namespace GeniusAPIWrapper.JsonData.Search.Response.Result
{
    public class PrimaryArtist
    {
        [JsonProperty("api_path")] public string ApiPath;
        [JsonProperty("header_image_url")] public string HeaderImageUrl;

        [JsonProperty("id")] public int Id;

        [JsonProperty("image_url")] public string ImageUrl;

        [JsonProperty("is_meme_verified")] public bool IsMemeVerified;

        [JsonProperty("is_verified")] public bool IsVerified;

        [JsonProperty("name")] public string Name;

        [JsonProperty("url")] public string Url;

        [JsonProperty("")] public int Iq;
    }
}