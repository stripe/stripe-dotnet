// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A financing object describes an account's current financing state. Used by Connect
    /// platforms to read the state of Capital offered to their connected accounts.
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
        /// </summary>
        [JsonProperty("details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("details")]
#endif
        public FinancingSummaryDetails Details { get; set; }

        /// <summary>
        /// The Financing Offer ID this Financing Summary corresponds to.
        /// </summary>
        [JsonProperty("financing_offer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financing_offer")]
#endif
        public string FinancingOffer { get; set; }

        /// <summary>
        /// Status of the Connected Account's financing. <a
        /// href="https://stripe.com/docs/api/capital/financing_summary">/v1/capital/financing_summary</a>
        /// will only return <c>details</c> for <c>paid_out</c> financing.
        /// One of: <c>accepted</c>, <c>delivered</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
