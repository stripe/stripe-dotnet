// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ServiceActionCreateCreditGrantPerTenantOptions : INestedOptions
    {
        /// <summary>
        /// The amount of the credit grant.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public ServiceActionCreateCreditGrantPerTenantAmountOptions Amount { get; set; }

        /// <summary>
        /// Defines the scope where the credit grant is applicable.
        /// </summary>
        [JsonProperty("applicability_config")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applicability_config")]
#endif
        public ServiceActionCreateCreditGrantPerTenantApplicabilityConfigOptions ApplicabilityConfig { get; set; }

        /// <summary>
        /// The expiry configuration for the credit grant.
        /// </summary>
        [JsonProperty("expiry_config")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expiry_config")]
#endif
        public ServiceActionCreateCreditGrantPerTenantExpiryConfigOptions ExpiryConfig { get; set; }

        /// <summary>
        /// The grant condition for the credit grant.
        /// </summary>
        [JsonProperty("grant_condition")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("grant_condition")]
#endif
        public ServiceActionCreateCreditGrantPerTenantGrantConditionOptions GrantCondition { get; set; }

        /// <summary>
        /// Customer-facing name for the credit grant.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }
    }
}
