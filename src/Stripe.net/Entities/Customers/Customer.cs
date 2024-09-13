namespace Stripe
{
    using System;
    using System.Collections.Generic;
#if USE_SYSTEM_TEXT_JSON
    using System.Text.Json.Serialization;
#else
    using Newtonsoft.Json;
#endif
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
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("id")]
#else
        [JsonProperty("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("object")]
#else
        [JsonProperty("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The customer's address.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("address")]
#else
        [JsonProperty("address")]
#endif
        public Address Address { get; set; }

        /// <summary>
        /// The current balance, if any, that's stored on the customer. If negative, the customer
        /// has credit to apply to their next invoice. If positive, the customer has an amount owed
        /// that's added to their next invoice. The balance only considers amounts that Stripe
        /// hasn't successfully applied to any invoice. It doesn't reflect unpaid invoices. This
        /// balance is only taken into account after invoices finalize.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("balance")]
#else
        [JsonProperty("balance")]
#endif
        public long Balance { get; set; }

        /// <summary>
        /// The current funds being held by Stripe on behalf of the customer. You can apply these
        /// funds towards payment intents when the source is "cash_balance". The
        /// <c>settings[reconciliation_mode]</c> field describes if these funds apply to these
        /// payment intents manually or automatically.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("cash_balance")]
#else
        [JsonProperty("cash_balance")]
#endif
        public CashBalance CashBalance { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#else
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://stripe.com/docs/currencies">ISO code for the currency</a>
        /// the customer can be charged in for recurring billing purposes.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("currency")]
#else
        [JsonProperty("currency")]
#endif
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
#if USE_SYSTEM_TEXT_JSON
        [JsonIgnore]
#else
        [JsonIgnore]
#endif
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
#if USE_SYSTEM_TEXT_JSON
        [JsonIgnore]
#else
        [JsonIgnore]
#endif
        public IPaymentSource DefaultSource
        {
            get => this.InternalDefaultSource?.ExpandedObject;
            set => this.InternalDefaultSource = SetExpandableFieldObject(value, this.InternalDefaultSource);
        }

#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("default_source")]
        [JsonConverter(typeof(ExpandableFieldConverter<IPaymentSource>))]
#else
        [JsonProperty("default_source")]
        [JsonConverter(typeof(ExpandableFieldConverter<IPaymentSource>))]
#endif
        internal ExpandableField<IPaymentSource> InternalDefaultSource { get; set; }
        #endregion

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("deleted")]
#else
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
#endif
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
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("delinquent")]
#else
        [JsonProperty("delinquent")]
#endif
        public bool? Delinquent { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("description")]
#else
        [JsonProperty("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// Describes the current discount active on the customer, if there is one.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("discount")]
#else
        [JsonProperty("discount")]
#endif
        public Discount Discount { get; set; }

        /// <summary>
        /// The customer's email address.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("email")]
#else
        [JsonProperty("email")]
#endif
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
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("invoice_credit_balance")]
#else
        [JsonProperty("invoice_credit_balance")]
#endif
        public Dictionary<string, long> InvoiceCreditBalance { get; set; }

        /// <summary>
        /// The prefix for the customer used to generate unique invoice numbers.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("invoice_prefix")]
#else
        [JsonProperty("invoice_prefix")]
#endif
        public string InvoicePrefix { get; set; }

#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("invoice_settings")]
#else
        [JsonProperty("invoice_settings")]
#endif
        public CustomerInvoiceSettings InvoiceSettings { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("livemode")]
#else
        [JsonProperty("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("metadata")]
#else
        [JsonProperty("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The customer's full name or business name.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("name")]
#else
        [JsonProperty("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// The suffix of the customer's next invoice number (for example, 0001). When the account
        /// uses account level sequencing, this parameter is ignored in API requests and the field
        /// omitted in API responses.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("next_invoice_sequence")]
#else
        [JsonProperty("next_invoice_sequence")]
#endif
        public long NextInvoiceSequence { get; set; }

        /// <summary>
        /// The customer's phone number.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("phone")]
#else
        [JsonProperty("phone")]
#endif
        public string Phone { get; set; }

        /// <summary>
        /// The customer's preferred locales (languages), ordered by preference.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("preferred_locales")]
#else
        [JsonProperty("preferred_locales")]
#endif
        public List<string> PreferredLocales { get; set; }

        /// <summary>
        /// Mailing and shipping address for the customer. Appears on invoices emailed to this
        /// customer.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("shipping")]
#else
        [JsonProperty("shipping")]
#endif
        public Shipping Shipping { get; set; }

        /// <summary>
        /// The customer's payment sources, if any.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("sources")]
#else
        [JsonProperty("sources")]
#endif
        public StripeList<IPaymentSource> Sources { get; set; }

        /// <summary>
        /// The customer's current subscriptions, if any.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("subscriptions")]
#else
        [JsonProperty("subscriptions")]
#endif
        public StripeList<Subscription> Subscriptions { get; set; }

#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("tax")]
#else
        [JsonProperty("tax")]
#endif
        public CustomerTax Tax { get; set; }

        /// <summary>
        /// Describes the customer's tax exemption status, which is <c>none</c>, <c>exempt</c>, or
        /// <c>reverse</c>. When set to <c>reverse</c>, invoice and receipt PDFs include the
        /// following text: <strong>"Reverse charge"</strong>.
        /// One of: <c>exempt</c>, <c>none</c>, or <c>reverse</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("tax_exempt")]
#else
        [JsonProperty("tax_exempt")]
#endif
        public string TaxExempt { get; set; }

        /// <summary>
        /// The customer's tax IDs.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("tax_ids")]
#else
        [JsonProperty("tax_ids")]
#endif
        public StripeList<TaxId> TaxIds { get; set; }

        #region Expandable TestClock

        /// <summary>
        /// (ID of the TestHelpers.TestClock)
        /// ID of the test clock that this customer belongs to.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonIgnore]
#else
        [JsonIgnore]
#endif
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
#if USE_SYSTEM_TEXT_JSON
        [JsonIgnore]
#else
        [JsonIgnore]
#endif
        public TestHelpers.TestClock TestClock
        {
            get => this.InternalTestClock?.ExpandedObject;
            set => this.InternalTestClock = SetExpandableFieldObject(value, this.InternalTestClock);
        }

#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("test_clock")]
        [JsonConverter(typeof(ExpandableFieldConverter<TestHelpers.TestClock>))]
#else
        [JsonProperty("test_clock")]
        [JsonConverter(typeof(ExpandableFieldConverter<TestHelpers.TestClock>))]
#endif
        internal ExpandableField<TestHelpers.TestClock> InternalTestClock { get; set; }
        #endregion
    }
}
