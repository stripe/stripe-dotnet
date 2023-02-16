// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A Checkout Session represents your customer's session as they pay for one-time purchases
    /// or subscriptions through <a
    /// href="https://stripe.com/docs/payments/checkout">Checkout</a> or <a
    /// href="https://stripe.com/docs/payments/payment-links">Payment Links</a>. We recommend
    /// creating a new Session each time your customer attempts to pay.
    ///
    /// Once payment is successful, the Checkout Session will contain a reference to the <a
    /// href="https://stripe.com/docs/api/customers">Customer</a>, and either the successful <a
    /// href="https://stripe.com/docs/api/payment_intents">PaymentIntent</a> or an active <a
    /// href="https://stripe.com/docs/api/subscriptions">Subscription</a>.
    ///
    /// You can create a Checkout Session on your server and redirect to its URL to begin
    /// Checkout.
    ///
    /// Related guide: <a href="https://stripe.com/docs/checkout/quickstart">Checkout
    /// Quickstart</a>.
    /// </summary>
    public class Session : StripeEntity<Session>, IHasId, IHasMetadata, IHasObject
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
        /// When set, provides configuration for actions to take if this Checkout Session expires.
        /// </summary>
        [JsonProperty("after_expiration")]
        public SessionAfterExpiration AfterExpiration { get; set; }

        /// <summary>
        /// Enables user redeemable promotion codes.
        /// </summary>
        [JsonProperty("allow_promotion_codes")]
        public bool? AllowPromotionCodes { get; set; }

        /// <summary>
        /// Total of all items before discounts or taxes are applied.
        /// </summary>
        [JsonProperty("amount_subtotal")]
        public long? AmountSubtotal { get; set; }

        /// <summary>
        /// Total of all items after discounts and taxes are applied.
        /// </summary>
        [JsonProperty("amount_total")]
        public long? AmountTotal { get; set; }

        [JsonProperty("automatic_tax")]
        public SessionAutomaticTax AutomaticTax { get; set; }

        /// <summary>
        /// Describes whether Checkout should collect the customer's billing address.
        /// One of: <c>auto</c>, or <c>required</c>.
        /// </summary>
        [JsonProperty("billing_address_collection")]
        public string BillingAddressCollection { get; set; }

        /// <summary>
        /// If set, Checkout displays a back button and customers will be directed to this URL if
        /// they decide to cancel payment and return to your website.
        /// </summary>
        [JsonProperty("cancel_url")]
        public string CancelUrl { get; set; }

        /// <summary>
        /// A unique string to reference the Checkout Session. This can be a customer ID, a cart ID,
        /// or similar, and can be used to reconcile the Session with your internal systems.
        /// </summary>
        [JsonProperty("client_reference_id")]
        public string ClientReferenceId { get; set; }

        /// <summary>
        /// Results of <c>consent_collection</c> for this session.
        /// </summary>
        [JsonProperty("consent")]
        public SessionConsent Consent { get; set; }

        /// <summary>
        /// When set, provides configuration for the Checkout Session to gather active consent from
        /// customers.
        /// </summary>
        [JsonProperty("consent_collection")]
        public SessionConsentCollection ConsentCollection { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Collect additional information from your customer using custom fields. Up to 2 fields
        /// are supported.
        /// </summary>
        [JsonProperty("custom_fields")]
        public List<SessionCustomField> CustomFields { get; set; }

        [JsonProperty("custom_text")]
        public SessionCustomText CustomText { get; set; }

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The ID of the customer for this Session. For Checkout Sessions in <c>payment</c> or
        /// <c>subscription</c> mode, Checkout will create a new customer object based on
        /// information provided during the payment flow unless an existing customer was provided
        /// when the Session was created.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the customer for this Session. For Checkout Sessions in <c>payment</c> or
        /// <c>subscription</c> mode, Checkout will create a new customer object based on
        /// information provided during the payment flow unless an existing customer was provided
        /// when the Session was created.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        /// <summary>
        /// Configure whether a Checkout Session creates a Customer when the Checkout Session
        /// completes.
        /// One of: <c>always</c>, or <c>if_required</c>.
        /// </summary>
        [JsonProperty("customer_creation")]
        public string CustomerCreation { get; set; }

        /// <summary>
        /// The customer details including the customer's tax exempt status and the customer's tax
        /// IDs. Only the customer's email is present on Sessions in <c>setup</c> mode.
        /// </summary>
        [JsonProperty("customer_details")]
        public SessionCustomerDetails CustomerDetails { get; set; }

        /// <summary>
        /// If provided, this value will be used when the Customer object is created. If not
        /// provided, customers will be asked to enter their email address. Use this parameter to
        /// prefill customer data if you already have an email on file. To access information about
        /// the customer once the payment flow is complete, use the <c>customer</c> attribute.
        /// </summary>
        [JsonProperty("customer_email")]
        public string CustomerEmail { get; set; }

        /// <summary>
        /// The timestamp at which the Checkout Session will expire.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        #region Expandable Invoice

        /// <summary>
        /// (ID of the Invoice)
        /// ID of the invoice created by the Checkout Session, if it exists.
        /// </summary>
        [JsonIgnore]
        public string InvoiceId
        {
            get => this.InternalInvoice?.Id;
            set => this.InternalInvoice = SetExpandableFieldId(value, this.InternalInvoice);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the invoice created by the Checkout Session, if it exists.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Invoice Invoice
        {
            get => this.InternalInvoice?.ExpandedObject;
            set => this.InternalInvoice = SetExpandableFieldObject(value, this.InternalInvoice);
        }

        [JsonProperty("invoice")]
        [JsonConverter(typeof(ExpandableFieldConverter<Invoice>))]
        internal ExpandableField<Invoice> InternalInvoice { get; set; }
        #endregion

        /// <summary>
        /// Details on the state of invoice creation for the Checkout Session.
        /// </summary>
        [JsonProperty("invoice_creation")]
        public SessionInvoiceCreation InvoiceCreation { get; set; }

        /// <summary>
        /// The line items purchased by the customer.
        /// </summary>
        [JsonProperty("line_items")]
        public StripeList<LineItem> LineItems { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The IETF language tag of the locale Checkout is displayed in. If blank or <c>auto</c>,
        /// the browser's locale is used.
        /// One of: <c>auto</c>, <c>bg</c>, <c>cs</c>, <c>da</c>, <c>de</c>, <c>el</c>, <c>en</c>,
        /// <c>en-GB</c>, <c>es</c>, <c>es-419</c>, <c>et</c>, <c>fi</c>, <c>fil</c>, <c>fr</c>,
        /// <c>fr-CA</c>, <c>hr</c>, <c>hu</c>, <c>id</c>, <c>it</c>, <c>ja</c>, <c>ko</c>,
        /// <c>lt</c>, <c>lv</c>, <c>ms</c>, <c>mt</c>, <c>nb</c>, <c>nl</c>, <c>pl</c>, <c>pt</c>,
        /// <c>pt-BR</c>, <c>ro</c>, <c>ru</c>, <c>sk</c>, <c>sl</c>, <c>sv</c>, <c>th</c>,
        /// <c>tr</c>, <c>vi</c>, <c>zh</c>, <c>zh-HK</c>, or <c>zh-TW</c>.
        /// </summary>
        [JsonProperty("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The mode of the Checkout Session.
        /// One of: <c>payment</c>, <c>setup</c>, or <c>subscription</c>.
        /// </summary>
        [JsonProperty("mode")]
        public string Mode { get; set; }

        #region Expandable PaymentIntent

        /// <summary>
        /// (ID of the PaymentIntent)
        /// The ID of the PaymentIntent for Checkout Sessions in <c>payment</c> mode.
        /// </summary>
        [JsonIgnore]
        public string PaymentIntentId
        {
            get => this.InternalPaymentIntent?.Id;
            set => this.InternalPaymentIntent = SetExpandableFieldId(value, this.InternalPaymentIntent);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the PaymentIntent for Checkout Sessions in <c>payment</c> mode.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public PaymentIntent PaymentIntent
        {
            get => this.InternalPaymentIntent?.ExpandedObject;
            set => this.InternalPaymentIntent = SetExpandableFieldObject(value, this.InternalPaymentIntent);
        }

        [JsonProperty("payment_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentIntent>))]
        internal ExpandableField<PaymentIntent> InternalPaymentIntent { get; set; }
        #endregion

        #region Expandable PaymentLink

        /// <summary>
        /// (ID of the PaymentLink)
        /// The ID of the Payment Link that created this Session.
        /// </summary>
        [JsonIgnore]
        public string PaymentLinkId
        {
            get => this.InternalPaymentLink?.Id;
            set => this.InternalPaymentLink = SetExpandableFieldId(value, this.InternalPaymentLink);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the Payment Link that created this Session.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public PaymentLink PaymentLink
        {
            get => this.InternalPaymentLink?.ExpandedObject;
            set => this.InternalPaymentLink = SetExpandableFieldObject(value, this.InternalPaymentLink);
        }

        [JsonProperty("payment_link")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentLink>))]
        internal ExpandableField<PaymentLink> InternalPaymentLink { get; set; }
        #endregion

        /// <summary>
        /// Configure whether a Checkout Session should collect a payment method.
        /// One of: <c>always</c>, or <c>if_required</c>.
        /// </summary>
        [JsonProperty("payment_method_collection")]
        public string PaymentMethodCollection { get; set; }

        /// <summary>
        /// Payment-method-specific configuration for the PaymentIntent or SetupIntent of this
        /// CheckoutSession.
        /// </summary>
        [JsonProperty("payment_method_options")]
        public SessionPaymentMethodOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// A list of the types of payment methods (e.g. card) this Checkout Session is allowed to
        /// accept.
        /// </summary>
        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        /// <summary>
        /// The payment status of the Checkout Session, one of <c>paid</c>, <c>unpaid</c>, or
        /// <c>no_payment_required</c>. You can use this value to decide when to fulfill your
        /// customer's order.
        /// One of: <c>no_payment_required</c>, <c>paid</c>, or <c>unpaid</c>.
        /// </summary>
        [JsonProperty("payment_status")]
        public string PaymentStatus { get; set; }

        [JsonProperty("phone_number_collection")]
        public SessionPhoneNumberCollection PhoneNumberCollection { get; set; }

        /// <summary>
        /// The ID of the original expired Checkout Session that triggered the recovery flow.
        /// </summary>
        [JsonProperty("recovered_from")]
        public string RecoveredFrom { get; set; }

        #region Expandable SetupIntent

        /// <summary>
        /// (ID of the SetupIntent)
        /// The ID of the SetupIntent for Checkout Sessions in <c>setup</c> mode.
        /// </summary>
        [JsonIgnore]
        public string SetupIntentId
        {
            get => this.InternalSetupIntent?.Id;
            set => this.InternalSetupIntent = SetExpandableFieldId(value, this.InternalSetupIntent);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the SetupIntent for Checkout Sessions in <c>setup</c> mode.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public SetupIntent SetupIntent
        {
            get => this.InternalSetupIntent?.ExpandedObject;
            set => this.InternalSetupIntent = SetExpandableFieldObject(value, this.InternalSetupIntent);
        }

        [JsonProperty("setup_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<SetupIntent>))]
        internal ExpandableField<SetupIntent> InternalSetupIntent { get; set; }
        #endregion

        /// <summary>
        /// When set, provides configuration for Checkout to collect a shipping address from a
        /// customer.
        /// </summary>
        [JsonProperty("shipping_address_collection")]
        public SessionShippingAddressCollection ShippingAddressCollection { get; set; }

        /// <summary>
        /// The details of the customer cost of shipping, including the customer chosen
        /// ShippingRate.
        /// </summary>
        [JsonProperty("shipping_cost")]
        public SessionShippingCost ShippingCost { get; set; }

        /// <summary>
        /// Shipping information for this Checkout Session.
        /// </summary>
        [JsonProperty("shipping_details")]
        public SessionShippingDetails ShippingDetails { get; set; }

        /// <summary>
        /// The shipping rate options applied to this Session.
        /// </summary>
        [JsonProperty("shipping_options")]
        public List<SessionShippingOption> ShippingOptions { get; set; }

        /// <summary>
        /// The status of the Checkout Session, one of <c>open</c>, <c>complete</c>, or
        /// <c>expired</c>.
        /// One of: <c>complete</c>, <c>expired</c>, or <c>open</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Describes the type of transaction being performed by Checkout in order to customize
        /// relevant text on the page, such as the submit button. <c>submit_type</c> can only be
        /// specified on Checkout Sessions in <c>payment</c> mode, but not Checkout Sessions in
        /// <c>subscription</c> or <c>setup</c> mode.
        /// One of: <c>auto</c>, <c>book</c>, <c>donate</c>, or <c>pay</c>.
        /// </summary>
        [JsonProperty("submit_type")]
        public string SubmitType { get; set; }

        #region Expandable Subscription

        /// <summary>
        /// (ID of the Subscription)
        /// The ID of the subscription for Checkout Sessions in <c>subscription</c> mode.
        /// </summary>
        [JsonIgnore]
        public string SubscriptionId
        {
            get => this.InternalSubscription?.Id;
            set => this.InternalSubscription = SetExpandableFieldId(value, this.InternalSubscription);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the subscription for Checkout Sessions in <c>subscription</c> mode.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Subscription Subscription
        {
            get => this.InternalSubscription?.ExpandedObject;
            set => this.InternalSubscription = SetExpandableFieldObject(value, this.InternalSubscription);
        }

        [JsonProperty("subscription")]
        [JsonConverter(typeof(ExpandableFieldConverter<Subscription>))]
        internal ExpandableField<Subscription> InternalSubscription { get; set; }
        #endregion

        /// <summary>
        /// The URL the customer will be directed to after the payment or subscription creation is
        /// successful.
        /// </summary>
        [JsonProperty("success_url")]
        public string SuccessUrl { get; set; }

        [JsonProperty("tax_id_collection")]
        public SessionTaxIdCollection TaxIdCollection { get; set; }

        /// <summary>
        /// Tax and discount details for the computed total amount.
        /// </summary>
        [JsonProperty("total_details")]
        public SessionTotalDetails TotalDetails { get; set; }

        /// <summary>
        /// The URL to the Checkout Session. Redirect customers to this URL to take them to
        /// Checkout. If you’re using <a
        /// href="https://stripe.com/docs/payments/checkout/custom-domains">Custom Domains</a>, the
        /// URL will use your subdomain. Otherwise, it’ll use <c>checkout.stripe.com.</c> This value
        /// is only present when the session is active.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
