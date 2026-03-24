// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundPaymentListOptions : ListOptions
    {
        /// <summary>
        /// Only return OutboundPayments that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Only return OutboundPayments sent to this customer.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Returns objects associated with this FinancialAccount.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Only return OutboundPayments that have the given status: <c>processing</c>,
        /// <c>failed</c>, <c>posted</c>, <c>returned</c>, or <c>canceled</c>.
        /// One of: <c>canceled</c>, <c>failed</c>, <c>posted</c>, <c>processing</c>, or
        /// <c>returned</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
