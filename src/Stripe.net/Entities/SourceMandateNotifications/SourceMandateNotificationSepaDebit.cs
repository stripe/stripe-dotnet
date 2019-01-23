namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceMandateNotificationSepaDebit : StripeEntity<SourceMandateNotificationSepaDebit>
    {
        [JsonProperty("creditor_identifier")]
        public string CreditorIdentifier { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("mandate_reference")]
        public string MandateReference { get; set; }
    }
}
