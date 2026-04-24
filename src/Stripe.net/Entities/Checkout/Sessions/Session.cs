// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Checkout Session represents your customer's session as they pay for one-time purchases
    /// or subscriptions through <a
    /// href="https://docs.stripe.com/payments/checkout">Checkout</a> or <a
    /// href="https://docs.stripe.com/payments/payment-links">Payment Links</a>. We recommend
    /// creating a new Session each time your customer attempts to pay.
    ///
    /// Once payment is successful, the Checkout Session will contain a reference to the <a
    /// href="https://docs.stripe.com/api/customers">Customer</a>, and either the successful <a
    /// href="https://docs.stripe.com/api/payment_intents">PaymentIntent</a> or an active <a
    /// href="https://docs.stripe.com/api/subscriptions">Subscription</a>.
    ///
    /// You can create a Checkout Session on your server and redirect to its URL to begin
    /// Checkout.
    ///
    /// Related guide: <a href="https://docs.stripe.com/checkout/quickstart">Checkout
    /// quickstart</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Session : StripeEntity<Session>, IHasId, IHasMetadata, IHasObject
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
        /// Settings for price localization with <a
        /// href="https://docs.stripe.com/payments/checkout/adaptive-pricing">Adaptive Pricing</a>.
        /// </summary>
        [JsonProperty("adaptive_pricing")]
        [STJS.JsonPropertyName("adaptive_pricing")]
        public SessionAdaptivePricing AdaptivePricing { get; set; }

        /// <summary>
        /// When set, provides configuration for actions to take if this Checkout Session expires.
        /// </summary>
        [JsonProperty("after_expiration")]
        [STJS.JsonPropertyName("after_expiration")]
        public SessionAfterExpiration AfterExpiration { get; set; }

        /// <summary>
        /// Enables user redeemable promotion codes.
        /// </summary>
        [JsonProperty("allow_promotion_codes")]
        [STJS.JsonPropertyName("allow_promotion_codes")]
        public bool? AllowPromotionCodes { get; set; }

        /// <summary>
        /// Total of all items before discounts or taxes are applied.
        /// </summary>
        [JsonProperty("amount_subtotal")]
        [STJS.JsonPropertyName("amount_subtotal")]
        public long? AmountSubtotal { get; set; }

        /// <summary>
        /// Total of all items after discounts and taxes are applied.
        /// </summary>
        [JsonProperty("amount_total")]
        [STJS.JsonPropertyName("amount_total")]
        public long? AmountTotal { get; set; }

        /// <summary>
        /// Determines whether the customer's attempt to pay must be manually approved.
        ///
        /// Default is <c>auto</c>, when the customer's attempt to pay is approved automatically
        /// with no action required on your server.
        ///
        /// When set to <c>manual</c>, you must approve the customer's attempt to pay by calling <a
        /// href="api/checkout/sessions/approve">approve</a> from your server.
        /// One of: <c>auto</c>, or <c>manual</c>.
        /// </summary>
        [JsonProperty("approval_method")]
        [STJS.JsonPropertyName("approval_method")]
        public string ApprovalMethod { get; set; }

        [JsonProperty("automatic_surcharge")]
        [STJS.JsonPropertyName("automatic_surcharge")]
        public SessionAutomaticSurcharge AutomaticSurcharge { get; set; }

        [JsonProperty("automatic_tax")]
        [STJS.JsonPropertyName("automatic_tax")]
        public SessionAutomaticTax AutomaticTax { get; set; }

        /// <summary>
        /// Describes whether Checkout should collect the customer's billing address. Defaults to
        /// <c>auto</c>.
        /// One of: <c>auto</c>, or <c>required</c>.
        /// </summary>
        [JsonProperty("billing_address_collection")]
        [STJS.JsonPropertyName("billing_address_collection")]
        public string BillingAddressCollection { get; set; }

        [JsonProperty("branding_settings")]
        [STJS.JsonPropertyName("branding_settings")]
        public SessionBrandingSettings BrandingSettings { get; set; }

        /// <summary>
        /// If set, Checkout displays a back button and customers will be directed to this URL if
        /// they decide to cancel payment and return to your website.
        /// </summary>
        [JsonProperty("cancel_url")]
        [STJS.JsonPropertyName("cancel_url")]
        public string CancelUrl { get; set; }

        [JsonProperty("checkout_items")]
        [STJS.JsonPropertyName("checkout_items")]
        public List<SessionCheckoutItem> CheckoutItems { get; set; }

        /// <summary>
        /// A unique string to reference the Checkout Session. This can be a customer ID, a cart ID,
        /// or similar, and can be used to reconcile the Session with your internal systems.
        /// </summary>
        [JsonProperty("client_reference_id")]
        [STJS.JsonPropertyName("client_reference_id")]
        public string ClientReferenceId { get; set; }

        /// <summary>
        /// The client secret of your Checkout Session. Applies to Checkout Sessions with
        /// <c>ui_mode: embedded</c> or <c>ui_mode: custom</c>. For <c>ui_mode: embedded</c>, the
        /// client secret is to be used when initializing Stripe.js embedded checkout. For
        /// <c>ui_mode: custom</c>, use the client secret with <a
        /// href="https://docs.stripe.com/js/custom_checkout/init">initCheckout</a> on your front
        /// end.
        /// </summary>
        [JsonProperty("client_secret")]
        [STJS.JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Information about the customer collected within the Checkout Session.
        /// </summary>
        [JsonProperty("collected_information")]
        [STJS.JsonPropertyName("collected_information")]
        public SessionCollectedInformation CollectedInformation { get; set; }

        /// <summary>
        /// Results of <c>consent_collection</c> for this session.
        /// </summary>
        [JsonProperty("consent")]
        [STJS.JsonPropertyName("consent")]
        public SessionConsent Consent { get; set; }

        /// <summary>
        /// When set, provides configuration for the Checkout Session to gather active consent from
        /// customers.
        /// </summary>
        [JsonProperty("consent_collection")]
        [STJS.JsonPropertyName("consent_collection")]
        public SessionConsentCollection ConsentCollection { get; set; }

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

        /// <summary>
        /// Currency conversion details for <a
        /// href="https://docs.stripe.com/payments/checkout/adaptive-pricing">Adaptive Pricing</a>
        /// sessions created before 2025-03-31.
        /// </summary>
        [JsonProperty("currency_conversion")]
        [STJS.JsonPropertyName("currency_conversion")]
        public SessionCurrencyConversion CurrencyConversion { get; set; }

        /// <summary>
        /// The customer's pending attempt to pay that requires your approval. Contains information
        /// about the customer and their payment details.
        /// </summary>
        [JsonProperty("current_attempt")]
        [STJS.JsonPropertyName("current_attempt")]
        public SessionCurrentAttempt CurrentAttempt { get; set; }

        /// <summary>
        /// Collect additional information from your customer using custom fields. Up to 3 fields
        /// are supported. You can't set this parameter if <c>ui_mode</c> is <c>custom</c>.
        /// </summary>
        [JsonProperty("custom_fields")]
        [STJS.JsonPropertyName("custom_fields")]
        public List<SessionCustomField> CustomFields { get; set; }

        /// <summary>
        /// A list of the types of <a
        /// href="https://docs.stripe.com/payments/payment-methods/custom-payment-methods">custom
        /// payment methods</a> (e.g. cpmt_123) this Checkout Session is allowed to accept.
        /// </summary>
        [JsonProperty("custom_payment_method_types")]
        [STJS.JsonPropertyName("custom_payment_method_types")]
        public List<string> CustomPaymentMethodTypes { get; set; }

        [JsonProperty("custom_text")]
        [STJS.JsonPropertyName("custom_text")]
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
        [STJS.JsonIgnore]
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
        /// The ID of the account for this Session.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        /// <summary>
        /// Configure whether a Checkout Session creates a Customer when the Checkout Session
        /// completes.
        /// One of: <c>always</c>, or <c>if_required</c>.
        /// </summary>
        [JsonProperty("customer_creation")]
        [STJS.JsonPropertyName("customer_creation")]
        public string CustomerCreation { get; set; }

        /// <summary>
        /// The customer details including the customer's tax exempt status and the customer's tax
        /// IDs. Customer's address details are not present on Sessions in <c>setup</c> mode.
        /// </summary>
        [JsonProperty("customer_details")]
        [STJS.JsonPropertyName("customer_details")]
        public SessionCustomerDetails CustomerDetails { get; set; }

        /// <summary>
        /// If provided, this value will be used when the Customer object is created. If not
        /// provided, customers will be asked to enter their email address. Use this parameter to
        /// prefill customer data if you already have an email on file. To access information about
        /// the customer once the payment flow is complete, use the <c>customer</c> attribute.
        /// </summary>
        [JsonProperty("customer_email")]
        [STJS.JsonPropertyName("customer_email")]
        public string CustomerEmail { get; set; }

        /// <summary>
        /// List of coupons and promotion codes attached to the Checkout Session.
        /// </summary>
        [JsonProperty("discounts")]
        [STJS.JsonPropertyName("discounts")]
        public List<SessionDiscount> Discounts { get; set; }

        /// <summary>
        /// A list of the types of payment methods (e.g., <c>card</c>) that should be excluded from
        /// this Checkout Session. This should only be used when payment methods for this Checkout
        /// Session are managed through the <a
        /// href="https://dashboard.stripe.com/settings/payment_methods">Stripe Dashboard</a>.
        /// </summary>
        [JsonProperty("excluded_payment_method_types")]
        [STJS.JsonPropertyName("excluded_payment_method_types")]
        public List<string> ExcludedPaymentMethodTypes { get; set; }

        /// <summary>
        /// The timestamp at which the Checkout Session will expire.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The integration identifier for this Checkout Session. Multiple Checkout Sessions can
        /// have the same integration identifier.
        /// </summary>
        [JsonProperty("integration_identifier")]
        [STJS.JsonPropertyName("integration_identifier")]
        public string IntegrationIdentifier { get; set; }

        #region Expandable Invoice

        /// <summary>
        /// (ID of the Invoice)
        /// ID of the invoice created by the Checkout Session, if it exists.
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
        /// ID of the invoice created by the Checkout Session, if it exists.
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
        /// Details on the state of invoice creation for the Checkout Session.
        /// </summary>
        [JsonProperty("invoice_creation")]
        [STJS.JsonPropertyName("invoice_creation")]
        public SessionInvoiceCreation InvoiceCreation { get; set; }

        /// <summary>
        /// The line items purchased by the customer.
        /// </summary>
        [JsonProperty("line_items")]
        [STJS.JsonPropertyName("line_items")]
        public StripeList<LineItem> LineItems { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
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
        [STJS.JsonPropertyName("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Settings for Managed Payments for this Checkout Session and resulting <a
        /// href="https://stripe.com/api/payment_intents/object">PaymentIntents</a>, <a
        /// href="https://stripe.com/api/invoices/object">Invoices</a>, and <a
        /// href="https://stripe.com/api/subscriptions/object">Subscriptions</a>.
        /// </summary>
        [JsonProperty("managed_payments")]
        [STJS.JsonPropertyName("managed_payments")]
        public SessionManagedPayments ManagedPayments { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The mode of the Checkout Session.
        /// One of: <c>payment</c>, <c>setup</c>, or <c>subscription</c>.
        /// </summary>
        [JsonProperty("mode")]
        [STJS.JsonPropertyName("mode")]
        public string Mode { get; set; }

        [JsonProperty("name_collection")]
        [STJS.JsonPropertyName("name_collection")]
        public SessionNameCollection NameCollection { get; set; }

        /// <summary>
        /// The optional items presented to the customer at checkout.
        /// </summary>
        [JsonProperty("optional_items")]
        [STJS.JsonPropertyName("optional_items")]
        public List<SessionOptionalItem> OptionalItems { get; set; }

        /// <summary>
        /// Where the user is coming from. This informs the optimizations that are applied to the
        /// session.
        /// One of: <c>mobile_app</c>, or <c>web</c>.
        /// </summary>
        [JsonProperty("origin_context")]
        [STJS.JsonPropertyName("origin_context")]
        public string OriginContext { get; set; }

        #region Expandable PaymentIntent

        /// <summary>
        /// (ID of the PaymentIntent)
        /// The ID of the PaymentIntent for Checkout Sessions in <c>payment</c> mode. You can't
        /// confirm or cancel the PaymentIntent for a Checkout Session. To cancel, <a
        /// href="https://docs.stripe.com/api/checkout/sessions/expire">expire the Checkout
        /// Session</a> instead.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string PaymentIntentId
        {
            get => this.InternalPaymentIntent?.Id;
            set => this.InternalPaymentIntent = SetExpandableFieldId(value, this.InternalPaymentIntent);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the PaymentIntent for Checkout Sessions in <c>payment</c> mode. You can't
        /// confirm or cancel the PaymentIntent for a Checkout Session. To cancel, <a
        /// href="https://docs.stripe.com/api/checkout/sessions/expire">expire the Checkout
        /// Session</a> instead.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public PaymentIntent PaymentIntent
        {
            get => this.InternalPaymentIntent?.ExpandedObject;
            set => this.InternalPaymentIntent = SetExpandableFieldObject(value, this.InternalPaymentIntent);
        }

        [JsonProperty("payment_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentIntent>))]
        [STJS.JsonPropertyName("payment_intent")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PaymentIntent>))]
        internal ExpandableField<PaymentIntent> InternalPaymentIntent { get; set; }
        #endregion

        #region Expandable PaymentLink

        /// <summary>
        /// (ID of the PaymentLink)
        /// The ID of the Payment Link that created this Session.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
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
        [STJS.JsonIgnore]
        public PaymentLink PaymentLink
        {
            get => this.InternalPaymentLink?.ExpandedObject;
            set => this.InternalPaymentLink = SetExpandableFieldObject(value, this.InternalPaymentLink);
        }

        [JsonProperty("payment_link")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentLink>))]
        [STJS.JsonPropertyName("payment_link")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PaymentLink>))]
        internal ExpandableField<PaymentLink> InternalPaymentLink { get; set; }
        #endregion

        /// <summary>
        /// Configure whether a Checkout Session should collect a payment method. Defaults to
        /// <c>always</c>.
        /// One of: <c>always</c>, or <c>if_required</c>.
        /// </summary>
        [JsonProperty("payment_method_collection")]
        [STJS.JsonPropertyName("payment_method_collection")]
        public string PaymentMethodCollection { get; set; }

        /// <summary>
        /// Information about the payment method configuration used for this Checkout session if
        /// using dynamic payment methods.
        /// </summary>
        [JsonProperty("payment_method_configuration_details")]
        [STJS.JsonPropertyName("payment_method_configuration_details")]
        public SessionPaymentMethodConfigurationDetails PaymentMethodConfigurationDetails { get; set; }

        /// <summary>
        /// Payment-method-specific configuration for the PaymentIntent or SetupIntent of this
        /// CheckoutSession.
        /// </summary>
        [JsonProperty("payment_method_options")]
        [STJS.JsonPropertyName("payment_method_options")]
        public SessionPaymentMethodOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// A list of the types of payment methods (e.g. card) this Checkout Session is allowed to
        /// accept.
        /// </summary>
        [JsonProperty("payment_method_types")]
        [STJS.JsonPropertyName("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        #region Expandable PaymentRecord

        /// <summary>
        /// (ID of the PaymentRecord)
        /// The <a href="https://docs.stripe.com/api/payment-record">Payment Record</a> for this
        /// Checkout Session.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string PaymentRecordId
        {
            get => this.InternalPaymentRecord?.Id;
            set => this.InternalPaymentRecord = SetExpandableFieldId(value, this.InternalPaymentRecord);
        }

        /// <summary>
        /// (Expanded)
        /// The <a href="https://docs.stripe.com/api/payment-record">Payment Record</a> for this
        /// Checkout Session.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public PaymentRecord PaymentRecord
        {
            get => this.InternalPaymentRecord?.ExpandedObject;
            set => this.InternalPaymentRecord = SetExpandableFieldObject(value, this.InternalPaymentRecord);
        }

        [JsonProperty("payment_record")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentRecord>))]
        [STJS.JsonPropertyName("payment_record")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PaymentRecord>))]
        internal ExpandableField<PaymentRecord> InternalPaymentRecord { get; set; }
        #endregion

        /// <summary>
        /// The payment status of the Checkout Session, one of <c>paid</c>, <c>unpaid</c>, or
        /// <c>no_payment_required</c>. You can use this value to decide when to fulfill your
        /// customer's order.
        /// One of: <c>no_payment_required</c>, <c>paid</c>, or <c>unpaid</c>.
        /// </summary>
        [JsonProperty("payment_status")]
        [STJS.JsonPropertyName("payment_status")]
        public string PaymentStatus { get; set; }

        /// <summary>
        /// This property is used to set up permissions for various actions (e.g., update) on the
        /// CheckoutSession object.
        ///
        /// For specific permissions, please refer to their dedicated subsections, such as
        /// <c>permissions.update_shipping_details</c>.
        /// </summary>
        [JsonProperty("permissions")]
        [STJS.JsonPropertyName("permissions")]
        public SessionPermissions Permissions { get; set; }

        [JsonProperty("phone_number_collection")]
        [STJS.JsonPropertyName("phone_number_collection")]
        public SessionPhoneNumberCollection PhoneNumberCollection { get; set; }

        [JsonProperty("presentment_details")]
        [STJS.JsonPropertyName("presentment_details")]
        public SessionPresentmentDetails PresentmentDetails { get; set; }

        /// <summary>
        /// The ID of the original expired Checkout Session that triggered the recovery flow.
        /// </summary>
        [JsonProperty("recovered_from")]
        [STJS.JsonPropertyName("recovered_from")]
        public string RecoveredFrom { get; set; }

        /// <summary>
        /// This parameter applies to <c>ui_mode: embedded</c>. Learn more about the <a
        /// href="https://docs.stripe.com/payments/checkout/custom-success-page?payment-ui=embedded-form">redirect
        /// behavior</a> of embedded sessions. Defaults to <c>always</c>.
        /// One of: <c>always</c>, <c>if_required</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("redirect_on_completion")]
        [STJS.JsonPropertyName("redirect_on_completion")]
        public string RedirectOnCompletion { get; set; }

        /// <summary>
        /// Applies to Checkout Sessions with <c>ui_mode: embedded</c> or <c>ui_mode: custom</c>.
        /// The URL to redirect your customer back to after they authenticate or cancel their
        /// payment on the payment method's app or site.
        /// </summary>
        [JsonProperty("return_url")]
        [STJS.JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Controls saved payment method settings for the session. Only available in <c>payment</c>
        /// and <c>subscription</c> mode.
        /// </summary>
        [JsonProperty("saved_payment_method_options")]
        [STJS.JsonPropertyName("saved_payment_method_options")]
        public SessionSavedPaymentMethodOptions SavedPaymentMethodOptions { get; set; }

        #region Expandable SetupIntent

        /// <summary>
        /// (ID of the SetupIntent)
        /// The ID of the SetupIntent for Checkout Sessions in <c>setup</c> mode. You can't confirm
        /// or cancel the SetupIntent for a Checkout Session. To cancel, <a
        /// href="https://docs.stripe.com/api/checkout/sessions/expire">expire the Checkout
        /// Session</a> instead.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string SetupIntentId
        {
            get => this.InternalSetupIntent?.Id;
            set => this.InternalSetupIntent = SetExpandableFieldId(value, this.InternalSetupIntent);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the SetupIntent for Checkout Sessions in <c>setup</c> mode. You can't confirm
        /// or cancel the SetupIntent for a Checkout Session. To cancel, <a
        /// href="https://docs.stripe.com/api/checkout/sessions/expire">expire the Checkout
        /// Session</a> instead.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public SetupIntent SetupIntent
        {
            get => this.InternalSetupIntent?.ExpandedObject;
            set => this.InternalSetupIntent = SetExpandableFieldObject(value, this.InternalSetupIntent);
        }

        [JsonProperty("setup_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<SetupIntent>))]
        [STJS.JsonPropertyName("setup_intent")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<SetupIntent>))]
        internal ExpandableField<SetupIntent> InternalSetupIntent { get; set; }
        #endregion

        /// <summary>
        /// When set, provides configuration for Checkout to collect a shipping address from a
        /// customer.
        /// </summary>
        [JsonProperty("shipping_address_collection")]
        [STJS.JsonPropertyName("shipping_address_collection")]
        public SessionShippingAddressCollection ShippingAddressCollection { get; set; }

        /// <summary>
        /// The details of the customer cost of shipping, including the customer chosen
        /// ShippingRate.
        /// </summary>
        [JsonProperty("shipping_cost")]
        [STJS.JsonPropertyName("shipping_cost")]
        public SessionShippingCost ShippingCost { get; set; }

        /// <summary>
        /// The shipping rate options applied to this Session.
        /// </summary>
        [JsonProperty("shipping_options")]
        [STJS.JsonPropertyName("shipping_options")]
        public List<SessionShippingOption> ShippingOptions { get; set; }

        /// <summary>
        /// The status of the Checkout Session, one of <c>open</c>, <c>complete</c>, or
        /// <c>expired</c>.
        /// One of: <c>complete</c>, <c>expired</c>, or <c>open</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Describes the type of transaction being performed by Checkout in order to customize
        /// relevant text on the page, such as the submit button. <c>submit_type</c> can only be
        /// specified on Checkout Sessions in <c>payment</c> mode. If blank or <c>auto</c>,
        /// <c>pay</c> is used.
        /// One of: <c>auto</c>, <c>book</c>, <c>donate</c>, <c>pay</c>, or <c>subscribe</c>.
        /// </summary>
        [JsonProperty("submit_type")]
        [STJS.JsonPropertyName("submit_type")]
        public string SubmitType { get; set; }

        #region Expandable Subscription

        /// <summary>
        /// (ID of the Subscription)
        /// The ID of the <a href="https://docs.stripe.com/api/subscriptions">Subscription</a> for
        /// Checkout Sessions in <c>subscription</c> mode.
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
        /// The ID of the <a href="https://docs.stripe.com/api/subscriptions">Subscription</a> for
        /// Checkout Sessions in <c>subscription</c> mode.
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

        /// <summary>
        /// The URL the customer will be directed to after the payment or subscription creation is
        /// successful.
        /// </summary>
        [JsonProperty("success_url")]
        [STJS.JsonPropertyName("success_url")]
        public string SuccessUrl { get; set; }

        [JsonProperty("surcharge_cost")]
        [STJS.JsonPropertyName("surcharge_cost")]
        public SessionSurchargeCost SurchargeCost { get; set; }

        [JsonProperty("tax_id_collection")]
        [STJS.JsonPropertyName("tax_id_collection")]
        public SessionTaxIdCollection TaxIdCollection { get; set; }

        /// <summary>
        /// Tax and discount details for the computed total amount.
        /// </summary>
        [JsonProperty("total_details")]
        [STJS.JsonPropertyName("total_details")]
        public SessionTotalDetails TotalDetails { get; set; }

        /// <summary>
        /// The UI mode of the Session. Defaults to <c>hosted_page</c>.
        /// One of: <c>elements</c>, <c>embedded_page</c>, <c>form</c>, or <c>hosted_page</c>.
        /// </summary>
        [JsonProperty("ui_mode")]
        [STJS.JsonPropertyName("ui_mode")]
        public string UiMode { get; set; }

        /// <summary>
        /// The URL to the Checkout Session. Applies to Checkout Sessions with <c>ui_mode:
        /// hosted</c>. Redirect customers to this URL to take them to Checkout. If you’re using <a
        /// href="https://docs.stripe.com/payments/checkout/custom-domains">Custom Domains</a>, the
        /// URL will use your subdomain. Otherwise, it’ll use <c>checkout.stripe.com.</c> This value
        /// is only present when the session is active.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// Wallet-specific configuration for this Checkout Session.
        /// </summary>
        [JsonProperty("wallet_options")]
        [STJS.JsonPropertyName("wallet_options")]
        public SessionWalletOptions WalletOptions { get; set; }
    }
}
