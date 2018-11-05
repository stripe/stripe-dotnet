namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Product : StripeEntity, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Whether or not the product is currently available for purchase.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

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
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// An array of connect application identifiers that cannot purchase this product.
        /// </summary>
        [JsonProperty("deactivate_on")]
        public string[] DeactivateOn { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

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
        public bool Livemode { get; set; }

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
        public PackageDimensions PackageDimensions { get; set; }

        /// <summary>
        /// Whether this product is a shipped good.
        /// </summary>
        [JsonProperty("shippable")]
        public bool? Shippable { get; set; }

        /// <summary>
        /// What appears on a customer's credit card statement.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// The type of the Product. Either 'good' or 'service'.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// This represents a unit of this product, such as a seat or API call, on customers' receipts and invoices.
        /// </summary>
        [JsonProperty("unit_label")]
        public string UnitLabel { get; set; }

        [JsonProperty("updated")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Updated { get; set; }

        /// <summary>
        /// A URL of a publicly-accessible webpage for this product.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
