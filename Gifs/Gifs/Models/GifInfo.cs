using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Gifs.Models
{
    public class Gif
    {
        [JsonProperty("data")]
        public ObservableCollection<GifInfo> Data { get; set; }
        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }

    public class GifInfo
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("bitly_gif_url")]
        public string BitlyGifUrl { get; set; }
        [JsonProperty("bitly_url")]
        public string BitlyUrl { get; set; }
        [JsonProperty("embed_url")]
        public string EmbedUrl { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("source")]
        public string Source { get; set; }
        [JsonProperty("rating")]
        public string Rating { get; set; }
        [JsonProperty("content_url")]
        public string ContentUrl { get; set; }
        [JsonProperty("source_tld")]
        public string SourceTld { get; set; }
        [JsonProperty("source_post_url")]
        public string SourcePostUrl { get; set; }
        [JsonProperty("is_sticker")]
        public int IsSticker { get; set; }
        [JsonProperty("import_datetime")]
        public string ImportDateTime { get; set; }
        [JsonProperty("trending_datetime")]
        public string TrendingDateTime { get; set; }
        [JsonProperty("images")]
        public Images Images { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class Images
    {
        [JsonProperty("fixed_height")]
        public FixedHeight FixedHeight { get; set; }
        [JsonProperty("preview_webp")]
        public PreviewWebp PreviewWebp { get; set; }
    }

    public class FixedHeight
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("width")]
        public string Width { get; set; }
        [JsonProperty("height")]
        public string Height { get; set; }
        [JsonProperty("size")]
        public string Size { get; set; }
        [JsonProperty("mp4")]
        public string MP4 { get; set; }
        [JsonProperty("mp4_size")]
        public string MP4Size { get; set; }
        [JsonProperty("webp")]
        public string Webp { get; set; }
        [JsonProperty("webp_size")]
        public string WebpSize { get; set; }
    }

    public class PreviewWebp
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("width")]
        public string Width { get; set; }
        [JsonProperty("Height")]
        public string height { get; set; }
        [JsonProperty("Size")]
        public string size { get; set; }
    }

    public class Meta
    {
        [JsonProperty("status")]
        public int Status { get; set; }
        [JsonProperty("msg")]
        public string Msg { get; set; }
    }
}