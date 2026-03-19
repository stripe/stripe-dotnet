// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Invoice Items represent the component lines of an <a
    /// href="https://docs.stripe.com/api/invoices">invoice</a>. When you create an invoice item
    /// with an <c>invoice</c> field, it is attached to the specified invoice and included as <a
    /// href="https://docs.stripe.com/api/invoices/line_item">an invoice line item</a> within <a
    /// href="https://docs.stripe.com/api/invoices/object#invoice_object-lines">invoice.lines</a>.
    ///
    /// Invoice Items can be created before you are ready to actually send the invoice. This can
    /// be particularly useful when combined with a <a
    /// href="https://docs.stripe.com/api/subscriptions">subscription</a>. Sometimes you want to
    /// add a charge or credit to a customer, but actually charge or credit the customer's card
    /// only at the end of a regular billing cycle. This is useful for combining several charges
    /// (to minimize per-transaction fees), or for having Stripe tabulate your usage-based
    /// billing totals.
    ///
    /// Related guides: <a href="https://docs.stripe.com/invoicing/integration">Integrate with
    /// the Invoicing API</a>, <a
    /// href="https://docs.stripe.com/billing/invoices/subscription#adding-upcoming-invoice-items">Subscription
    /// Invoices</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceItem : StripeEntity<InvoiceItem>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Amount (in the <c>currency</c> specified) of the invoice item. This should always be
        /// equal to <c>unit_amount * quantity</c>.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The ID of the customer to bill for this invoice item.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the customer to bill for this invoice item.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        [STJS.JsonPropertyName("customer")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        /// <summary>
        /// The ID of the account to bill for this invoice item.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Date { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("deleted")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// If true, discounts will apply to this invoice item. Always false for prorations.
        /// </summary>
        [JsonProperty("discountable")]
        [STJS.JsonPropertyName("discountable")]
        public bool Discountable { get; set; }

        #region Expandable Discounts

        /// <summary>
        /// (IDs of the Discounts)
        /// The discounts which apply to the invoice item. Item discounts are applied before invoice
        /// discounts. Use <c>expand[]=discounts</c> to expand each discount.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public List<string> DiscountIds
        {
            get => this.InternalDiscounts?.Select((x) => x.Id).ToList();
            set => this.InternalDiscounts = SetExpandableArrayIds<Discount>(value);
        }

        /// <summary>
        /// (Expanded)
        /// The discounts which apply to the invoice item. Item discounts are applied before invoice
        /// discounts. Use <c>expand[]=discounts</c> to expand each discount.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public List<Discount> Discounts
        {
            get => this.InternalDiscounts?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalDiscounts = SetExpandableArrayObjects(value);
        }

        [JsonProperty("discounts", ItemConverterType = typeof(ExpandableFieldConverter<Discount>))]
        [STJS.JsonPropertyName("discounts")]
        internal List<ExpandableField<Discount>> InternalDiscounts { get; set; }
        #endregion

        #region Expandable Invoice

        /// <summary>
        /// (ID of the Invoice)
        /// The ID of the invoice this invoice item belongs to.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string InvoiceId
        {
            get => this.InternalInvoice?.Id;
            set => this.InternalInvoice = SetExpandableFieldId(value, this.InternalInvoice);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the invoice this invoice item belongs to.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Invoice Invoice
        {
            get => this.InternalInvoice?.ExpandedObject;
            set => this.InternalInvoice = SetExpandableFieldObject(value, this.InternalInvoice);
        }

        [JsonProperty("invoice")]
        [JsonConverter(typeof(ExpandableFieldConverter<Invoice>))]
        [STJS.JsonPropertyName("invoice")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Invoice>))]
        internal ExpandableField<Invoice> InternalInvoice { get; set; }
        #endregion

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        #region Expandable Margins

        /// <summary>
        /// (IDs of the Margins)
        /// The margins which apply to the invoice item. When set, the <c>default_margins</c> on the
        /// invoice do not apply to this invoice item.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public List<string> MarginIds
        {
            get => this.InternalMargins?.Select((x) => x.Id).ToList();
            set => this.InternalMargins = SetExpandableArrayIds<Margin>(value);
        }

        /// <summary>
        /// (Expanded)
        /// The margins which apply to the invoice item. When set, the <c>default_margins</c> on the
        /// invoice do not apply to this invoice item.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public List<Margin> Margins
        {
            get => this.InternalMargins?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalMargins = SetExpandableArrayObjects(value);
        }

        [JsonProperty("margins", ItemConverterType = typeof(ExpandableFieldConverter<Margin>))]
        [STJS.JsonPropertyName("margins")]
        internal List<ExpandableField<Margin>> InternalMargins { get; set; }
        #endregion

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The amount after discounts, but before credits and taxes. This field is <c>null</c> for
        /// <c>discountable=true</c> items.
        /// </summary>
        [JsonProperty("net_amount")]
        [STJS.JsonPropertyName("net_amount")]
        public long NetAmount { get; set; }

        /// <summary>
        /// The parent that generated this invoice item.
        /// </summary>
        [JsonProperty("parent")]
        [STJS.JsonPropertyName("parent")]
        public InvoiceItemParent Parent { get; set; }

        [JsonProperty("period")]
        [STJS.JsonPropertyName("period")]
        public InvoiceItemPeriod Period { get; set; }

        /// <summary>
        /// The pricing information of the invoice item.
        /// </summary>
        [JsonProperty("pricing")]
        [STJS.JsonPropertyName("pricing")]
        public InvoiceItemPricing Pricing { get; set; }

        /// <summary>
        /// Whether the invoice item was created automatically as a proration adjustment when the
        /// customer switched plans.
        /// </summary>
        [JsonProperty("proration")]
        [STJS.JsonPropertyName("proration")]
        public bool Proration { get; set; }

        [JsonProperty("proration_details")]
        [STJS.JsonPropertyName("proration_details")]
        public InvoiceItemProrationDetails ProrationDetails { get; set; }

        /// <summary>
        /// Quantity of units for the invoice item. If the invoice item is a proration, the quantity
        /// of the subscription that the proration was computed for.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// The tax rates which apply to the invoice item. When set, the <c>default_tax_rates</c> on
        /// the invoice do not apply to this invoice item.
        /// </summary>
        [JsonProperty("tax_rates")]
        [STJS.JsonPropertyName("tax_rates")]
        public List<TaxRate> TaxRates { get; set; }

        #region Expandable TestClock

        /// <summary>
        /// (ID of the TestHelpers.TestClock)
        /// ID of the test clock this invoice item belongs to.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string TestClockId
        {
            get => this.InternalTestClock?.Id;
            set => this.InternalTestClock = SetExpandableFieldId(value, this.InternalTestClock);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the test clock this invoice item belongs to.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public TestHelpers.TestClock TestClock
        {
            get => this.InternalTestClock?.ExpandedObject;
            set => this.InternalTestClock = SetExpandableFieldObject(value, this.InternalTestClock);
        }

        [JsonProperty("test_clock")]
        [JsonConverter(typeof(ExpandableFieldConverter<TestHelpers.TestClock>))]
        [STJS.JsonPropertyName("test_clock")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<TestHelpers.TestClock>))]
        internal ExpandableField<TestHelpers.TestClock> InternalTestClock { get; set; }
        #endregion
    }
}
