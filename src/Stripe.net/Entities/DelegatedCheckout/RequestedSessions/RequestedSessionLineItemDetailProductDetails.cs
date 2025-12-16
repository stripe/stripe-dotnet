// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionLineItemDetailProductDetails : StripeEntity<RequestedSessionLineItemDetailProductDetails>
    {
        /// <summary>
        /// Custom attributes for the product.
        /// </summary>
        [JsonProperty("custom_attributes")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_attributes")]
#endif
        public List<RequestedSessionLineItemDetailProductDetailsCustomAttribute> CustomAttributes { get; set; }

        /// <summary>
        /// The description of the product.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// Disclosures for the product.
        /// </summary>
        [JsonProperty("disclosures")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("disclosures")]
#endif
        public List<RequestedSessionLineItemDetailProductDetailsDisclosure> Disclosures { get; set; }

        /// <summary>
        /// The images of the product.
        /// </summary>
        [JsonProperty("images")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("images")]
#endif
        public List<string> Images { get; set; }

        /// <summary>
        /// The title of the product.
        /// </summary>
        [JsonProperty("title")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("title")]
#endif
        public string Title { get; set; }
    }
}
