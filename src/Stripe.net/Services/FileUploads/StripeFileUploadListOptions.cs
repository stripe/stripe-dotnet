namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeFileUploadListOptions : StripeListOptions
    {
        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }
    }
}