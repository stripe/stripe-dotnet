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
    /// A Quote is a way to model prices that you'd like to provide to a customer. Once
    /// accepted, it will automatically create an invoice, subscription or subscription
    /// schedule.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Quote : StripeEntity<Quote>, IHasId, IHasMetadata, IHasObject
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
        /// Total before any discounts or taxes are applied.
        /// </summary>
        [JsonProperty("amount_subtotal")]
        [STJS.JsonPropertyName("amount_subtotal")]
        public long AmountSubtotal { get; set; }

        /// <summary>
        /// Total after discounts and taxes are applied.
        /// </summary>
        [JsonProperty("amount_total")]
        [STJS.JsonPropertyName("amount_total")]
        public long AmountTotal { get; set; }

        #region Expandable Application

        /// <summary>
        /// (ID of the Application)
        /// ID of the Connect Application that created the quote.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string ApplicationId
        {
            get => this.InternalApplication?.Id;
            set => this.InternalApplication = SetExpandableFieldId(value, this.InternalApplication);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the Connect Application that created the quote.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Application Application
        {
            get => this.InternalApplication?.ExpandedObject;
            set => this.InternalApplication = SetExpandableFieldObject(value, this.InternalApplication);
        }

        [JsonProperty("application")]
        [JsonConverter(typeof(ExpandableFieldConverter<Application>))]
        [STJS.JsonPropertyName("application")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Application>))]
        internal ExpandableField<Application> InternalApplication { get; set; }
        #endregion

        /// <summary>
        /// The amount of the application fee (if any) that will be requested to be applied to the
        /// payment and transferred to the application owner's Stripe account. Only applicable if
        /// there are no line items with recurring prices on the quote.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        [STJS.JsonPropertyName("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// A non-negative decimal between 0 and 100, with at most two decimal places. This
        /// represents the percentage of the subscription invoice total that will be transferred to
        /// the application owner's Stripe account. Only applicable if there are line items with
        /// recurring prices on the quote.
        /// </summary>
        [JsonProperty("application_fee_percent")]
        [STJS.JsonPropertyName("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

        [JsonProperty("automatic_tax")]
        [STJS.JsonPropertyName("automatic_tax")]
        public QuoteAutomaticTax AutomaticTax { get; set; }

        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>. When charging automatically,
        /// Stripe will attempt to pay invoices at the end of the subscription cycle or on
        /// finalization using the default payment method attached to the subscription or customer.
        /// When sending an invoice, Stripe will email your customer an invoice with payment
        /// instructions and mark the subscription as <c>active</c>. Defaults to
        /// <c>charge_automatically</c>.
        /// One of: <c>charge_automatically</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
        [STJS.JsonPropertyName("collection_method")]
        public string CollectionMethod { get; set; }

        [JsonProperty("computed")]
        [STJS.JsonPropertyName("computed")]
        public QuoteComputed Computed { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

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
        /// The customer who received this quote. A customer is required to finalize the quote. Once
        /// specified, you can't change it.
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
        /// The customer who received this quote. A customer is required to finalize the quote. Once
        /// specified, you can't change it.
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
        /// The account representing the customer who received this quote. A customer or account is
        /// required to finalize the quote. Once specified, you can't change it.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        #region Expandable DefaultTaxRates

        /// <summary>
        /// (IDs of the DefaultTaxRates)
        /// The tax rates applied to this quote.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public List<string> DefaultTaxRateIds
        {
            get => this.InternalDefaultTaxRates?.Select((x) => x.Id).ToList();
            set => this.InternalDefaultTaxRates = SetExpandableArrayIds<TaxRate>(value);
        }

        /// <summary>
        /// (Expanded)
        /// The tax rates applied to this quote.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public List<TaxRate> DefaultTaxRates
        {
            get => this.InternalDefaultTaxRates?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalDefaultTaxRates = SetExpandableArrayObjects(value);
        }

        [JsonProperty("default_tax_rates", ItemConverterType = typeof(ExpandableFieldConverter<TaxRate>))]
        [STJS.JsonPropertyName("default_tax_rates")]
        internal List<ExpandableField<TaxRate>> InternalDefaultTaxRates { get; set; }
        #endregion

        /// <summary>
        /// A description that will be displayed on the quote PDF.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        #region Expandable Discounts

        /// <summary>
        /// (IDs of the Discounts)
        /// The discounts applied to this quote.
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
        /// The discounts applied to this quote.
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

        /// <summary>
        /// The date on which the quote will be canceled if in <c>open</c> or <c>draft</c> status.
        /// Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// A footer that will be displayed on the quote PDF.
        /// </summary>
        [JsonProperty("footer")]
        [STJS.JsonPropertyName("footer")]
        public string Footer { get; set; }

        /// <summary>
        /// Details of the quote that was cloned. See the <a
        /// href="https://docs.stripe.com/quotes/clone">cloning documentation</a> for more details.
        /// </summary>
        [JsonProperty("from_quote")]
        [STJS.JsonPropertyName("from_quote")]
        public QuoteFromQuote FromQuote { get; set; }

        /// <summary>
        /// A header that will be displayed on the quote PDF.
        /// </summary>
        [JsonProperty("header")]
        [STJS.JsonPropertyName("header")]
        public string Header { get; set; }

        #region Expandable Invoice

        /// <summary>
        /// (ID of the Invoice)
        /// The invoice that was created from this quote.
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
        /// The invoice that was created from this quote.
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

        [JsonProperty("invoice_settings")]
        [STJS.JsonPropertyName("invoice_settings")]
        public QuoteInvoiceSettings InvoiceSettings { get; set; }

        /// <summary>
        /// A list of items the customer is being quoted for.
        /// </summary>
        [JsonProperty("line_items")]
        [STJS.JsonPropertyName("line_items")]
        public StripeList<LineItem> LineItems { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A unique number that identifies this particular quote. This number is assigned once the
        /// quote is <a href="https://docs.stripe.com/quotes/overview#finalize">finalized</a>.
        /// </summary>
        [JsonProperty("number")]
        [STJS.JsonPropertyName("number")]
        public string Number { get; set; }

        #region Expandable OnBehalfOf

        /// <summary>
        /// (ID of the Account)
        /// The account on behalf of which to charge. See the <a
        /// href="https://support.stripe.com/questions/sending-invoices-on-behalf-of-connected-accounts">Connect
        /// documentation</a> for details.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string OnBehalfOfId
        {
            get => this.InternalOnBehalfOf?.Id;
            set => this.InternalOnBehalfOf = SetExpandableFieldId(value, this.InternalOnBehalfOf);
        }

        /// <summary>
        /// (Expanded)
        /// The account on behalf of which to charge. See the <a
        /// href="https://support.stripe.com/questions/sending-invoices-on-behalf-of-connected-accounts">Connect
        /// documentation</a> for details.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Account OnBehalfOf
        {
            get => this.InternalOnBehalfOf?.ExpandedObject;
            set => this.InternalOnBehalfOf = SetExpandableFieldObject(value, this.InternalOnBehalfOf);
        }

        [JsonProperty("on_behalf_of")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        [STJS.JsonPropertyName("on_behalf_of")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalOnBehalfOf { get; set; }
        #endregion

        /// <summary>
        /// The status of the quote.
        /// One of: <c>accepted</c>, <c>canceled</c>, <c>draft</c>, or <c>open</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonProperty("status_transitions")]
        [STJS.JsonPropertyName("status_transitions")]
        public QuoteStatusTransitions StatusTransitions { get; set; }

        #region Expandable Subscription

        /// <summary>
        /// (ID of the Subscription)
        /// The subscription that was created or updated from this quote.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string SubscriptionId
        {
            get => this.InternalSubscription?.Id;
            set => this.InternalSubscription = SetExpandableFieldId(value, this.InternalSubscription);
        }

        /// <summary>
        /// (Expanded)
        /// The subscription that was created or updated from this quote.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Subscription Subscription
        {
            get => this.InternalSubscription?.ExpandedObject;
            set => this.InternalSubscription = SetExpandableFieldObject(value, this.InternalSubscription);
        }

        [JsonProperty("subscription")]
        [JsonConverter(typeof(ExpandableFieldConverter<Subscription>))]
        [STJS.JsonPropertyName("subscription")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Subscription>))]
        internal ExpandableField<Subscription> InternalSubscription { get; set; }
        #endregion

        [JsonProperty("subscription_data")]
        [STJS.JsonPropertyName("subscription_data")]
        public QuoteSubscriptionData SubscriptionData { get; set; }

        #region Expandable SubscriptionSchedule

        /// <summary>
        /// (ID of the SubscriptionSchedule)
        /// The subscription schedule that was created or updated from this quote.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string SubscriptionScheduleId
        {
            get => this.InternalSubscriptionSchedule?.Id;
            set => this.InternalSubscriptionSchedule = SetExpandableFieldId(value, this.InternalSubscriptionSchedule);
        }

        /// <summary>
        /// (Expanded)
        /// The subscription schedule that was created or updated from this quote.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public SubscriptionSchedule SubscriptionSchedule
        {
            get => this.InternalSubscriptionSchedule?.ExpandedObject;
            set => this.InternalSubscriptionSchedule = SetExpandableFieldObject(value, this.InternalSubscriptionSchedule);
        }

        [JsonProperty("subscription_schedule")]
        [JsonConverter(typeof(ExpandableFieldConverter<SubscriptionSchedule>))]
        [STJS.JsonPropertyName("subscription_schedule")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<SubscriptionSchedule>))]
        internal ExpandableField<SubscriptionSchedule> InternalSubscriptionSchedule { get; set; }
        #endregion

        #region Expandable TestClock

        /// <summary>
        /// (ID of the TestHelpers.TestClock)
        /// ID of the test clock this quote belongs to.
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
        /// ID of the test clock this quote belongs to.
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

        [JsonProperty("total_details")]
        [STJS.JsonPropertyName("total_details")]
        public QuoteTotalDetails TotalDetails { get; set; }

        /// <summary>
        /// The account (if any) the payments will be attributed to for tax reporting, and where
        /// funds from each payment will be transferred to for each of the invoices.
        /// </summary>
        [JsonProperty("transfer_data")]
        [STJS.JsonPropertyName("transfer_data")]
        public QuoteTransferData TransferData { get; set; }
    }
}
