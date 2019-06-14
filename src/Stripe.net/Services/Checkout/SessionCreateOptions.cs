namespace Stripe.Checkout
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SessionCreateOptions : BaseOptions
    {
        /// <summary>
        /// Specify whether Checkout should collect the customer’s billing address. If set to
        /// <c>required</c>, Checkout will always collect the customer’s billing address. If left
        /// blank or set to <c>auto</c> Checkout will only collect the billing address when
        /// necessary.
        /// </summary>
        [JsonProperty("billing_address_collection")]
        public string BillingAddressCollection { get; set; }

        /// <summary>
        /// The URL the customer will be directed to if they decide to go back to your website.
        /// </summary>
        [JsonProperty("cancel_url")]
        public string CancelUrl { get; set; }

        /// <summary>
        /// A unique string to reference the Checkout Session. This can be a customer ID, a cart
        /// ID, or similar. It is included in the <c>checkout.session.completed</c> webhook and can
        /// be used to fulfill the purchase.
        /// </summary>
        [JsonProperty("client_reference_id")]
        public string ClientReferenceId { get; set; }

        /// <summary>
        /// The email address used to create the customer object. If you already know your
        /// customer’s email address, use this attribute to prefill it on Checkout.
        /// </summary>
        [JsonProperty("customer_email")]
        public string CustomerEmail { get; set; }

        /// <summary>
        /// ID of the customer this Checkout Session is for if one exists. May only be used with
        /// <c>LineItems</c>. Usage with <c>SubscriptionData</c> is not yet available.
        /// </summary>
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        /// <summary>
        /// A list of items your customer is purchasing.
        /// </summary>
        [JsonProperty("line_items")]
        public List<SessionLineItemOptions> LineItems { get; set; }

        /// <summary>
        /// The IETF language tag of the locale Checkout is displayed in. If blank or <c>auto</c>,
        /// the browser’s locale is used.
        /// </summary>
        [JsonProperty("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// The list of payment method types (e.g. card) that this Checkout Session is allowed to
        /// use.
        /// </summary>
        [JsonProperty("payment_intent_data")]
        public SessionPaymentIntentDataOptions PaymentIntentData { get; set; }

        /// <summary>
        /// The list of payment method types (e.g. card) that this Checkout Session is allowed to
        /// use.
        /// </summary>
        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        /// <summary>
        /// Describes the type of transaction being performed by Checkout in
        /// order to customize relevant text on the page, such as the Submit
        /// button. <c>submit_type</c> can only be specified on checkout
        /// sessions using line items or a SKU, and not checkout sessions for
        /// subscriptions.  Supported values are <c>auto</c>, <c>book</c>,
        /// <c>donate</c>, or <c>pay</c>.
        /// </summary>
        [JsonProperty("submit_type")]
        public string SubmitType { get; set; }

        /// <summary>
        /// A subset of parameters to be passed to subscription creation.
        /// </summary>
        [JsonProperty("subscription_data")]
        public SessionSubscriptionDataOptions SubscriptionData { get; set; }

        /// <summary>
        /// The URL the customer will be directed to after a successful payment.
        /// </summary>
        [JsonProperty("success_url")]
        public string SuccessUrl { get; set; }
    }
}
