// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OffSessionPaymentCreateItemOneTimePriceItemOptions : INestedOptions
    {
        /// <summary>
        /// The ID of an existing one-time <a href="https://docs.stripe.com/api/prices">Price</a>.
        /// Provide exactly one of <c>price</c> or <c>price_data</c>.
        /// </summary>
        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// Data used to generate a new one-time <a
        /// href="https://docs.stripe.com/api/prices">Price</a> object inline. Provide exactly one
        /// of <c>price</c> or <c>price_data</c>.
        /// </summary>
        [JsonProperty("price_data")]
        [STJS.JsonPropertyName("price_data")]
        public OffSessionPaymentCreateItemOneTimePriceItemPriceDataOptions PriceData { get; set; }

        /// <summary>
        /// Quantity for this item.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long? Quantity { get; set; }
    }
}
