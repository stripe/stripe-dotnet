// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

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
    /// quickstart</a>.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class Session : StripeEntity<Session>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Settings for price localization with <a
        /// href="https://docs.stripe.com/payments/checkout/adaptive-pricing">Adaptive Pricing</a>.
        /// </summary>
        [JsonProperty("adaptive_pricing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("adaptive_pricing")]
#endif
        public SessionAdaptivePricing AdaptivePricing { get; set; }

        /// <summary>
        /// When set, provides configuration for actions to take if this Checkout Session expires.
        /// </summary>
        [JsonProperty("after_expiration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("after_expiration")]
#endif
        public SessionAfterExpiration AfterExpiration { get; set; }

        /// <summary>
        /// Enables user redeemable promotion codes.
        /// </summary>
        [JsonProperty("allow_promotion_codes")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("allow_promotion_codes")]
#endif
        public bool? AllowPromotionCodes { get; set; }

        /// <summary>
        /// Total of all items before discounts or taxes are applied.
        /// </summary>
        [JsonProperty("amount_subtotal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_subtotal")]
#endif
        public long? AmountSubtotal { get; set; }

        /// <summary>
        /// Total of all items after discounts and taxes are applied.
        /// </summary>
        [JsonProperty("amount_total")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_total")]
#endif
        public long? AmountTotal { get; set; }

        [JsonProperty("automatic_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("automatic_tax")]
#endif
        public SessionAutomaticTax AutomaticTax { get; set; }

        /// <summary>
        /// Describes whether Checkout should collect the customer's billing address. Defaults to
        /// <c>auto</c>.
        /// One of: <c>auto</c>, or <c>required</c>.
        /// </summary>
        [JsonProperty("billing_address_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_address_collection")]
#endif
        public string BillingAddressCollection { get; set; }

        /// <summary>
        /// If set, Checkout displays a back button and customers will be directed to this URL if
        /// they decide to cancel payment and return to your website.
        /// </summary>
        [JsonProperty("cancel_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cancel_url")]
#endif
        public string CancelUrl { get; set; }

        /// <summary>
        /// A unique string to reference the Checkout Session. This can be a customer ID, a cart ID,
        /// or similar, and can be used to reconcile the Session with your internal systems.
        /// </summary>
        [JsonProperty("client_reference_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("client_reference_id")]
#endif
        public string ClientReferenceId { get; set; }

        /// <summary>
        /// The client secret of the Session. Use this with <a
        /// href="https://stripe.com/docs/js/custom_checkout/init">initCheckout</a> on your front
        /// end.
        /// </summary>
        [JsonProperty("client_secret")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("client_secret")]
#endif
        public string ClientSecret { get; set; }

        /// <summary>
        /// Information about the customer collected within the Checkout Session.
        /// </summary>
        [JsonProperty("collected_information")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collected_information")]
#endif
        public SessionCollectedInformation CollectedInformation { get; set; }

        /// <summary>
        /// Results of <c>consent_collection</c> for this session.
        /// </summary>
        [JsonProperty("consent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("consent")]
#endif
        public SessionConsent Consent { get; set; }

        /// <summary>
        /// When set, provides configuration for the Checkout Session to gather active consent from
        /// customers.
        /// </summary>
        [JsonProperty("consent_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("consent_collection")]
#endif
        public SessionConsentCollection ConsentCollection { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Currency conversion details for <a
        /// href="https://docs.stripe.com/payments/checkout/adaptive-pricing">Adaptive Pricing</a>
        /// sessions.
        /// </summary>
        [JsonProperty("currency_conversion")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency_conversion")]
#endif
        public SessionCurrencyConversion CurrencyConversion { get; set; }

        /// <summary>
        /// Collect additional information from your customer using custom fields. Up to 3 fields
        /// are supported.
        /// </summary>
        [JsonProperty("custom_fields")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_fields")]
#endif
        public List<SessionCustomField> CustomFields { get; set; }

        [JsonProperty("custom_text")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_text")]
#endif
        public SessionCustomText CustomText { get; set; }

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The ID of the customer for this Session. For Checkout Sessions in <c>subscription</c>
        /// mode or Checkout Sessions with <c>customer_creation</c> set as <c>always</c> in
        /// <c>payment</c> mode, Checkout will create a new customer object based on information
        /// provided during the payment flow unless an existing customer was provided when the
        /// Session was created.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the customer for this Session. For Checkout Sessions in <c>subscription</c>
        /// mode or Checkout Sessions with <c>customer_creation</c> set as <c>always</c> in
        /// <c>payment</c> mode, Checkout will create a new customer object based on information
        /// provided during the payment flow unless an existing customer was provided when the
        /// Session was created.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Customer>))]
#endif
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        /// <summary>
        /// Configure whether a Checkout Session creates a Customer when the Checkout Session
        /// completes.
        /// One of: <c>always</c>, or <c>if_required</c>.
        /// </summary>
        [JsonProperty("customer_creation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_creation")]
#endif
        public string CustomerCreation { get; set; }

        /// <summary>
        /// The customer details including the customer's tax exempt status and the customer's tax
        /// IDs. Customer's address details are not present on Sessions in <c>setup</c> mode.
        /// </summary>
        [JsonProperty("customer_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_details")]
#endif
        public SessionCustomerDetails CustomerDetails { get; set; }

        /// <summary>
        /// If provided, this value will be used when the Customer object is created. If not
        /// provided, customers will be asked to enter their email address. Use this parameter to
        /// prefill customer data if you already have an email on file. To access information about
        /// the customer once the payment flow is complete, use the <c>customer</c> attribute.
        /// </summary>
        [JsonProperty("customer_email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_email")]
#endif
        public string CustomerEmail { get; set; }

        /// <summary>
        /// List of coupons and promotion codes attached to the Checkout Session.
        /// </summary>
        [JsonProperty("discounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discounts")]
#endif
        public List<SessionDiscount> Discounts { get; set; }

        /// <summary>
        /// The timestamp at which the Checkout Session will expire.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        #region Expandable Invoice

        /// <summary>
        /// (ID of the Invoice)
        /// ID of the invoice created by the Checkout Session, if it exists.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Invoice Invoice
        {
            get => this.InternalInvoice?.ExpandedObject;
            set => this.InternalInvoice = SetExpandableFieldObject(value, this.InternalInvoice);
        }

        [JsonProperty("invoice")]
        [JsonConverter(typeof(ExpandableFieldConverter<Invoice>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Invoice>))]
#endif
        internal ExpandableField<Invoice> InternalInvoice { get; set; }
        #endregion

        /// <summary>
        /// Details on the state of invoice creation for the Checkout Session.
        /// </summary>
        [JsonProperty("invoice_creation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_creation")]
#endif
        public SessionInvoiceCreation InvoiceCreation { get; set; }

        /// <summary>
        /// The line items purchased by the customer.
        /// </summary>
        [JsonProperty("line_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line_items")]
#endif
        public StripeList<LineItem> LineItems { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("locale")]
#endif
        public string Locale { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The mode of the Checkout Session.
        /// One of: <c>payment</c>, <c>setup</c>, or <c>subscription</c>.
        /// </summary>
        [JsonProperty("mode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mode")]
#endif
        public string Mode { get; set; }

        #region Expandable PaymentIntent

        /// <summary>
        /// (ID of the PaymentIntent)
        /// The ID of the PaymentIntent for Checkout Sessions in <c>payment</c> mode. You can't
        /// confirm or cancel the PaymentIntent for a Checkout Session. To cancel, <a
        /// href="https://stripe.com/docs/api/checkout/sessions/expire">expire the Checkout
        /// Session</a> instead.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string PaymentIntentId
        {
            get => this.InternalPaymentIntent?.Id;
            set => this.InternalPaymentIntent = SetExpandableFieldId(value, this.InternalPaymentIntent);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the PaymentIntent for Checkout Sessions in <c>payment</c> mode. You can't
        /// confirm or cancel the PaymentIntent for a Checkout Session. To cancel, <a
        /// href="https://stripe.com/docs/api/checkout/sessions/expire">expire the Checkout
        /// Session</a> instead.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public PaymentIntent PaymentIntent
        {
            get => this.InternalPaymentIntent?.ExpandedObject;
            set => this.InternalPaymentIntent = SetExpandableFieldObject(value, this.InternalPaymentIntent);
        }

        [JsonProperty("payment_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentIntent>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PaymentIntent>))]
#endif
        internal ExpandableField<PaymentIntent> InternalPaymentIntent { get; set; }
        #endregion

        #region Expandable PaymentLink

        /// <summary>
        /// (ID of the PaymentLink)
        /// The ID of the Payment Link that created this Session.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public PaymentLink PaymentLink
        {
            get => this.InternalPaymentLink?.ExpandedObject;
            set => this.InternalPaymentLink = SetExpandableFieldObject(value, this.InternalPaymentLink);
        }

        [JsonProperty("payment_link")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentLink>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_link")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PaymentLink>))]
#endif
        internal ExpandableField<PaymentLink> InternalPaymentLink { get; set; }
        #endregion

        /// <summary>
        /// Configure whether a Checkout Session should collect a payment method. Defaults to
        /// <c>always</c>.
        /// One of: <c>always</c>, or <c>if_required</c>.
        /// </summary>
        [JsonProperty("payment_method_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_collection")]
#endif
        public string PaymentMethodCollection { get; set; }

        /// <summary>
        /// Information about the payment method configuration used for this Checkout session if
        /// using dynamic payment methods.
        /// </summary>
        [JsonProperty("payment_method_configuration_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_configuration_details")]
#endif
        public SessionPaymentMethodConfigurationDetails PaymentMethodConfigurationDetails { get; set; }

        /// <summary>
        /// Payment-method-specific configuration for the PaymentIntent or SetupIntent of this
        /// CheckoutSession.
        /// </summary>
        [JsonProperty("payment_method_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_options")]
#endif
        public SessionPaymentMethodOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// A list of the types of payment methods (e.g. card) this Checkout Session is allowed to
        /// accept.
        /// </summary>
        [JsonProperty("payment_method_types")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_types")]
#endif
        public List<string> PaymentMethodTypes { get; set; }

        /// <summary>
        /// The payment status of the Checkout Session, one of <c>paid</c>, <c>unpaid</c>, or
        /// <c>no_payment_required</c>. You can use this value to decide when to fulfill your
        /// customer's order.
        /// One of: <c>no_payment_required</c>, <c>paid</c>, or <c>unpaid</c>.
        /// </summary>
        [JsonProperty("payment_status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_status")]
#endif
        public string PaymentStatus { get; set; }

        /// <summary>
        /// This property is used to set up permissions for various actions (e.g., update) on the
        /// CheckoutSession object.
        ///
        /// For specific permissions, please refer to their dedicated subsections, such as
        /// <c>permissions.update.shipping_details</c>.
        /// </summary>
        [JsonProperty("permissions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("permissions")]
#endif
        public SessionPermissions Permissions { get; set; }

        [JsonProperty("phone_number_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone_number_collection")]
#endif
        public SessionPhoneNumberCollection PhoneNumberCollection { get; set; }

        /// <summary>
        /// The ID of the original expired Checkout Session that triggered the recovery flow.
        /// </summary>
        [JsonProperty("recovered_from")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recovered_from")]
#endif
        public string RecoveredFrom { get; set; }

        /// <summary>
        /// This parameter applies to <c>ui_mode: embedded</c>. Learn more about the <a
        /// href="https://stripe.com/docs/payments/checkout/custom-success-page?payment-ui=embedded-form">redirect
        /// behavior</a> of embedded sessions. Defaults to <c>always</c>.
        /// One of: <c>always</c>, <c>if_required</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("redirect_on_completion")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("redirect_on_completion")]
#endif
        public string RedirectOnCompletion { get; set; }

        /// <summary>
        /// Applies to Checkout Sessions with <c>ui_mode: embedded</c> or <c>ui_mode: custom</c>.
        /// The URL to redirect your customer back to after they authenticate or cancel their
        /// payment on the payment method's app or site.
        /// </summary>
        [JsonProperty("return_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("return_url")]
#endif
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Controls saved payment method settings for the session. Only available in <c>payment</c>
        /// and <c>subscription</c> mode.
        /// </summary>
        [JsonProperty("saved_payment_method_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("saved_payment_method_options")]
#endif
        public SessionSavedPaymentMethodOptions SavedPaymentMethodOptions { get; set; }

        #region Expandable SetupIntent

        /// <summary>
        /// (ID of the SetupIntent)
        /// The ID of the SetupIntent for Checkout Sessions in <c>setup</c> mode. You can't confirm
        /// or cancel the SetupIntent for a Checkout Session. To cancel, <a
        /// href="https://stripe.com/docs/api/checkout/sessions/expire">expire the Checkout
        /// Session</a> instead.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string SetupIntentId
        {
            get => this.InternalSetupIntent?.Id;
            set => this.InternalSetupIntent = SetExpandableFieldId(value, this.InternalSetupIntent);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the SetupIntent for Checkout Sessions in <c>setup</c> mode. You can't confirm
        /// or cancel the SetupIntent for a Checkout Session. To cancel, <a
        /// href="https://stripe.com/docs/api/checkout/sessions/expire">expire the Checkout
        /// Session</a> instead.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public SetupIntent SetupIntent
        {
            get => this.InternalSetupIntent?.ExpandedObject;
            set => this.InternalSetupIntent = SetExpandableFieldObject(value, this.InternalSetupIntent);
        }

        [JsonProperty("setup_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<SetupIntent>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("setup_intent")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<SetupIntent>))]
#endif
        internal ExpandableField<SetupIntent> InternalSetupIntent { get; set; }
        #endregion

        /// <summary>
        /// When set, provides configuration for Checkout to collect a shipping address from a
        /// customer.
        /// </summary>
        [JsonProperty("shipping_address_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_address_collection")]
#endif
        public SessionShippingAddressCollection ShippingAddressCollection { get; set; }

        /// <summary>
        /// The details of the customer cost of shipping, including the customer chosen
        /// ShippingRate.
        /// </summary>
        [JsonProperty("shipping_cost")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_cost")]
#endif
        public SessionShippingCost ShippingCost { get; set; }

        /// <summary>
        /// Shipping information for this Checkout Session.
        /// </summary>
        [JsonProperty("shipping_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_details")]
#endif
        public SessionShippingDetails ShippingDetails { get; set; }

        /// <summary>
        /// The shipping rate options applied to this Session.
        /// </summary>
        [JsonProperty("shipping_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_options")]
#endif
        public List<SessionShippingOption> ShippingOptions { get; set; }

        /// <summary>
        /// The status of the Checkout Session, one of <c>open</c>, <c>complete</c>, or
        /// <c>expired</c>.
        /// One of: <c>complete</c>, <c>expired</c>, or <c>open</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Describes the type of transaction being performed by Checkout in order to customize
        /// relevant text on the page, such as the submit button. <c>submit_type</c> can only be
        /// specified on Checkout Sessions in <c>payment</c> mode. If blank or <c>auto</c>,
        /// <c>pay</c> is used.
        /// One of: <c>auto</c>, <c>book</c>, <c>donate</c>, <c>pay</c>, or <c>subscribe</c>.
        /// </summary>
        [JsonProperty("submit_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("submit_type")]
#endif
        public string SubmitType { get; set; }

        #region Expandable Subscription

        /// <summary>
        /// (ID of the Subscription)
        /// The ID of the subscription for Checkout Sessions in <c>subscription</c> mode.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Subscription Subscription
        {
            get => this.InternalSubscription?.ExpandedObject;
            set => this.InternalSubscription = SetExpandableFieldObject(value, this.InternalSubscription);
        }

        [JsonProperty("subscription")]
        [JsonConverter(typeof(ExpandableFieldConverter<Subscription>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Subscription>))]
#endif
        internal ExpandableField<Subscription> InternalSubscription { get; set; }
        #endregion

        /// <summary>
        /// The URL the customer will be directed to after the payment or subscription creation is
        /// successful.
        /// </summary>
        [JsonProperty("success_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("success_url")]
#endif
        public string SuccessUrl { get; set; }

        [JsonProperty("tax_id_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_id_collection")]
#endif
        public SessionTaxIdCollection TaxIdCollection { get; set; }

        /// <summary>
        /// Tax and discount details for the computed total amount.
        /// </summary>
        [JsonProperty("total_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("total_details")]
#endif
        public SessionTotalDetails TotalDetails { get; set; }

        /// <summary>
        /// The UI mode of the Session. Defaults to <c>hosted</c>.
        /// One of: <c>custom</c>, <c>embedded</c>, or <c>hosted</c>.
        /// </summary>
        [JsonProperty("ui_mode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ui_mode")]
#endif
        public string UiMode { get; set; }

        /// <summary>
        /// The URL to the Checkout Session. Redirect customers to this URL to take them to
        /// Checkout. If you’re using <a
        /// href="https://stripe.com/docs/payments/checkout/custom-domains">Custom Domains</a>, the
        /// URL will use your subdomain. Otherwise, it’ll use <c>checkout.stripe.com.</c> This value
        /// is only present when the session is active.
        /// </summary>
        [JsonProperty("url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("url")]
#endif
        public string Url { get; set; }
    }
}
