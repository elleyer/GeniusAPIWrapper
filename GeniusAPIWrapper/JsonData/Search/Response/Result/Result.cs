using Newtonsoft.Json;

namespace GeniusAPIWrapper.JsonData.Search.Response.Result
{
    public class Result
    {
        [JsonProperty("annotation_count")] public int AnnotationCount;

        [JsonProperty("api_path")] public string ApiPath;
        [JsonProperty("full_title")] public string FullTitle;
        [JsonProperty("header_image_thumbnail_url")] public string HeaderImageThumbnailUrl;
        [JsonProperty("header_image_url")] public string HeaderImageUrl;

        [JsonProperty("id")] public int Id;
        [JsonProperty("lyrics_owner_id")] public int LyricsOwnerId;

        [JsonProperty("lyrics_state")] public string LyricsState;

        [JsonProperty("path")] public string Path;

        [JsonProperty("pyongs_count")] public int? PyongsCount;

        [JsonProperty("song_art_image_thumbnail_url")] public string SongArtImageThumbnailUrl;

        [JsonProperty("song_art_image_url")] public string SongArtImageUrl;

        [JsonProperty("stats")] public Stats Stats;

        [JsonProperty("title")] public string Title;
        [JsonProperty("title_with_featured")] public string TitleWithFeatured;
        [JsonProperty("url")] public string Url;

        [JsonProperty("primary_artist")] public PrimaryArtist PrimaryArtist;
    }
}