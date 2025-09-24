// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AlertCreditBalanceThresholdFilterOptions : INestedOptions
    {
        /// <summary>
        /// The credit grants for which to configure the credit balance alert.
        /// </summary>
        [JsonProperty("credit_grants")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credit_grants")]
#endif
        public AlertCreditBalanceThresholdFilterCreditGrantsOptions CreditGrants { get; set; }

        /// <summary>
        /// Limit the scope to this credit balance alert only to this customer.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// What type of filter is being applied to this credit balance alert.
        /// One of: <c>customer</c>, or <c>tenant</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
