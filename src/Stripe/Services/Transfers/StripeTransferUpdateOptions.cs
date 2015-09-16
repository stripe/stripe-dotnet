using Newtonsoft.Json;

namespace Stripe
{
    public class StripeTransferUpdateOptions
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}