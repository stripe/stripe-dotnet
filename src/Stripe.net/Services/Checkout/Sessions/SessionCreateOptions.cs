namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Enables user redeemable promotion codes.
        /// </summary>
        [JsonProperty("allow_promotion_codes")]
        public bool? AllowPromotionCodes { get; set; }

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
        /// ID of an existing customer, if one exists. The email stored on the customer will be used
        /// to prefill the email field on the Checkout page. If the customer changes their email on
        /// the Checkout page, the Customer object will be updated with the new email. If blank for
        /// Checkout Sessions in <c>payment</c> or <c>subscription</c> mode, Checkout will create a
        /// new customer object based on information provided during the session.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// If provided, this value will be used when the Customer object is created. If not
        /// provided, customers will be asked to enter their email address. Use this parameter to
        /// prefill customer data if you already have an email on file. To access information about
        /// the customer once a session is complete, use the <c>customer</c> field.
        /// </summary>
        [JsonProperty("customer_email")]
        public string CustomerEmail { get; set; }

        /// <summary>
        /// A list of items the customer is purchasing. Use this parameter to pass one-time or
        /// recurring <a href="https://stripe.com/docs/api/prices">Prices</a>. One-time Prices in
        /// <c>subscription</c> mode will be on the initial invoice only.
        ///
        /// There is a maximum of 100 line items, however it is recommended to consolidate line
        /// items if there are more than a few dozen.
        /// </summary>
        [JsonProperty("line_items")]
        public List<SessionLineItemOptions> LineItems { get; set; }

        /// <summary>
        /// The IETF language tag of the locale Checkout is displayed in. If blank or <c>auto</c>,
        /// the browser's locale is used.
        /// One of: <c>auto</c>, <c>bg</c>, <c>cs</c>, <c>da</c>, <c>de</c>, <c>el</c>, <c>en</c>,
        /// <c>en-GB</c>, <c>es</c>, <c>es-419</c>, <c>et</c>, <c>fi</c>, <c>fr</c>, <c>fr-CA</c>,
        /// <c>hu</c>, <c>id</c>, <c>it</c>, <c>ja</c>, <c>lt</c>, <c>lv</c>, <c>ms</c>, <c>mt</c>,
        /// <c>nb</c>, <c>nl</c>, <c>pl</c>, <c>pt</c>, <c>pt-BR</c>, <c>ro</c>, <c>ru</c>,
        /// <c>sk</c>, <c>sl</c>, <c>sv</c>, <c>tr</c>, <c>zh</c>, <c>zh-HK</c>, or <c>zh-TW</c>.
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
        /// The mode of the Checkout Session, one of <c>payment</c>, <c>setup</c>, or
        /// <c>subscription</c>. Required when using prices or <c>setup</c> mode. Pass
        /// <c>subscription</c> if Checkout session includes at least one recurring item.
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
        /// A list of the types of payment methods (e.g., <c>card</c>) this Checkout session can
        /// accept.
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
        /// you’d like access to the Checkout Session for the successful payment, read more about it
        /// in our guide on <a
        /// href="https://stripe.com/docs/payments/checkout/accept-a-payment#payment-success">fulfilling
        /// your payments with webhooks</a>.
        /// </summary>
        [JsonProperty("success_url")]
        public string SuccessUrl { get; set; }
    }
}
