namespace Stripe
{
    using Newtonsoft.Json;

    public class FileListOptions : ListOptionsWithCreated
    {
        [JsonProperty("purpose")]
        public string Purpose { get; set; }
    }
}
