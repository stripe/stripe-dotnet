// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OffSessionPaymentCreateItemOneTimePriceItemPriceDataProductDataOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// The product's description, meant to be displayable to the customer. Use this field to
        /// optionally store a long form explanation of the product being sold for your own
        /// rendering purposes.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// A list of URLs of images for this product, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("images")]
        [STJS.JsonPropertyName("images")]
        public List<string> Images { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to the product. This can be useful for storing additional information about the
        /// product in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The product's name, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Tax details for this product, including the <a
        /// href="https://docs.stripe.com/tax/tax-codes">tax code</a> and an optional performance
        /// location.
        /// </summary>
        [JsonProperty("tax_details")]
        [STJS.JsonPropertyName("tax_details")]
        public OffSessionPaymentCreateItemOneTimePriceItemPriceDataProductDataTaxDetailsOptions TaxDetails { get; set; }

        /// <summary>
        /// A label that represents units of this product, such as seats or licenses.
        /// </summary>
        [JsonProperty("unit_label")]
        [STJS.JsonPropertyName("unit_label")]
        public string UnitLabel { get; set; }
    }
}
