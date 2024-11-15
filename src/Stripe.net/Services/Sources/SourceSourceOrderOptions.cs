// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceSourceOrderOptions : INestedOptions
    {
        /// <summary>
        /// List of items constituting the order.
        /// </summary>
        [JsonProperty("items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("items")]
#endif

        public List<SourceSourceOrderItemOptions> Items { get; set; }

        /// <summary>
        /// Shipping address for the order. Required if any of the SKUs are for products that have
        /// <c>shippable</c> set to true.
        /// </summary>
        [JsonProperty("shipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping")]
#endif

        public ChargeShippingOptions Shipping { get; set; }
    }
}
