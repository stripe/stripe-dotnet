namespace Stripe
{
    using Newtonsoft.Json;

    public class FileLinkListOptions : ListOptionsWithCreated
    {
        [JsonProperty("expired")]
        public bool? Expired { get; set; }

        [JsonProperty("file")]
        public string FileId { get; set; }
    }
}
