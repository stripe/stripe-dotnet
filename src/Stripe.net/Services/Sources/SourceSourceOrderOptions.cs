// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SourceSourceOrderOptions : INestedOptions
    {
        /// <summary>
        /// List of items constituting the order.
        /// </summary>
        [JsonProperty("items")]
        [STJS.JsonPropertyName("items")]
        public List<SourceSourceOrderItemOptions> Items { get; set; }

        /// <summary>
        /// Shipping address for the order. Required if any of the SKUs are for products that have
        /// <c>shippable</c> set to true.
        /// </summary>
        [JsonProperty("shipping")]
        [STJS.JsonPropertyName("shipping")]
        public ChargeShippingOptions Shipping { get; set; }
    }
}
