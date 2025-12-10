// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A financing summary object describes a connected account's financing status in real
    /// time. A financing status is either <c>accepted</c>, <c>delivered</c>, or <c>none</c>.
    /// You can read the status of your connected accounts.
    /// </summary>
    public class FinancingSummary : StripeEntity<FinancingSummary>, IHasObject
    {
        /// <summary>
        /// The object type: financing_summary.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Additional information about the financing summary. Describes currency, advance amount,
        /// fee amount, withhold rate, remaining amount, paid amount, current repayment interval,
        /// repayment start date, and advance payout date.
        ///
        /// Only present for financing offers with the <c>paid_out</c> status.
        /// </summary>
        [JsonProperty("details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("details")]
#endif
        public FinancingSummaryDetails Details { get; set; }

        /// <summary>
        /// The unique identifier of the Financing Offer object that corresponds to the Financing
        /// Summary object.
        /// </summary>
        [JsonProperty("financing_offer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financing_offer")]
#endif
        public string FinancingOffer { get; set; }

        /// <summary>
        /// The financing status of the connected account.
        /// One of: <c>accepted</c>, <c>delivered</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
