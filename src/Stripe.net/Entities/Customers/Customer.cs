namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Customer : StripeEntity<Customer>, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("balance")]
        public long Balance { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Default Source
        [JsonIgnore]
        public string DefaultSourceId
        {
            get => this.InternalDefaultSource?.Id;
            set => this.InternalDefaultSource = SetExpandableFieldId(value, this.InternalDefaultSource);
        }

        [JsonIgnore]
        public IPaymentSource DefaultSource
        {
            get => this.InternalDefaultSource?.ExpandedObject;
            set => this.InternalDefaultSource = SetExpandableFieldObject(value, this.InternalDefaultSource);
        }

        [JsonProperty("default_source")]
        [JsonConverter(typeof(ExpandableFieldConverter<IPaymentSource>))]
        internal ExpandableField<IPaymentSource> InternalDefaultSource { get; set; }
        #endregion

        [JsonProperty("deleted", NullValueHandling=NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        [JsonProperty("delinquent")]
        public bool? Delinquent { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discount")]
        public Discount Discount { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("invoice_prefix")]
        public string InvoicePrefix { get; set; }

        [JsonProperty("invoice_settings")]
        public CustomerInvoiceSettings InvoiceSettings { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("next_invoice_sequence")]
        public long NextInvoiceSequence { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("preferred_locales")]
        public List<string> PreferredLocales { get; set; }

        [JsonProperty("shipping")]
        public Shipping Shipping { get; set; }

        [JsonProperty("sources")]
        public StripeList<IPaymentSource> Sources { get; set; }

        [JsonProperty("subscriptions")]
        public StripeList<Subscription> Subscriptions { get; set; }

        [JsonProperty("tax_exempt")]
        public string TaxExempt { get; set; }

        [JsonProperty("tax_ids")]
        public StripeList<TaxId> TaxIds { get; set; }
    }
}
