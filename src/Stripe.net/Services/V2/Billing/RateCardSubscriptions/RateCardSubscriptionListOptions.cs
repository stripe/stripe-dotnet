// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RateCardSubscriptionListOptions : V2.ListOptions
    {
        /// <summary>
        /// Optionally filter by a BillingCadence. Mutually exclusive with <c>payers</c>,
        /// <c>rate_card</c>, and <c>rate_card_version</c>.
        /// </summary>
        [JsonProperty("billing_cadence")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_cadence")]
#endif
        public string BillingCadence { get; set; }

        /// <summary>
        /// Optionally filter by the payer associated with Cadences which the RateCardSubscriptions
        /// are subscribed to. Mutually exclusive with <c>billing_cadence</c>, <c>rate_card</c>, and
        /// <c>rate_card_version</c>.
        /// </summary>
        [JsonProperty("payer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payer")]
#endif
        public RateCardSubscriptionListPayerOptions Payer { get; set; }

        /// <summary>
        /// Optionally filter by a RateCard. Mutually exclusive with <c>billing_cadence</c>,
        /// <c>payers</c>, and <c>rate_card_version</c>.
        /// </summary>
        [JsonProperty("rate_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_card")]
#endif
        public string RateCard { get; set; }

        /// <summary>
        /// Optionally filter by a RateCard version. Mutually exclusive with <c>billing_cadence</c>,
        /// <c>payers</c>, and <c>rate_card</c>.
        /// </summary>
        [JsonProperty("rate_card_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_card_version")]
#endif
        public string RateCardVersion { get; set; }

        /// <summary>
        /// Optionally filter by servicing status.
        /// One of: <c>active</c>, <c>canceled</c>, <c>paused</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("servicing_status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("servicing_status")]
#endif
        public string ServicingStatus { get; set; }
    }
}
