// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ServiceActionCreditGrantPerTenantApplicabilityConfig : StripeEntity<ServiceActionCreditGrantPerTenantApplicabilityConfig>
    {
        /// <summary>
        /// The applicability scope of the credit grant.
        /// </summary>
        [JsonProperty("scope")]
        [STJS.JsonPropertyName("scope")]
        public ServiceActionCreditGrantPerTenantApplicabilityConfigScope Scope { get; set; }
    }
}
