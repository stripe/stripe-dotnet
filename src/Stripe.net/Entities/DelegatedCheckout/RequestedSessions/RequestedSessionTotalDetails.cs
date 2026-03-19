// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionTotalDetails : StripeEntity<RequestedSessionTotalDetails>
    {
        /// <summary>
        /// The amount of order-level discounts applied to the cart. The total discount amount for
        /// this session can be computed by summing the cart discount and the item discounts.
        /// </summary>
        [JsonProperty("amount_cart_discount")]
        [STJS.JsonPropertyName("amount_cart_discount")]
        public long? AmountCartDiscount { get; set; }

        /// <summary>
        /// The amount fulfillment of the total details.
        /// </summary>
        [JsonProperty("amount_fulfillment")]
        [STJS.JsonPropertyName("amount_fulfillment")]
        public long? AmountFulfillment { get; set; }

        /// <summary>
        /// The amount of item-level discounts applied to the cart. The total discount amount for
        /// this session can be computed by summing the cart discount and the item discounts.
        /// </summary>
        [JsonProperty("amount_items_discount")]
        [STJS.JsonPropertyName("amount_items_discount")]
        public long? AmountItemsDiscount { get; set; }

        /// <summary>
        /// The amount tax of the total details.
        /// </summary>
        [JsonProperty("amount_tax")]
        [STJS.JsonPropertyName("amount_tax")]
        public long? AmountTax { get; set; }

        /// <summary>
        /// The applicable fees of the total details.
        /// </summary>
        [JsonProperty("applicable_fees")]
        [STJS.JsonPropertyName("applicable_fees")]
        public List<RequestedSessionTotalDetailsApplicableFee> ApplicableFees { get; set; }
    }
}
