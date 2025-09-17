// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ServiceActionCreditGrantPerTenant : StripeEntity<ServiceActionCreditGrantPerTenant>
    {
        /// <summary>
        /// The amount of the credit grant.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public ServiceActionCreditGrantPerTenantAmount Amount { get; set; }

        /// <summary>
        /// Defines the scope where the credit grant is applicable.
        /// </summary>
        [JsonProperty("applicability_config")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applicability_config")]
#endif
        public ServiceActionCreditGrantPerTenantApplicabilityConfig ApplicabilityConfig { get; set; }

        /// <summary>
        /// The category of the credit grant.
        /// One of: <c>paid</c>, or <c>promotional</c>.
        /// </summary>
        [JsonProperty("category")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("category")]
#endif
        public string Category { get; set; }

        /// <summary>
        /// The expiry configuration for the credit grant.
        /// </summary>
        [JsonProperty("expiry_config")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expiry_config")]
#endif
        public ServiceActionCreditGrantPerTenantExpiryConfig ExpiryConfig { get; set; }

        /// <summary>
        /// Customer-facing name for the credit grant.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// The desired priority for applying this credit grant. If not specified, it will be set to
        /// the default value of 50. The highest priority is 0 and the lowest is 100.
        /// </summary>
        [JsonProperty("priority")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("priority")]
#endif
        public long? Priority { get; set; }
    }
}
