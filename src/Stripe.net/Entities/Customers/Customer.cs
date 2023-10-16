// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// This object represents a customer of your business. Use it to create recurring charges
    /// and track payments that belong to the same customer.
    ///
    /// Related guide: <a href="https://stripe.com/docs/payments/save-during-payment">Save a
    /// card during payment</a>.
    /// </summary>
    public class Customer : StripeEntity<Customer>, IHasId, IHasMetadata, IHasObject
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
        /// The customer's address.
        /// </summary>
        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <summary>
        /// The current balance, if any, that's stored on the customer. If negative, the customer
        /// has credit to apply to their next invoice. If positive, the customer has an amount owed
        /// that's added to their next invoice. The balance only considers amounts that Stripe
        /// hasn't successfully applied to any invoice. It doesn't reflect unpaid invoices. This
        /// balance is only taken into account after invoices finalize.
        /// </summary>
        [JsonProperty("balance")]
        public long Balance { get; set; }

        /// <summary>
        /// The current funds being held by Stripe on behalf of the customer. You can apply these
        /// funds towards payment intents when the source is "cash_balance". The
        /// <c>settings[reconciliation_mode]</c> field describes if these funds apply to these
        /// payment intents manually or automatically.
        /// </summary>
        [JsonProperty("cash_balance")]
        public CashBalance CashBalance { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://stripe.com/docs/currencies">ISO code for the currency</a>
        /// the customer can be charged in for recurring billing purposes.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable DefaultSource

        /// <summary>
        /// (ID of the IPaymentSource)
        /// ID of the default payment source for the customer.
        ///
        /// If you use payment methods created through the PaymentMethods API, see the <a
        /// href="https://stripe.com/docs/api/customers/object#customer_object-invoice_settings-default_payment_method">invoice_settings.default_payment_method</a>
        /// field instead.
        /// </summary>
        [JsonIgnore]
        public string DefaultSourceId
        {
            get => this.InternalDefaultSource?.Id;
            set => this.InternalDefaultSource = SetExpandableFieldId(value, this.InternalDefaultSource);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the default payment source for the customer.
        ///
        /// If you use payment methods created through the PaymentMethods API, see the <a
        /// href="https://stripe.com/docs/api/customers/object#customer_object-invoice_settings-default_payment_method">invoice_settings.default_payment_method</a>
        /// field instead.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
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

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Tracks the most recent state change on any invoice belonging to the customer. Paying an
        /// invoice or marking it uncollectible via the API will set this field to false. An
        /// automatic payment failure or passing the <c>invoice.due_date</c> will set this field to
        /// <c>true</c>.
        ///
        /// If an invoice becomes uncollectible by <a
        /// href="https://stripe.com/docs/billing/automatic-collection">dunning</a>,
        /// <c>delinquent</c> doesn't reset to <c>false</c>.
        ///
        /// If you care whether the customer has paid their most recent subscription invoice, use
        /// <c>subscription.status</c> instead. Paying or marking uncollectible any customer invoice
        /// regardless of whether it is the latest invoice for a subscription will always set this
        /// field to <c>false</c>.
        /// </summary>
        [JsonProperty("delinquent")]
        public bool? Delinquent { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Describes the current discount active on the customer, if there is one.
        /// </summary>
        [JsonProperty("discount")]
        public Discount Discount { get; set; }

        /// <summary>
        /// The customer's email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The current multi-currency balances, if any, that's stored on the customer. If positive
        /// in a currency, the customer has a credit to apply to their next invoice denominated in
        /// that currency. If negative, the customer has an amount owed that's added to their next
        /// invoice denominated in that currency. These balances don't apply to unpaid invoices.
        /// They solely track amounts that Stripe hasn't successfully applied to any invoice. Stripe
        /// only applies a balance in a specific currency to an invoice after that invoice (which is
        /// in the same currency) finalizes.
        /// </summary>
        [JsonProperty("invoice_credit_balance")]
        public Dictionary<string, long> InvoiceCreditBalance { get; set; }

        /// <summary>
        /// The prefix for the customer used to generate unique invoice numbers.
        /// </summary>
        [JsonProperty("invoice_prefix")]
        public string InvoicePrefix { get; set; }

        [JsonProperty("invoice_settings")]
        public CustomerInvoiceSettings InvoiceSettings { get; set; }

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
        /// The customer's full name or business name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The suffix of the customer's next invoice number (for example, 0001).
        /// </summary>
        [JsonProperty("next_invoice_sequence")]
        public long NextInvoiceSequence { get; set; }

        /// <summary>
        /// The customer's phone number.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The customer's preferred locales (languages), ordered by preference.
        /// </summary>
        [JsonProperty("preferred_locales")]
        public List<string> PreferredLocales { get; set; }

        /// <summary>
        /// Mailing and shipping address for the customer. Appears on invoices emailed to this
        /// customer.
        /// </summary>
        [JsonProperty("shipping")]
        public Shipping Shipping { get; set; }

        /// <summary>
        /// The customer's payment sources, if any.
        /// </summary>
        [JsonProperty("sources")]
        public StripeList<IPaymentSource> Sources { get; set; }

        /// <summary>
        /// The customer's current subscriptions, if any.
        /// </summary>
        [JsonProperty("subscriptions")]
        public StripeList<Subscription> Subscriptions { get; set; }

        [JsonProperty("tax")]
        public CustomerTax Tax { get; set; }

        /// <summary>
        /// Describes the customer's tax exemption status, which is <c>none</c>, <c>exempt</c>, or
        /// <c>reverse</c>. When set to <c>reverse</c>, invoice and receipt PDFs include the
        /// following text: <strong>"Reverse charge"</strong>.
        /// One of: <c>exempt</c>, <c>none</c>, or <c>reverse</c>.
        /// </summary>
        [JsonProperty("tax_exempt")]
        public string TaxExempt { get; set; }

        /// <summary>
        /// The customer's tax IDs.
        /// </summary>
        [JsonProperty("tax_ids")]
        public StripeList<TaxId> TaxIds { get; set; }

        #region Expandable TestClock

        /// <summary>
        /// (ID of the TestHelpers.TestClock)
        /// ID of the test clock that this customer belongs to.
        /// </summary>
        [JsonIgnore]
        public string TestClockId
        {
            get => this.InternalTestClock?.Id;
            set => this.InternalTestClock = SetExpandableFieldId(value, this.InternalTestClock);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the test clock that this customer belongs to.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public TestHelpers.TestClock TestClock
        {
            get => this.InternalTestClock?.ExpandedObject;
            set => this.InternalTestClock = SetExpandableFieldObject(value, this.InternalTestClock);
        }

        [JsonProperty("test_clock")]
        [JsonConverter(typeof(ExpandableFieldConverter<TestHelpers.TestClock>))]
        internal ExpandableField<TestHelpers.TestClock> InternalTestClock { get; set; }
        #endregion
    }
}
