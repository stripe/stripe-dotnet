namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Sku : StripeEntity<Sku>, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("attributes")]
        public Dictionary<string, string> Attributes { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("deleted", NullValueHandling=NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("inventory")]
        public Inventory Inventory { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("package_dimensions")]
        public PackageDimensions PackageDimensions { get; set; }

        [JsonProperty("price")]
        public long Price { get; set; }

        #region Expandable Product
        [JsonIgnore]
        public string ProductId
        {
            get => this.InternalProduct?.Id;
            set => this.InternalProduct = SetExpandableFieldId(value, this.InternalProduct);
        }

        [JsonIgnore]
        public Product Product
        {
            get => this.InternalProduct?.ExpandedObject;
            set => this.InternalProduct = SetExpandableFieldObject(value, this.InternalProduct);
        }

        [JsonProperty("product")]
        [JsonConverter(typeof(ExpandableFieldConverter<Product>))]
        internal ExpandableField<Product> InternalProduct { get; set; }
        #endregion

        [JsonProperty("updated")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Updated { get; set; }
    }
}
