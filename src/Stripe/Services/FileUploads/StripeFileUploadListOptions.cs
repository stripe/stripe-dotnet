using Newtonsoft.Json;

namespace Stripe
{
    public class StripeFileUploadListOptions : StripeListOptions
    {
        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }
    }
}