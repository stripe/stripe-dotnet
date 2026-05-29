// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OrderEventAdjustment : StripeEntity<OrderEventAdjustment>
    {
        /// <summary>
        /// The amount associated with the adjustment.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The currency associated with the adjustment amount.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The description of the adjustment.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The line items associated with the adjustment.
        /// </summary>
        [JsonProperty("line_items")]
        [STJS.JsonPropertyName("line_items")]
        public List<OrderEventAdjustmentLineItem> LineItems { get; set; }

        /// <summary>
        /// The status of the adjustment.
        /// One of: <c>completed</c>, <c>failed</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The type of adjustment.
        /// One of: <c>cancellation</c>, <c>credit</c>, <c>dispute</c>,
        /// <c>original_payment_refund</c>, <c>return</c>, or <c>store_credit_refund</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
