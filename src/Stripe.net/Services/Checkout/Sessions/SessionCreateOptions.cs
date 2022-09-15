// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SessionCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Configure actions after a Checkout Session has expired.
        /// </summary>
        [JsonProperty("after_expiration")]
        public SessionAfterExpirationOptions AfterExpiration { get; set; }

        /// <summary>
        /// Enables user redeemable promotion codes.
        /// </summary>
        [JsonProperty("allow_promotion_codes")]
        public bool? AllowPromotionCodes { get; set; }

        /// <summary>
        /// Settings for automatic tax lookup for this session and resulting payments, invoices, and
        /// subscriptions.
        /// </summary>
        [JsonProperty("automatic_tax")]
        public SessionAutomaticTaxOptions AutomaticTax { get; set; }

        /// <summary>
        /// Specify whether Checkout should collect the customer's billing address.
        /// One of: <c>auto</c>, or <c>required</c>.
        /// </summary>
        [JsonProperty("billing_address_collection")]
        public string BillingAddressCollection { get; set; }

        /// <summary>
        /// The URL the customer will be directed to if they decide to cancel payment and return to
        /// your website.
        /// </summary>
        [JsonProperty("cancel_url")]
        public string CancelUrl { get; set; }

        /// <summary>
        /// A unique string to reference the Checkout Session. This can be a customer ID, a cart ID,
        /// or similar, and can be used to reconcile the session with your internal systems.
        /// </summary>
        [JsonProperty("client_reference_id")]
        public string ClientReferenceId { get; set; }

        /// <summary>
        /// Configure fields for the Checkout Session to gather active consent from customers.
        /// </summary>
        [JsonProperty("consent_collection")]
        public SessionConsentCollectionOptions ConsentCollection { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// ID of an existing Customer, if one exists. In <c>payment</c> mode, the customer’s most
        /// recent card payment method will be used to prefill the email, name, card details, and
        /// billing address on the Checkout page. In <c>subscription</c> mode, the customer’s <a
        /// href="https://stripe.com/docs/api/customers/update#update_customer-invoice_settings-default_payment_method">default
        /// payment method</a> will be used if it’s a card, and otherwise the most recent card will
        /// be used. A valid billing address, billing name and billing email are required on the
        /// payment method for Checkout to prefill the customer's card details.
        ///
        /// If the Customer already has a valid <a
        /// href="https://stripe.com/docs/api/customers/object#customer_object-email">email</a> set,
        /// the email will be prefilled and not editable in Checkout. If the Customer does not have
        /// a valid <c>email</c>, Checkout will set the email entered during the session on the
        /// Customer.
        ///
        /// If blank for Checkout Sessions in <c>payment</c> or <c>subscription</c> mode, Checkout
        /// will create a new Customer object based on information provided during the payment flow.
        ///
        /// You can set <a
        /// href="https://stripe.com/docs/api/checkout/sessions/create#create_checkout_session-payment_intent_data-setup_future_usage"><c>payment_intent_data.setup_future_usage</c></a>
        /// to have Checkout automatically attach the payment method to the Customer you pass in for
        /// future reuse.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Configure whether a Checkout Session creates a <a
        /// href="https://stripe.com/docs/api/customers">Customer</a> during Session confirmation.
        ///
        /// When a Customer is not created, you can still retrieve email, address, and other
        /// customer data entered in Checkout with <a
        /// href="https://stripe.com/docs/api/checkout/sessions/object#checkout_session_object-customer_details">customer_details</a>.
        ///
        /// Sessions that don't create Customers instead create <a
        /// href="https://support.stripe.com/questions/guest-customer-faq">Guest Customers</a> in
        /// the Dashboard. Promotion codes limited to first time customers will return invalid for
        /// these Sessions.
        ///
        /// Can only be set in <c>payment</c> and <c>setup</c> mode.
        /// One of: <c>always</c>, or <c>if_required</c>.
        /// </summary>
        [JsonProperty("customer_creation")]
        public string CustomerCreation { get; set; }

        /// <summary>
        /// If provided, this value will be used when the Customer object is created. If not
        /// provided, customers will be asked to enter their email address. Use this parameter to
        /// prefill customer data if you already have an email on file. To access information about
        /// the customer once a session is complete, use the <c>customer</c> field.
        /// </summary>
        [JsonProperty("customer_email")]
        public string CustomerEmail { get; set; }

        /// <summary>
        /// Controls what fields on Customer can be updated by the Checkout Session. Can only be
        /// provided when <c>customer</c> is provided.
        /// </summary>
        [JsonProperty("customer_update")]
        public SessionCustomerUpdateOptions CustomerUpdate { get; set; }

        /// <summary>
        /// The coupon or promotion code to apply to this Session. Currently, only up to one may be
        /// specified.
        /// </summary>
        [JsonProperty("discounts")]
        public List<SessionDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// The Epoch time in seconds at which the Checkout Session will expire. It can be anywhere
        /// from 30 minutes to 24 hours after Checkout Session creation. By default, this value is
        /// 24 hours from creation.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// A list of items the customer is purchasing. Use this parameter to pass one-time or
        /// recurring <a href="https://stripe.com/docs/api/prices">Prices</a>.
        ///
        /// For <c>payment</c> mode, there is a maximum of 100 line items, however it is recommended
        /// to consolidate line items if there are more than a few dozen.
        ///
        /// For <c>subscription</c> mode, there is a maximum of 20 line items with recurring Prices
        /// and 20 line items with one-time Prices. Line items with one-time Prices will be on the
        /// initial invoice only.
        /// </summary>
        [JsonProperty("line_items")]
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
        public string Locale { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The mode of the Checkout Session. Required when using prices or <c>setup</c> mode. Pass
        /// <c>subscription</c> if the Checkout Session includes at least one recurring item.
        /// One of: <c>payment</c>, <c>setup</c>, or <c>subscription</c>.
        /// </summary>
        [JsonProperty("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// A subset of parameters to be passed to PaymentIntent creation for Checkout Sessions in
        /// <c>payment</c> mode.
        /// </summary>
        [JsonProperty("payment_intent_data")]
        public SessionPaymentIntentDataOptions PaymentIntentData { get; set; }

        /// <summary>
        /// Specify whether Checkout should collect a payment method. When set to
        /// <c>if_required</c>, Checkout will not collect a payment method when the total due for
        /// the session is 0. This may occur if the Checkout Session includes a free trial or a
        /// discount.
        ///
        /// Can only be set in <c>subscription</c> mode.
        ///
        /// If you'd like information on how to collect a payment method outside of Checkout, read
        /// the guide on configuring <a
        /// href="https://stripe.com/docs/payments/checkout/free-trials">subscriptions with a free
        /// trial</a>.
        /// One of: <c>always</c>, or <c>if_required</c>.
        /// </summary>
        [JsonProperty("payment_method_collection")]
        public string PaymentMethodCollection { get; set; }

        /// <summary>
        /// Payment-method-specific configuration.
        /// </summary>
        [JsonProperty("payment_method_options")]
        public SessionPaymentMethodOptionsOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// A list of the types of payment methods (e.g., <c>card</c>) this Checkout Session can
        /// accept.
        ///
        /// In <c>payment</c> and <c>subscription</c> mode, you can omit this attribute to manage
        /// your payment methods from the <a
        /// href="https://dashboard.stripe.com/settings/payment_methods">Stripe Dashboard</a>. It is
        /// required in <c>setup</c> mode.
        ///
        /// Read more about the supported payment methods and their requirements in our <a
        /// href="https://stripe.com/docs/payments/checkout/payment-methods">payment method details
        /// guide</a>.
        ///
        /// If multiple payment methods are passed, Checkout will dynamically reorder them to
        /// prioritize the most relevant payment methods based on the customer's location and other
        /// characteristics.
        /// </summary>
        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        /// <summary>
        /// Controls phone number collection settings for the session.
        ///
        /// We recommend that you review your privacy policy and check with your legal contacts
        /// before using this feature. Learn more about <a
        /// href="https://stripe.com/docs/payments/checkout/phone-numbers">collecting phone numbers
        /// with Checkout</a>.
        /// </summary>
        [JsonProperty("phone_number_collection")]
        public SessionPhoneNumberCollectionOptions PhoneNumberCollection { get; set; }

        /// <summary>
        /// A subset of parameters to be passed to SetupIntent creation for Checkout Sessions in
        /// <c>setup</c> mode.
        /// </summary>
        [JsonProperty("setup_intent_data")]
        public SessionSetupIntentDataOptions SetupIntentData { get; set; }

        /// <summary>
        /// When set, provides configuration for Checkout to collect a shipping address from a
        /// customer.
        /// </summary>
        [JsonProperty("shipping_address_collection")]
        public SessionShippingAddressCollectionOptions ShippingAddressCollection { get; set; }

        /// <summary>
        /// The shipping rate options to apply to this Session.
        /// </summary>
        [JsonProperty("shipping_options")]
        public List<SessionShippingOptionOptions> ShippingOptions { get; set; }

        /// <summary>
        /// [Deprecated] The shipping rate to apply to this Session. Only up to one may be
        /// specified.
        /// </summary>
        [JsonProperty("shipping_rates")]
        public List<string> ShippingRates { get; set; }

        /// <summary>
        /// Describes the type of transaction being performed by Checkout in order to customize
        /// relevant text on the page, such as the submit button. <c>submit_type</c> can only be
        /// specified on Checkout Sessions in <c>payment</c> mode, but not Checkout Sessions in
        /// <c>subscription</c> or <c>setup</c> mode.
        /// One of: <c>auto</c>, <c>book</c>, <c>donate</c>, or <c>pay</c>.
        /// </summary>
        [JsonProperty("submit_type")]
        public string SubmitType { get; set; }

        /// <summary>
        /// A subset of parameters to be passed to subscription creation for Checkout Sessions in
        /// <c>subscription</c> mode.
        /// </summary>
        [JsonProperty("subscription_data")]
        public SessionSubscriptionDataOptions SubscriptionData { get; set; }

        /// <summary>
        /// The URL to which Stripe should send customers when payment or setup is complete. If
        /// you’d like to use information from the successful Checkout Session on your page, read
        /// the guide on <a
        /// href="https://stripe.com/docs/payments/checkout/custom-success-page">customizing your
        /// success page</a>.
        /// </summary>
        [JsonProperty("success_url")]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// Controls tax ID collection settings for the session.
        /// </summary>
        [JsonProperty("tax_id_collection")]
        public SessionTaxIdCollectionOptions TaxIdCollection { get; set; }
    }
}
