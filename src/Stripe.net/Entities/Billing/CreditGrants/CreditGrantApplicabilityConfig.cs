// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CreditGrantApplicabilityConfig : StripeEntity<CreditGrantApplicabilityConfig>
    {
        [JsonProperty("scope")]
        [STJS.JsonPropertyName("scope")]
        public CreditGrantApplicabilityConfigScope Scope { get; set; }
    }
}
