namespace Stripe
{
    using Newtonsoft.Json;

    public class FileUploadListOptions : ListOptions
    {
        [JsonProperty("created")]
        public DateFilter Created { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }
    }
}