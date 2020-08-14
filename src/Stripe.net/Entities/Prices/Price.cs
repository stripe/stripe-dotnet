namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Price : StripeEntity<Price>, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("billing_scheme")]
        public string BillingScheme { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("lookup_key")]
        public string LookupKey { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

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

        [JsonProperty("recurring")]
        public PriceRecurring Recurring { get; set; }

        [JsonProperty("tiers")]
        public List<PriceTier> Tiers { get; set; }

        [JsonProperty("tiers_mode")]
        public string TiersMode { get; set; }

        [JsonProperty("transform_quantity")]
        public PriceTransformQuantity TransformQuantity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        [JsonProperty("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
