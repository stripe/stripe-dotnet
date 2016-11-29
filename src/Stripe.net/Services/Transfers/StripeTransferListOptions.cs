using Newtonsoft.Json;

namespace Stripe
{
    public class StripeTransferListOptions : StripeListOptions
    {
        [JsonProperty("date")]
        public StripeDateFilter Date { get; set; }

        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }

        [JsonProperty("recipient")]
        public string RecipientId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}