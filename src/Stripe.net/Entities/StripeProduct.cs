using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeProduct : StripeEntityWithId
    {
        /// <summary>
        /// Gets or sets the object Type. value is "product"
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not the product is currently available for purchase.
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets an array of up to 5 attributes that each SKU can provide values for (e.g. ["color", "size"]).
        /// </summary>
        [JsonProperty("attributes")]
        public string[] Attributes { get; set; }

        /// <summary>
        /// Gets or sets a short one-line description of the product, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("caption")]
        public string Caption { get; set; }

        /// <summary>
        /// Gets or sets the creation time.
        /// </summary>
        [JsonConverter(typeof(StripeDateTimeConverter))]
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        ////TODO: deactivate_on

        /// <summary>
        /// Gets or sets the product’s description, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets an array of up to 8 URLs of images for this product, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("images")]
        public string[] Images { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the order is in live mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        /// <summary>
        /// Gets or sets a set of key/value pairs that you can attach to a product object. It can be useful for storing additional information about the product in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets the product’s name, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the dimensions of this product for shipping purposes. A SKU associated with this product can override this value by having its own package_dimensions
        /// </summary>
        [JsonProperty("package_dimensions")]
        public StripeDimensions PackageDimensions { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this product is a shipped good.
        /// </summary>
        [JsonProperty("shippable")]
        public bool Shippable { get; set; }

        /// <summary>
        /// Gets or sets a sublist of active SKUs associated with this product.
        /// </summary>
        [JsonProperty("skus")]
        public StripeList<StripeSku> StripeSkus { get; set; }

        /// <summary>
        /// Gets or sets the update time.
        /// </summary>
        [JsonConverter(typeof(StripeDateTimeConverter))]
        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        /// <summary>
        /// Gets or sets a URL of a publicly-accessible webpage for this product.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
