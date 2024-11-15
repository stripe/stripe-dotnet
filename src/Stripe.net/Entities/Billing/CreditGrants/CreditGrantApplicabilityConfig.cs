// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditGrantApplicabilityConfig : StripeEntity<CreditGrantApplicabilityConfig>
    {
        [JsonProperty("scope")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("scope")]
#endif

        public CreditGrantApplicabilityConfigScope Scope { get; set; }
    }
}
