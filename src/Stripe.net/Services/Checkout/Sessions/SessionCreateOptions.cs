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

    public class SessionCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Settings for price localization with <a
        /// href="https://docs.stripe.com/payments/checkout/adaptive-pricing">Adaptive Pricing</a>.
        /// </summary>
        [JsonProperty("adaptive_pricing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("adaptive_pricing")]
#endif
        public SessionAdaptivePricingOptions AdaptivePricing { get; set; }

        /// <summary>
        /// Configure actions after a Checkout Session has expired. You can't set this parameter if
        /// <c>ui_mode</c> is <c>custom</c>.
        /// </summary>
        [JsonProperty("after_expiration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("after_expiration")]
#endif
        public SessionAfterExpirationOptions AfterExpiration { get; set; }

        /// <summary>
        /// Enables user redeemable promotion codes.
        /// </summary>
        [JsonProperty("allow_promotion_codes")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("allow_promotion_codes")]
#endif
        public bool? AllowPromotionCodes { get; set; }

        /// <summary>
        /// Settings for automatic tax lookup for this session and resulting payments, invoices, and
        /// subscriptions.
        /// </summary>
        [JsonProperty("automatic_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("automatic_tax")]
#endif
        public SessionAutomaticTaxOptions AutomaticTax { get; set; }

        /// <summary>
        /// Specify whether Checkout should collect the customer's billing address. Defaults to
        /// <c>auto</c>.
        /// One of: <c>auto</c>, or <c>required</c>.
        /// </summary>
        [JsonProperty("billing_address_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_address_collection")]
#endif
        public string BillingAddressCollection { get; set; }

        /// <summary>
        /// The branding settings for the Checkout Session. This parameter is not allowed if ui_mode
        /// is <c>custom</c>.
        /// </summary>
        [JsonProperty("branding_settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("branding_settings")]
#endif
        public SessionBrandingSettingsOptions BrandingSettings { get; set; }

        /// <summary>
        /// If set, Checkout displays a back button and customers will be directed to this URL if
        /// they decide to cancel payment and return to your website. This parameter is not allowed
        /// if ui_mode is <c>embedded</c> or <c>custom</c>.
        /// </summary>
        [JsonProperty("cancel_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cancel_url")]
#endif
        public string CancelUrl { get; set; }

        /// <summary>
        /// A unique string to reference the Checkout Session. This can be a customer ID, a cart ID,
        /// or similar, and can be used to reconcile the session with your internal systems.
        /// </summary>
        [JsonProperty("client_reference_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("client_reference_id")]
#endif
        public string ClientReferenceId { get; set; }

        /// <summary>
        /// Configure fields for the Checkout Session to gather active consent from customers.
        /// </summary>
        [JsonProperty("consent_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("consent_collection")]
#endif
        public SessionConsentCollectionOptions ConsentCollection { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>. Required in <c>setup</c> mode when <c>payment_method_types</c> is not set.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Collect additional information from your customer using custom fields. Up to 3 fields
        /// are supported. You can't set this parameter if <c>ui_mode</c> is <c>custom</c>.
        /// </summary>
        [JsonProperty("custom_fields")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_fields")]
#endif
        public List<SessionCustomFieldOptions> CustomFields { get; set; }

        /// <summary>
        /// Display additional text for your customers using custom text. You can't set this
        /// parameter if <c>ui_mode</c> is <c>custom</c>.
        /// </summary>
        [JsonProperty("custom_text")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_text")]
#endif
        public SessionCustomTextOptions CustomText { get; set; }

        /// <summary>
        /// ID of an existing Customer, if one exists. In <c>payment</c> mode, the customer’s most
        /// recently saved card payment method will be used to prefill the email, name, card
        /// details, and billing address on the Checkout page. In <c>subscription</c> mode, the
        /// customer’s <a
        /// href="https://docs.stripe.com/api/customers/update#update_customer-invoice_settings-default_payment_method">default
        /// payment method</a> will be used if it’s a card, otherwise the most recently saved card
        /// will be used. A valid billing address, billing name and billing email are required on
        /// the payment method for Checkout to prefill the customer's card details.
        ///
        /// If the Customer already has a valid <a
        /// href="https://docs.stripe.com/api/customers/object#customer_object-email">email</a> set,
        /// the email will be prefilled and not editable in Checkout. If the Customer does not have
        /// a valid <c>email</c>, Checkout will set the email entered during the session on the
        /// Customer.
        ///
        /// If blank for Checkout Sessions in <c>subscription</c> mode or with
        /// <c>customer_creation</c> set as <c>always</c> in <c>payment</c> mode, Checkout will
        /// create a new Customer object based on information provided during the payment flow.
        ///
        /// You can set <a
        /// href="https://docs.stripe.com/api/checkout/sessions/create#create_checkout_session-payment_intent_data-setup_future_usage"><c>payment_intent_data.setup_future_usage</c></a>
        /// to have Checkout automatically attach the payment method to the Customer you pass in for
        /// future reuse.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// ID of an existing Account, if one exists. Has the same behavior as <c>customer</c>.
        /// </summary>
        [JsonProperty("customer_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_account")]
#endif
        public string CustomerAccount { get; set; }

        /// <summary>
        /// Configure whether a Checkout Session creates a <a
        /// href="https://docs.stripe.com/api/customers">Customer</a> during Session confirmation.
        ///
        /// When a Customer is not created, you can still retrieve email, address, and other
        /// customer data entered in Checkout with <a
        /// href="https://docs.stripe.com/api/checkout/sessions/object#checkout_session_object-customer_details">customer_details</a>.
        ///
        /// Sessions that don't create Customers instead are grouped by <a
        /// href="https://docs.stripe.com/payments/checkout/guest-customers">guest customers</a> in
        /// the Dashboard. Promotion codes limited to first time customers will return invalid for
        /// these Sessions.
        ///
        /// Can only be set in <c>payment</c> and <c>setup</c> mode.
        /// One of: <c>always</c>, or <c>if_required</c>.
        /// </summary>
        [JsonProperty("customer_creation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_creation")]
#endif
        public string CustomerCreation { get; set; }

        /// <summary>
        /// If provided, this value will be used when the Customer object is created. If not
        /// provided, customers will be asked to enter their email address. Use this parameter to
        /// prefill customer data if you already have an email on file. To access information about
        /// the customer once a session is complete, use the <c>customer</c> field.
        /// </summary>
        [JsonProperty("customer_email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_email")]
#endif
        public string CustomerEmail { get; set; }

        /// <summary>
        /// Controls what fields on Customer can be updated by the Checkout Session. Can only be
        /// provided when <c>customer</c> is provided.
        /// </summary>
        [JsonProperty("customer_update")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_update")]
#endif
        public SessionCustomerUpdateOptions CustomerUpdate { get; set; }

        /// <summary>
        /// The coupon or promotion code to apply to this Session. Currently, only up to one may be
        /// specified.
        /// </summary>
        [JsonProperty("discounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discounts")]
#endif
        public List<SessionDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// A list of the types of payment methods (e.g., <c>card</c>) that should be excluded from
        /// this Checkout Session. This should only be used when payment methods for this Checkout
        /// Session are managed through the <a
        /// href="https://dashboard.stripe.com/settings/payment_methods">Stripe Dashboard</a>.
        /// One of: <c>acss_debit</c>, <c>affirm</c>, <c>afterpay_clearpay</c>, <c>alipay</c>,
        /// <c>alma</c>, <c>amazon_pay</c>, <c>au_becs_debit</c>, <c>bacs_debit</c>,
        /// <c>bancontact</c>, <c>billie</c>, <c>blik</c>, <c>boleto</c>, <c>card</c>,
        /// <c>cashapp</c>, <c>crypto</c>, <c>customer_balance</c>, <c>eps</c>, <c>fpx</c>,
        /// <c>giropay</c>, <c>gopay</c>, <c>grabpay</c>, <c>ideal</c>, <c>kakao_pay</c>,
        /// <c>klarna</c>, <c>konbini</c>, <c>kr_card</c>, <c>mb_way</c>, <c>mobilepay</c>,
        /// <c>multibanco</c>, <c>naver_pay</c>, <c>nz_bank_account</c>, <c>oxxo</c>, <c>p24</c>,
        /// <c>pay_by_bank</c>, <c>payco</c>, <c>paynow</c>, <c>paypal</c>, <c>paypay</c>,
        /// <c>payto</c>, <c>pix</c>, <c>promptpay</c>, <c>qris</c>, <c>rechnung</c>,
        /// <c>revolut_pay</c>, <c>samsung_pay</c>, <c>satispay</c>, <c>sepa_debit</c>,
        /// <c>shopeepay</c>, <c>sofort</c>, <c>swish</c>, <c>twint</c>, <c>us_bank_account</c>,
        /// <c>wechat_pay</c>, or <c>zip</c>.
        /// </summary>
        [JsonProperty("excluded_payment_method_types")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("excluded_payment_method_types")]
#endif
        public List<string> ExcludedPaymentMethodTypes { get; set; }

        /// <summary>
        /// The Epoch time in seconds at which the Checkout Session will expire. It can be anywhere
        /// from 30 minutes to 24 hours after Checkout Session creation. By default, this value is
        /// 24 hours from creation.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Generate a post-purchase Invoice for one-time payments.
        /// </summary>
        [JsonProperty("invoice_creation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_creation")]
#endif
        public SessionInvoiceCreationOptions InvoiceCreation { get; set; }

        /// <summary>
        /// A list of items the customer is purchasing. Use this parameter to pass one-time or
        /// recurring <a href="https://docs.stripe.com/api/prices">Prices</a>. The parameter is
        /// required for <c>payment</c> and <c>subscription</c> mode.
        ///
        /// For <c>payment</c> mode, there is a maximum of 100 line items, however it is recommended
        /// to consolidate line items if there are more than a few dozen.
        ///
        /// For <c>subscription</c> mode, there is a maximum of 20 line items with recurring Prices
        /// and 20 line items with one-time Prices. Line items with one-time Prices will be on the
        /// initial invoice only.
        /// </summary>
        [JsonProperty("line_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line_items")]
#endif
        public List<SessionLineItemOptions> LineItems { get; set; }

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
        /// Settings for Managed Payments for this Checkout Session and resulting <a
        /// href="https://stripe.com/api/payment_intents/object">PaymentIntents</a>, <a
        /// href="https://stripe.com/api/invoices/object">Invoices</a>, and <a
        /// href="https://stripe.com/api/subscriptions/object">Subscriptions</a>.
        /// </summary>
        [JsonProperty("managed_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("managed_payments")]
#endif
        public SessionManagedPaymentsOptions ManagedPayments { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The mode of the Checkout Session. Pass <c>subscription</c> if the Checkout Session
        /// includes at least one recurring item.
        /// One of: <c>payment</c>, <c>setup</c>, or <c>subscription</c>.
        /// </summary>
        [JsonProperty("mode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mode")]
#endif
        public string Mode { get; set; }

        /// <summary>
        /// Controls name collection settings for the session.
        ///
        /// You can configure Checkout to collect your customers' business names, individual names,
        /// or both. Each name field can be either required or optional.
        ///
        /// If a <a href="https://docs.stripe.com/api/customers">Customer</a> is created or
        /// provided, the names can be saved to the Customer object as well.
        ///
        /// You can't set this parameter if <c>ui_mode</c> is <c>custom</c>.
        /// </summary>
        [JsonProperty("name_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name_collection")]
#endif
        public SessionNameCollectionOptions NameCollection { get; set; }

        /// <summary>
        /// A list of optional items the customer can add to their order at checkout. Use this
        /// parameter to pass one-time or recurring <a
        /// href="https://docs.stripe.com/api/prices">Prices</a>.
        ///
        /// There is a maximum of 10 optional items allowed on a Checkout Session, and the existing
        /// limits on the number of line items allowed on a Checkout Session apply to the combined
        /// number of line items and optional items.
        ///
        /// For <c>payment</c> mode, there is a maximum of 100 combined line items and optional
        /// items, however it is recommended to consolidate items if there are more than a few
        /// dozen.
        ///
        /// For <c>subscription</c> mode, there is a maximum of 20 line items and optional items
        /// with recurring Prices and 20 line items and optional items with one-time Prices.
        ///
        /// You can't set this parameter if <c>ui_mode</c> is <c>custom</c>.
        /// </summary>
        [JsonProperty("optional_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("optional_items")]
#endif
        public List<SessionOptionalItemOptions> OptionalItems { get; set; }

        /// <summary>
        /// Where the user is coming from. This informs the optimizations that are applied to the
        /// session. You can't set this parameter if <c>ui_mode</c> is <c>custom</c>.
        /// One of: <c>mobile_app</c>, or <c>web</c>.
        /// </summary>
        [JsonProperty("origin_context")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("origin_context")]
#endif
        public string OriginContext { get; set; }

        /// <summary>
        /// A subset of parameters to be passed to PaymentIntent creation for Checkout Sessions in
        /// <c>payment</c> mode.
        /// </summary>
        [JsonProperty("payment_intent_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent_data")]
#endif
        public SessionPaymentIntentDataOptions PaymentIntentData { get; set; }

        /// <summary>
        /// Specify whether Checkout should collect a payment method. When set to
        /// <c>if_required</c>, Checkout will not collect a payment method when the total due for
        /// the session is 0. This may occur if the Checkout Session includes a free trial or a
        /// discount.
        ///
        /// Can only be set in <c>subscription</c> mode. Defaults to <c>always</c>.
        ///
        /// If you'd like information on how to collect a payment method outside of Checkout, read
        /// the guide on configuring <a
        /// href="https://docs.stripe.com/payments/checkout/free-trials">subscriptions with a free
        /// trial</a>.
        /// One of: <c>always</c>, or <c>if_required</c>.
        /// </summary>
        [JsonProperty("payment_method_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_collection")]
#endif
        public string PaymentMethodCollection { get; set; }

        /// <summary>
        /// The ID of the payment method configuration to use with this Checkout session.
        /// </summary>
        [JsonProperty("payment_method_configuration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_configuration")]
#endif
        public string PaymentMethodConfiguration { get; set; }

        /// <summary>
        /// This parameter allows you to set some attributes on the payment method created during a
        /// Checkout session.
        /// </summary>
        [JsonProperty("payment_method_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_data")]
#endif
        public SessionPaymentMethodDataOptions PaymentMethodData { get; set; }

        /// <summary>
        /// Payment-method-specific configuration.
        /// </summary>
        [JsonProperty("payment_method_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_options")]
#endif
        public SessionPaymentMethodOptionsOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// A list of the types of payment methods (e.g., <c>card</c>) this Checkout Session can
        /// accept.
        ///
        /// You can omit this attribute to manage your payment methods from the <a
        /// href="https://dashboard.stripe.com/settings/payment_methods">Stripe Dashboard</a>. See
        /// <a
        /// href="https://docs.stripe.com/payments/payment-methods/integration-options#using-dynamic-payment-methods">Dynamic
        /// Payment Methods</a> for more details.
        ///
        /// Read more about the supported payment methods and their requirements in our <a
        /// href="https://stripe.com/docs/payments/checkout/payment-methods">payment method details
        /// guide</a>.
        ///
        /// If multiple payment methods are passed, Checkout will dynamically reorder them to
        /// prioritize the most relevant payment methods based on the customer's location and other
        /// characteristics.
        /// One of: <c>acss_debit</c>, <c>affirm</c>, <c>afterpay_clearpay</c>, <c>alipay</c>,
        /// <c>alma</c>, <c>amazon_pay</c>, <c>au_becs_debit</c>, <c>bacs_debit</c>,
        /// <c>bancontact</c>, <c>billie</c>, <c>blik</c>, <c>boleto</c>, <c>card</c>,
        /// <c>cashapp</c>, <c>crypto</c>, <c>customer_balance</c>, <c>eps</c>, <c>fpx</c>,
        /// <c>giropay</c>, <c>gopay</c>, <c>grabpay</c>, <c>ideal</c>, <c>kakao_pay</c>,
        /// <c>klarna</c>, <c>konbini</c>, <c>kr_card</c>, <c>link</c>, <c>mb_way</c>,
        /// <c>mobilepay</c>, <c>multibanco</c>, <c>naver_pay</c>, <c>nz_bank_account</c>,
        /// <c>oxxo</c>, <c>p24</c>, <c>pay_by_bank</c>, <c>payco</c>, <c>paynow</c>, <c>paypal</c>,
        /// <c>paypay</c>, <c>payto</c>, <c>pix</c>, <c>promptpay</c>, <c>qris</c>, <c>rechnung</c>,
        /// <c>revolut_pay</c>, <c>samsung_pay</c>, <c>satispay</c>, <c>sepa_debit</c>,
        /// <c>shopeepay</c>, <c>sofort</c>, <c>swish</c>, <c>twint</c>, <c>us_bank_account</c>,
        /// <c>wechat_pay</c>, or <c>zip</c>.
        /// </summary>
        [JsonProperty("payment_method_types")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_types")]
#endif
        public List<string> PaymentMethodTypes { get; set; }

        /// <summary>
        /// This property is used to set up permissions for various actions (e.g., update) on the
        /// CheckoutSession object. Can only be set when creating <c>embedded</c> or <c>custom</c>
        /// sessions.
        ///
        /// For specific permissions, please refer to their dedicated subsections, such as
        /// <c>permissions.update_shipping_details</c>.
        /// </summary>
        [JsonProperty("permissions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("permissions")]
#endif
        public SessionPermissionsOptions Permissions { get; set; }

        /// <summary>
        /// Controls phone number collection settings for the session.
        ///
        /// We recommend that you review your privacy policy and check with your legal contacts
        /// before using this feature. Learn more about <a
        /// href="https://docs.stripe.com/payments/checkout/phone-numbers">collecting phone numbers
        /// with Checkout</a>.
        /// </summary>
        [JsonProperty("phone_number_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone_number_collection")]
#endif
        public SessionPhoneNumberCollectionOptions PhoneNumberCollection { get; set; }

        /// <summary>
        /// This parameter applies to <c>ui_mode: embedded</c>. Learn more about the <a
        /// href="https://docs.stripe.com/payments/checkout/custom-success-page?payment-ui=embedded-form">redirect
        /// behavior</a> of embedded sessions. Defaults to <c>always</c>.
        /// One of: <c>always</c>, <c>if_required</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("redirect_on_completion")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("redirect_on_completion")]
#endif
        public string RedirectOnCompletion { get; set; }

        /// <summary>
        /// The URL to redirect your customer back to after they authenticate or cancel their
        /// payment on the payment method's app or site. This parameter is required if
        /// <c>ui_mode</c> is <c>embedded</c> or <c>custom</c> and redirect-based payment methods
        /// are enabled on the session.
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
        public SessionSavedPaymentMethodOptionsOptions SavedPaymentMethodOptions { get; set; }

        /// <summary>
        /// A subset of parameters to be passed to SetupIntent creation for Checkout Sessions in
        /// <c>setup</c> mode.
        /// </summary>
        [JsonProperty("setup_intent_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("setup_intent_data")]
#endif
        public SessionSetupIntentDataOptions SetupIntentData { get; set; }

        /// <summary>
        /// When set, provides configuration for Checkout to collect a shipping address from a
        /// customer.
        /// </summary>
        [JsonProperty("shipping_address_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_address_collection")]
#endif
        public SessionShippingAddressCollectionOptions ShippingAddressCollection { get; set; }

        /// <summary>
        /// The shipping rate options to apply to this Session. Up to a maximum of 5.
        /// </summary>
        [JsonProperty("shipping_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_options")]
#endif
        public List<SessionShippingOptionOptions> ShippingOptions { get; set; }

        /// <summary>
        /// Describes the type of transaction being performed by Checkout in order to customize
        /// relevant text on the page, such as the submit button. <c>submit_type</c> can only be
        /// specified on Checkout Sessions in <c>payment</c> or <c>subscription</c> mode. If blank
        /// or <c>auto</c>, <c>pay</c> is used. You can't set this parameter if <c>ui_mode</c> is
        /// <c>custom</c>.
        /// One of: <c>auto</c>, <c>book</c>, <c>donate</c>, <c>pay</c>, or <c>subscribe</c>.
        /// </summary>
        [JsonProperty("submit_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("submit_type")]
#endif
        public string SubmitType { get; set; }

        /// <summary>
        /// A subset of parameters to be passed to subscription creation for Checkout Sessions in
        /// <c>subscription</c> mode.
        /// </summary>
        [JsonProperty("subscription_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_data")]
#endif
        public SessionSubscriptionDataOptions SubscriptionData { get; set; }

        /// <summary>
        /// The URL to which Stripe should send customers when payment or setup is complete. This
        /// parameter is not allowed if ui_mode is <c>embedded</c> or <c>custom</c>. If you'd like
        /// to use information from the successful Checkout Session on your page, read the guide on
        /// <a href="https://docs.stripe.com/payments/checkout/custom-success-page">customizing your
        /// success page</a>.
        /// </summary>
        [JsonProperty("success_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("success_url")]
#endif
        public string SuccessUrl { get; set; }

        /// <summary>
        /// Controls tax ID collection during checkout.
        /// </summary>
        [JsonProperty("tax_id_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_id_collection")]
#endif
        public SessionTaxIdCollectionOptions TaxIdCollection { get; set; }

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
        /// Wallet-specific configuration.
        /// </summary>
        [JsonProperty("wallet_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wallet_options")]
#endif
        public SessionWalletOptionsOptions WalletOptions { get; set; }
    }
}
