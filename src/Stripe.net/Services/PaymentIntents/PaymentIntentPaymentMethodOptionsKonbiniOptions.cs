// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentPaymentMethodOptionsKonbiniOptions : INestedOptions
    {
        /// <summary>
        /// An optional 10 to 11 digit numeric-only string determining the confirmation code at
        /// applicable convenience stores. Must not consist of only zeroes and could be rejected in
        /// case of insufficient uniqueness. We recommend to use the customer's phone number.
        /// </summary>
        [JsonProperty("confirmation_number")]
        public string ConfirmationNumber { get; set; }

        /// <summary>
        /// The number of calendar days (between 1 and 60) after which Konbini payment instructions
        /// will expire. For example, if a PaymentIntent is confirmed with Konbini and
        /// <c>expires_after_days</c> set to 2 on Monday JST, the instructions will expire on
        /// Wednesday 23:59:59 JST. Defaults to 3 days.
        /// </summary>
        [JsonProperty("expires_after_days")]
        public long? ExpiresAfterDays { get; set; }

        /// <summary>
        /// The timestamp at which the Konbini payment instructions will expire. Only one of
        /// <c>expires_after_days</c> or <c>expires_at</c> may be set.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// A product descriptor of up to 22 characters, which will appear to customers at the
        /// convenience store.
        /// </summary>
        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        /// <summary>
        /// Indicates that you intend to make future payments with this PaymentIntent's payment
        /// method.
        ///
        /// If you provide a Customer with the PaymentIntent, you can use this parameter to <a
        /// href="https://stripe.com/payments/save-during-payment">attach the payment method</a> to
        /// the Customer after the PaymentIntent is confirmed and the customer completes any
        /// required actions. If you don't provide a Customer, you can still <a
        /// href="https://stripe.com/api/payment_methods/attach">attach</a> the payment method to a
        /// Customer after the transaction completes.
        ///
        /// If the payment method is <c>card_present</c> and isn't a digital wallet, Stripe creates
        /// and attaches a <a
        /// href="https://stripe.com/api/charges/object#charge_object-payment_method_details-card_present-generated_card">generated_card</a>
        /// payment method representing the card to the Customer instead.
        ///
        /// When processing card payments, Stripe uses <c>setup_future_usage</c> to help you comply
        /// with regional legislation and network rules, such as <a
        /// href="https://stripe.com/strong-customer-authentication">SCA</a>.
        ///
        /// If you've already set <c>setup_future_usage</c> and you're performing a request using a
        /// publishable key, you can only update the value from <c>on_session</c> to
        /// <c>off_session</c>.
        /// </summary>
        [JsonProperty("setup_future_usage")]
        public string SetupFutureUsage { get; set; }
    }
}
