// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ServiceActionCreditGrantPerTenantExpiryConfig : StripeEntity<ServiceActionCreditGrantPerTenantExpiryConfig>
    {
        /// <summary>
        /// The type of the expiry configuration. We currently support <c>end_of_service_period</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
