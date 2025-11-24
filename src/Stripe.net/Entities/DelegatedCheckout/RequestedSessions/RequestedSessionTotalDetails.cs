// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionTotalDetails : StripeEntity<RequestedSessionTotalDetails>
    {
        /// <summary>
        /// The amount fulfillment of the total details.
        /// </summary>
        [JsonProperty("amount_fulfillment")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_fulfillment")]
#endif
        public long? AmountFulfillment { get; set; }

        /// <summary>
        /// The amount tax of the total details.
        /// </summary>
        [JsonProperty("amount_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_tax")]
#endif
        public long? AmountTax { get; set; }

        /// <summary>
        /// The amount of order-level discounts applied to the cart. The total discount amount for
        /// this session can be computed by summing the cart discount and the item discounts.
        /// </summary>
        [JsonProperty("amount_cart_discount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_cart_discount")]
#endif
        public long? AmountCartDiscount { get; set; }

        /// <summary>
        /// The amount of item-level discounts applied to the cart. The total discount amount for
        /// this session can be computed by summing the cart discount and the item discounts.
        /// </summary>
        [JsonProperty("amount_items_discount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_items_discount")]
#endif
        public long? AmountItemsDiscount { get; set; }

        /// <summary>
        /// The applicable fees of the total details.
        /// </summary>
        [JsonProperty("applicable_fees")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applicable_fees")]
#endif
        public List<RequestedSessionTotalDetailsApplicableFee> ApplicableFees { get; set; }
    }
}
