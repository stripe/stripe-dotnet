// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using Newtonsoft.Json;

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
        public string Object { get; set; }

        /// <summary>
        /// Additional information about the financing summary. Describes currency, advance amount,
        /// fee amount, withhold rate, remaining amount, paid amount, current repayment interval,
        /// repayment start date, and advance payout date.
        /// </summary>
        [JsonProperty("details")]
        public FinancingSummaryDetails Details { get; set; }

        /// <summary>
        /// Status of the Connected Account's financing. <a
        /// href="https://stripe.com/docs/api/capital/financing_summary">/v1/capital/financing_summary</a>
        /// will only return <c>details</c> for <c>paid_out</c> financing.
        /// One of: <c>accepted</c>, <c>delivered</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
