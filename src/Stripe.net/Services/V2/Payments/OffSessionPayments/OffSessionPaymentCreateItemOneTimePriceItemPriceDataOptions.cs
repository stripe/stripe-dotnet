// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OffSessionPaymentCreateItemOneTimePriceItemPriceDataOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the <a href="https://docs.stripe.com/api/products">Product</a> that this <a
        /// href="https://docs.stripe.com/api/prices">Price</a> will belong to. Provide exactly one
        /// of <c>product</c> or <c>product_data</c>.
        /// </summary>
        [JsonProperty("product")]
        [STJS.JsonPropertyName("product")]
        public string Product { get; set; }

        /// <summary>
        /// Data used to generate a new <a href="https://docs.stripe.com/api/products">Product</a>
        /// object inline. Provide exactly one of <c>product</c> or <c>product_data</c>.
        /// </summary>
        [JsonProperty("product_data")]
        [STJS.JsonPropertyName("product_data")]
        public OffSessionPaymentCreateItemOneTimePriceItemPriceDataProductDataOptions ProductData { get; set; }

        /// <summary>
        /// Specifies whether the price is considered inclusive of taxes or exclusive of taxes. One
        /// of <c>inclusive</c>, <c>exclusive</c>, or <c>unspecified</c>.
        /// One of: <c>exclusive</c>, <c>inclusive</c>, or <c>unspecified</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("tax_behavior")]
        [STJS.JsonPropertyName("tax_behavior")]
        public string TaxBehavior { get; set; }

        /// <summary>
        /// The amount to charge per unit and its currency. Specify <c>value</c> as a non-negative
        /// integer in the currency's minor unit (for example, <c>100</c> for USD 1.00).
        /// </summary>
        [JsonProperty("unit_amount")]
        [STJS.JsonPropertyName("unit_amount")]
        public V2.Amount UnitAmount { get; set; }
    }
}
