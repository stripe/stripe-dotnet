using System;
using System.Collections.Generic;
using Stripe.Infrastructure;
using Newtonsoft.Json; 

namespace Stripe
{
    public class StripeProduct : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object => "product";

        /// <summary>
        /// Whether or not the product is currently available for purchase.
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// A list of up to 5 attributes that each SKU can provide values for (e.g. ["color", "size"]).
        /// </summary>
        [JsonProperty("attributes")]
        public string[] Attributes { get; set; }

        /// <summary>
        /// A short one-line description of the product, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("caption")]
        public string Caption { get; set; }

        /// <summary>
        /// Time at which the object was created. 
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// An array of connect application identifiers that cannot purchase this product.
        /// </summary>
        [JsonProperty("deactivate_on")]
        public string[] DeactivateOn { get; set; }

        /// <summary>
        /// The product’s description, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// A list of up to 8 URLs of images for this product, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("images")]
        public string[] Images { get; set; }

        /// <summary>
        /// Flag indicating whether the object exists in live mode or test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        /// <summary>
        /// Set of key/value pairs that you can attach to an object. It can be useful for storing additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The product’s name, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The dimensions of this product for shipping purposes. A SKU associated with this product can override this value by having its own package_dimensions.
        /// </summary>
        [JsonProperty("package_dimensions")]
        public StripePackageDimensions PackageDimensions { get; set; }

        /// <summary>
        /// Whether this product is a shipped good.
        /// </summary>
        [JsonProperty("shippable")]
        public bool Shippable { get; set; }

        /// <summary>
        /// A sublist of active SKUs associated with this product.
        /// </summary>
        [JsonProperty("skus")]
        public StripeList<StripeSku> Skus { get; set; }

        [JsonProperty("updated")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Updated { get; set; }

        /// <summary>
        /// A URL of a publicly-accessible webpage for this product.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
