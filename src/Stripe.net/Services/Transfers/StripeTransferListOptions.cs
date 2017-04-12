using Newtonsoft.Json;

namespace Stripe
{
    public class StripeTransferListOptions : StripeListOptions
    {
        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }
        
        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}