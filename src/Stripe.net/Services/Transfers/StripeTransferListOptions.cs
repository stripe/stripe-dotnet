using Newtonsoft.Json;

namespace Stripe
{
    public class StripeTransferListOptions : StripeListOptions
    {
        /// <summary>
        /// Only return transfers for the destination specified by this account ID.
        /// </summary>
        [JsonProperty("destination")]
        public string DestinationAccountId { get; set; }

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