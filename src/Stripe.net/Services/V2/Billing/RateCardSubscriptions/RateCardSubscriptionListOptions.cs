// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RateCardSubscriptionListOptions : V2.ListOptions
    {
        /// <summary>
        /// Optionally filter by a BillingCadence. Mutually exclusive with <c>payers</c>,
        /// <c>rate_card</c>, and <c>rate_card_version</c>.
        /// </summary>
        [JsonProperty("billing_cadence")]
        [STJS.JsonPropertyName("billing_cadence")]
        public string BillingCadence { get; set; }

        /// <summary>
        /// Optionally filter by the payer associated with Billing Cadences which the Rate Card
        /// Subscriptions are subscribed to. Mutually exclusive with <c>billing_cadence</c>,
        /// <c>rate_card</c>, and <c>rate_card_version</c>.
        /// </summary>
        [JsonProperty("payer")]
        [STJS.JsonPropertyName("payer")]
        public RateCardSubscriptionListPayerOptions Payer { get; set; }

        /// <summary>
        /// Optionally filter by a RateCard. Mutually exclusive with <c>billing_cadence</c>,
        /// <c>payers</c>, and <c>rate_card_version</c>.
        /// </summary>
        [JsonProperty("rate_card")]
        [STJS.JsonPropertyName("rate_card")]
        public string RateCard { get; set; }

        /// <summary>
        /// Optionally filter by a RateCard version. Mutually exclusive with <c>billing_cadence</c>,
        /// <c>payers</c>, and <c>rate_card</c>.
        /// </summary>
        [JsonProperty("rate_card_version")]
        [STJS.JsonPropertyName("rate_card_version")]
        public string RateCardVersion { get; set; }

        /// <summary>
        /// Optionally filter by servicing status.
        /// One of: <c>active</c>, <c>canceled</c>, <c>paused</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("servicing_status")]
        [STJS.JsonPropertyName("servicing_status")]
        public string ServicingStatus { get; set; }
    }
}
