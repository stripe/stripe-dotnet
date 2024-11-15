// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountFeaturesIntraStripeFlowsStatusDetail : StripeEntity<FinancialAccountFeaturesIntraStripeFlowsStatusDetail>
    {
        /// <summary>
        /// Represents the reason why the status is <c>pending</c> or <c>restricted</c>.
        /// One of: <c>activating</c>, <c>capability_not_requested</c>,
        /// <c>financial_account_closed</c>, <c>rejected_other</c>,
        /// <c>rejected_unsupported_business</c>, <c>requirements_past_due</c>,
        /// <c>requirements_pending_verification</c>, <c>restricted_by_platform</c>, or
        /// <c>restricted_other</c>.
        /// </summary>
        [JsonProperty("code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("code")]
#endif

        public string Code { get; set; }

        /// <summary>
        /// Represents what the user should do, if anything, to activate the Feature.
        /// One of: <c>contact_stripe</c>, <c>provide_information</c>, or <c>remove_restriction</c>.
        /// </summary>
        [JsonProperty("resolution")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("resolution")]
#endif

        public string Resolution { get; set; }

        /// <summary>
        /// The <c>platform_restrictions</c> that are restricting this Feature.
        /// One of: <c>inbound_flows</c>, or <c>outbound_flows</c>.
        /// </summary>
        [JsonProperty("restriction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("restriction")]
#endif

        public string Restriction { get; set; }
    }
}
