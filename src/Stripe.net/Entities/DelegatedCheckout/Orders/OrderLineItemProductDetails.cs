// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OrderLineItemProductDetails : StripeEntity<OrderLineItemProductDetails>
    {
        /// <summary>
        /// The item description.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The item images.
        /// </summary>
        [JsonProperty("images")]
        [STJS.JsonPropertyName("images")]
        public List<string> Images { get; set; }

        /// <summary>
        /// The item title.
        /// </summary>
        [JsonProperty("title")]
        [STJS.JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
