namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentIntentConfirmOptions : BaseOptions
    {
        /// <summary>
        /// The client secret of the PaymentIntent. Required if a publishable key is used to
        /// confirm the payment intent.
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Set to <c>true</c> to indicate that the customer is not in your checkout flow during
        /// this payment attempt, and therefore is unable to authenticate. This parameter is
        /// intended for scenarios where you collect card details and <a href="https://stripe.com/docs/payments/cards/reusing-cards">
        /// charge them later</a>.
        /// </summary>
        [JsonProperty("off_session")]
        public AnyOf<bool?, string> OffSession { get; set; }

        /// <summary>
        /// ID of the payment method (a PaymentMethod, Card, BankAccount, or saved Source object) to
        /// attach to this PaymentIntent.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethodId { get; set; }

        /// <summary>
        /// The list of payment method types (e.g. card) that this PaymentIntent is allowed to use.
        /// </summary>
        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        /// <summary>
        /// Email address that the receipt for the resulting payment will be sent to.
        /// </summary>
        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        /// <summary>
        /// The URL to redirect your customer back to after they authenticate or cancel their
        /// payment on the payment method’s app or site. If you’d prefer to redirect to a mobile
        /// application, you can alternatively supply an application URI scheme. This parameter is
        /// only used for cards and other redirect-based payment methods.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// If the PaymentIntent has a payment_method and a customer or if you’re attaching a
        /// payment method to the PaymentIntent in this request, you can pass this as <c>true</c>
        /// to save the payment method to the customer. Defaults to <c>false</c>.
        /// If the payment method is already saved to a customer, this does nothing. If this type
        /// of payment method cannot be saved to a customer, the request will error.
        /// </summary>
        [JsonProperty("save_payment_method")]
        public bool? SavePaymentMethod { get; set; }

        /// <summary>
        /// Shipping information for this PaymentIntent.
        /// </summary>
        [JsonProperty("shipping")]
        public ChargeShippingOptions Shipping { get; set; }

        /// <summary>
        /// ID of the Source to use with this PaymentIntent. Prefer using <see cref="PaymentMethodId"/>.
        /// </summary>
        [JsonProperty("source")]
        public string SourceId { get; set; }
    }
}
