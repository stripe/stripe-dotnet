namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Product : StripeEntity<Product>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Whether the product is currently available for purchase.
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// A list of up to 5 attributes that each SKU can provide values for (e.g., <c>["color",
        /// "size"]</c>).
        /// </summary>
        [JsonProperty("attributes")]
        public List<string> Attributes { get; set; }

        /// <summary>
        /// A short one-line description of the product, meant to be displayable to the customer.
        /// Only applicable to products of <c>type=good</c>.
        /// </summary>
        [JsonProperty("caption")]
        public string Caption { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// An array of connect application identifiers that cannot purchase this product. Only
        /// applicable to products of <c>type=good</c>.
        /// </summary>
        [JsonProperty("deactivate_on")]
        public List<string> DeactivateOn { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// The product's description, meant to be displayable to the customer. Use this field to
        /// optionally store a long form explanation of the product being sold for your own
        /// rendering purposes.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// A list of up to 8 URLs of images for this product, meant to be displayable to the
        /// customer.
        /// </summary>
        [JsonProperty("images")]
        public List<string> Images { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The product's name, meant to be displayable to the customer. Whenever this product is
        /// sold via a subscription, name will show up on associated invoice line item descriptions.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The dimensions of this product for shipping purposes. A SKU associated with this product
        /// can override this value by having its own <c>package_dimensions</c>. Only applicable to
        /// products of <c>type=good</c>.
        /// </summary>
        [JsonProperty("package_dimensions")]
        public ProductPackageDimensions PackageDimensions { get; set; }

        /// <summary>
        /// Whether this product is a shipped good. Only applicable to products of <c>type=good</c>.
        /// </summary>
        [JsonProperty("shippable")]
        public bool? Shippable { get; set; }

        /// <summary>
        /// Extra information about a product which will appear on your customer's credit card
        /// statement. In the case that multiple products are billed at once, the first statement
        /// descriptor will be used.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// The type of the product. The product is either of type <c>good</c>, which is eligible
        /// for use with Orders and SKUs, or <c>service</c>, which is eligible for use with
        /// Subscriptions and Plans.
        /// One of: <c>good</c>, or <c>service</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// A label that represents units of this product in Stripe and on customers’ receipts and
        /// invoices. When set, this will be included in associated invoice line item descriptions.
        /// </summary>
        [JsonProperty("unit_label")]
        public string UnitLabel { get; set; }

        /// <summary>
        /// Time at which the object was last updated. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("updated")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Updated { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// A URL of a publicly-accessible webpage for this product. Only applicable to products of
        /// <c>type=good</c>.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
