// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class CreditGrantApplicabilityConfig : StripeEntity<CreditGrantApplicabilityConfig>
    {
        [JsonProperty("scope")]
        public CreditGrantApplicabilityConfigScope Scope { get; set; }
    }
}
