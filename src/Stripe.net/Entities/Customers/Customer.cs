// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// This object represents a customer of your business. Use it to <a
    /// href="https://docs.stripe.com/invoicing/customer">create recurring charges</a>, <a
    /// href="https://docs.stripe.com/payments/save-during-payment">save payment</a> and contact
    /// information, and track payments that belong to the same customer.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Customer : StripeEntity<Customer>, IHasId, IHasMetadata, IHasObject
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
        /// The customer's address.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public Address Address { get; set; }

        /// <summary>
        /// The current balance, if any, that's stored on the customer in their default currency. If
        /// negative, the customer has credit to apply to their next invoice. If positive, the
        /// customer has an amount owed that's added to their next invoice. The balance only
        /// considers amounts that Stripe hasn't successfully applied to any invoice. It doesn't
        /// reflect unpaid invoices. This balance is only taken into account after invoices
        /// finalize. For multi-currency balances, see <a
        /// href="https://docs.stripe.com/api/customers/object#customer_object-invoice_credit_balance">invoice_credit_balance</a>.
        /// </summary>
        [JsonProperty("balance")]
        [STJS.JsonPropertyName("balance")]
        public long Balance { get; set; }

        /// <summary>
        /// The customer's business name.
        /// </summary>
        [JsonProperty("business_name")]
        [STJS.JsonPropertyName("business_name")]
        public string BusinessName { get; set; }

        /// <summary>
        /// The current funds being held by Stripe on behalf of the customer. You can apply these
        /// funds towards payment intents when the source is "cash_balance". The
        /// <c>settings[reconciliation_mode]</c> field describes if these funds apply to these
        /// payment intents manually or automatically.
        /// </summary>
        [JsonProperty("cash_balance")]
        [STJS.JsonPropertyName("cash_balance")]
        public CashBalance CashBalance { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://stripe.com/docs/currencies">ISO code for the currency</a>
        /// the customer can be charged in for recurring billing purposes.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The ID of an Account representing a customer. You can use this ID with any v1 API that
        /// accepts a customer_account parameter.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        #region Expandable DefaultSource

        /// <summary>
        /// (ID of the IPaymentSource)
        /// ID of the default payment source for the customer.
        ///
        /// If you use payment methods created through the PaymentMethods API, see the <a
        /// href="https://docs.stripe.com/api/customers/object#customer_object-invoice_settings-default_payment_method">invoice_settings.default_payment_method</a>
        /// field instead.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
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
        /// href="https://docs.stripe.com/api/customers/object#customer_object-invoice_settings-default_payment_method">invoice_settings.default_payment_method</a>
        /// field instead.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public IPaymentSource DefaultSource
        {
            get => this.InternalDefaultSource?.ExpandedObject;
            set => this.InternalDefaultSource = SetExpandableFieldObject(value, this.InternalDefaultSource);
        }

        [JsonProperty("default_source")]
        [JsonConverter(typeof(ExpandableFieldConverter<IPaymentSource>))]
        [STJS.JsonPropertyName("default_source")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<IPaymentSource>))]
        internal ExpandableField<IPaymentSource> InternalDefaultSource { get; set; }
        #endregion

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("deleted")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Tracks the most recent state change on any invoice belonging to the customer. Paying an
        /// invoice or marking it uncollectible via the API will set this field to false. An
        /// automatic payment failure or passing the <c>invoice.due_date</c> will set this field to
        /// <c>true</c>.
        ///
        /// If an invoice becomes uncollectible by <a
        /// href="https://docs.stripe.com/billing/automatic-collection">dunning</a>,
        /// <c>delinquent</c> doesn't reset to <c>false</c>.
        ///
        /// If you care whether the customer has paid their most recent subscription invoice, use
        /// <c>subscription.status</c> instead. Paying or marking uncollectible any customer invoice
        /// regardless of whether it is the latest invoice for a subscription will always set this
        /// field to <c>false</c>.
        /// </summary>
        [JsonProperty("delinquent")]
        [STJS.JsonPropertyName("delinquent")]
        public bool? Delinquent { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Describes the current discount active on the customer, if there is one.
        /// </summary>
        [JsonProperty("discount")]
        [STJS.JsonPropertyName("discount")]
        public Discount Discount { get; set; }

        /// <summary>
        /// The customer's email address.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// The customer's individual name.
        /// </summary>
        [JsonProperty("individual_name")]
        [STJS.JsonPropertyName("individual_name")]
        public string IndividualName { get; set; }

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
        [STJS.JsonPropertyName("invoice_credit_balance")]
        public Dictionary<string, long> InvoiceCreditBalance { get; set; }

        /// <summary>
        /// The prefix for the customer used to generate unique invoice numbers.
        /// </summary>
        [JsonProperty("invoice_prefix")]
        [STJS.JsonPropertyName("invoice_prefix")]
        public string InvoicePrefix { get; set; }

        [JsonProperty("invoice_settings")]
        [STJS.JsonPropertyName("invoice_settings")]
        public CustomerInvoiceSettings InvoiceSettings { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
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
        /// The customer's full name or business name.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The suffix of the customer's next invoice number (for example, 0001). When the account
        /// uses account level sequencing, this parameter is ignored in API requests and the field
        /// omitted in API responses.
        /// </summary>
        [JsonProperty("next_invoice_sequence")]
        [STJS.JsonPropertyName("next_invoice_sequence")]
        public long NextInvoiceSequence { get; set; }

        /// <summary>
        /// The customer's phone number.
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The customer's preferred locales (languages), ordered by preference.
        /// </summary>
        [JsonProperty("preferred_locales")]
        [STJS.JsonPropertyName("preferred_locales")]
        public List<string> PreferredLocales { get; set; }

        /// <summary>
        /// Mailing and shipping address for the customer. Appears on invoices emailed to this
        /// customer.
        /// </summary>
        [JsonProperty("shipping")]
        [STJS.JsonPropertyName("shipping")]
        public Shipping Shipping { get; set; }

        /// <summary>
        /// The customer's payment sources, if any.
        /// </summary>
        [JsonProperty("sources")]
        [STJS.JsonPropertyName("sources")]
        public StripeList<IPaymentSource> Sources { get; set; }

        /// <summary>
        /// The customer's current subscriptions, if any.
        /// </summary>
        [JsonProperty("subscriptions")]
        [STJS.JsonPropertyName("subscriptions")]
        public StripeList<Subscription> Subscriptions { get; set; }

        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public CustomerTax Tax { get; set; }

        /// <summary>
        /// Describes the customer's tax exemption status, which is <c>none</c>, <c>exempt</c>, or
        /// <c>reverse</c>. When set to <c>reverse</c>, invoice and receipt PDFs include the
        /// following text: <strong>"Reverse charge"</strong>.
        /// One of: <c>exempt</c>, <c>none</c>, or <c>reverse</c>.
        /// </summary>
        [JsonProperty("tax_exempt")]
        [STJS.JsonPropertyName("tax_exempt")]
        public string TaxExempt { get; set; }

        /// <summary>
        /// The customer's tax IDs.
        /// </summary>
        [JsonProperty("tax_ids")]
        [STJS.JsonPropertyName("tax_ids")]
        public StripeList<TaxId> TaxIds { get; set; }

        #region Expandable TestClock

        /// <summary>
        /// (ID of the TestHelpers.TestClock)
        /// ID of the test clock that this customer belongs to.
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
        /// ID of the test clock that this customer belongs to.
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
