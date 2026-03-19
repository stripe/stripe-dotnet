// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionLineItemDetailProductDetails : StripeEntity<RequestedSessionLineItemDetailProductDetails>
    {
        /// <summary>
        /// Custom attributes for the product.
        /// </summary>
        [JsonProperty("custom_attributes")]
        [STJS.JsonPropertyName("custom_attributes")]
        public List<RequestedSessionLineItemDetailProductDetailsCustomAttribute> CustomAttributes { get; set; }

        /// <summary>
        /// The description of the product.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Disclosures for the product.
        /// </summary>
        [JsonProperty("disclosures")]
        [STJS.JsonPropertyName("disclosures")]
        public List<RequestedSessionLineItemDetailProductDetailsDisclosure> Disclosures { get; set; }

        /// <summary>
        /// The images of the product.
        /// </summary>
        [JsonProperty("images")]
        [STJS.JsonPropertyName("images")]
        public List<string> Images { get; set; }

        /// <summary>
        /// The title of the product.
        /// </summary>
        [JsonProperty("title")]
        [STJS.JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
