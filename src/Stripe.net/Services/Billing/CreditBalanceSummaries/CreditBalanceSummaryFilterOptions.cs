// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditBalanceSummaryFilterOptions : INestedOptions
    {
        /// <summary>
        /// The billing credit applicability scope for which to fetch credit balance summary.
        /// </summary>
        [JsonProperty("applicability_scope")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applicability_scope")]
#endif

        public CreditBalanceSummaryFilterApplicabilityScopeOptions ApplicabilityScope { get; set; }

        /// <summary>
        /// The credit grant for which to fetch credit balance summary.
        /// </summary>
        [JsonProperty("credit_grant")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credit_grant")]
#endif

        public string CreditGrant { get; set; }

        /// <summary>
        /// Specify the type of this filter.
        /// One of: <c>applicability_scope</c>, or <c>credit_grant</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }
    }
}
