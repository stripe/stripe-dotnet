// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceShippingCostOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the shipping rate to use for this order.
        /// </summary>
        [JsonProperty("shipping_rate")]
        [STJS.JsonPropertyName("shipping_rate")]
        public string ShippingRate { get; set; }

        /// <summary>
        /// Parameters to create a new ad-hoc shipping rate for this order.
        /// </summary>
        [JsonProperty("shipping_rate_data")]
        [STJS.JsonPropertyName("shipping_rate_data")]
        public InvoiceShippingCostShippingRateDataOptions ShippingRateData { get; set; }
    }
}
