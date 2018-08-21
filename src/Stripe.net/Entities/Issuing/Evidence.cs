namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class Evidence : StripeEntity
    {
        [JsonProperty("fraudulent")]
        public EvidenceFraudulent Fraudulent { get; set; }

        [JsonProperty("other")]
        public EvidenceOther Other { get; set; }
    }
}