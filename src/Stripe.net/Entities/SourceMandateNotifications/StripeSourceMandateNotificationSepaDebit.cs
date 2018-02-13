using Newtonsoft.Json;

namespace Stripe
{
    public class StripeSourceMandateNotificationSepaDebit : StripeEntity
    {
        [JsonProperty("creditor_identifier")]
        public string CreditorIdentifier { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("mandate_reference")]
        public string MandateReference { get; set; }
    }
}
