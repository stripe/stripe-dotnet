namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class Evidence : StripeEntity<Evidence>
    {
        [JsonProperty("fraudulent")]
        public EvidenceFraudulent Fraudulent { get; set; }

        [JsonProperty("other")]
        public EvidenceOther Other { get; set; }
    }
}
