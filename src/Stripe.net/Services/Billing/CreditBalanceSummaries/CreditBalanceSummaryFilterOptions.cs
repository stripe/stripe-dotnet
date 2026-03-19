// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CreditBalanceSummaryFilterOptions : INestedOptions
    {
        /// <summary>
        /// The billing credit applicability scope for which to fetch credit balance summary.
        /// </summary>
        [JsonProperty("applicability_scope")]
        [STJS.JsonPropertyName("applicability_scope")]
        public CreditBalanceSummaryFilterApplicabilityScopeOptions ApplicabilityScope { get; set; }

        /// <summary>
        /// The credit grant for which to fetch credit balance summary.
        /// </summary>
        [JsonProperty("credit_grant")]
        [STJS.JsonPropertyName("credit_grant")]
        public string CreditGrant { get; set; }

        /// <summary>
        /// Specify the type of this filter.
        /// One of: <c>applicability_scope</c>, or <c>credit_grant</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
