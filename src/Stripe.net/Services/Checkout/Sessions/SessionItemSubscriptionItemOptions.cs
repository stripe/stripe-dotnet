// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionItemSubscriptionItemOptions : INestedOptions
    {
        /// <summary>
        /// When set, provides configuration for this item’s quantity to be adjusted by the customer
        /// during Checkout.
        /// </summary>
        [JsonProperty("adjustable_quantity")]
        [STJS.JsonPropertyName("adjustable_quantity")]
        public SessionItemSubscriptionItemAdjustableQuantityOptions AdjustableQuantity { get; set; }

        /// <summary>
        /// The <a
        /// href="https://docs.stripe.com/api/product-catalog/trial-offer?api-version=2026-03-25.preview">Trial
        /// Offer</a> to apply to this subscription item. One of <c>price</c>, <c>price_data</c> or
        /// <c>current_trial</c> is required.
        /// </summary>
        [JsonProperty("current_trial")]
        [STJS.JsonPropertyName("current_trial")]
        public SessionItemSubscriptionItemCurrentTrialOptions CurrentTrial { get; set; }

        /// <summary>
        /// The ID of the <a href="https://docs.stripe.com/api/prices">Price</a>. One of
        /// <c>price</c>, <c>price_data</c> or <c>current_trial</c> is required.
        /// </summary>
        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// Data used to generate a new <a href="https://docs.stripe.com/api/prices">Price</a>
        /// object inline. One of <c>price</c>, <c>price_data</c> or <c>current_trial</c> is
        /// required.
        /// </summary>
        [JsonProperty("price_data")]
        [STJS.JsonPropertyName("price_data")]
        public SessionItemSubscriptionItemPriceDataOptions PriceData { get; set; }

        /// <summary>
        /// Quantity for this item.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long? Quantity { get; set; }
    }
}
