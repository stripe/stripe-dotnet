// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodOptionsKlarnaOptions : INestedOptions
    {
        /// <summary>
        /// Controls when the funds are captured from the customer's account.
        ///
        /// If provided, this parameter overrides the behavior of the top-level <a
        /// href="https://stripe.com/api/payment_intents/update#update_payment_intent-capture_method">capture_method</a>
        /// for this payment method type when finalizing the payment with this payment method type.
        ///
        /// If <c>capture_method</c> is already set on the PaymentIntent, providing an empty value
        /// for this parameter unsets the stored value for this payment method type.
        /// </summary>
        [JsonProperty("capture_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capture_method")]
#endif
        public string CaptureMethod { get; set; }

        /// <summary>
        /// On-demand details if setting up or charging an on-demand payment.
        /// </summary>
        [JsonProperty("on_demand")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("on_demand")]
#endif
        public PaymentIntentPaymentMethodOptionsKlarnaOnDemandOptions OnDemand { get; set; }

        /// <summary>
        /// Preferred language of the Klarna authorization page that the customer is redirected to.
        /// One of: <c>cs-CZ</c>, <c>da-DK</c>, <c>de-AT</c>, <c>de-CH</c>, <c>de-DE</c>,
        /// <c>el-GR</c>, <c>en-AT</c>, <c>en-AU</c>, <c>en-BE</c>, <c>en-CA</c>, <c>en-CH</c>,
        /// <c>en-CZ</c>, <c>en-DE</c>, <c>en-DK</c>, <c>en-ES</c>, <c>en-FI</c>, <c>en-FR</c>,
        /// <c>en-GB</c>, <c>en-GR</c>, <c>en-IE</c>, <c>en-IT</c>, <c>en-NL</c>, <c>en-NO</c>,
        /// <c>en-NZ</c>, <c>en-PL</c>, <c>en-PT</c>, <c>en-RO</c>, <c>en-SE</c>, <c>en-US</c>,
        /// <c>es-ES</c>, <c>es-US</c>, <c>fi-FI</c>, <c>fr-BE</c>, <c>fr-CA</c>, <c>fr-CH</c>,
        /// <c>fr-FR</c>, <c>it-CH</c>, <c>it-IT</c>, <c>nb-NO</c>, <c>nl-BE</c>, <c>nl-NL</c>,
        /// <c>pl-PL</c>, <c>pt-PT</c>, <c>ro-RO</c>, <c>sv-FI</c>, or <c>sv-SE</c>.
        /// </summary>
        [JsonProperty("preferred_locale")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("preferred_locale")]
#endif
        public string PreferredLocale { get; set; }

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
        /// One of: <c>none</c>, <c>off_session</c>, or <c>on_session</c>.
        /// </summary>
        [JsonProperty("setup_future_usage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("setup_future_usage")]
#endif
        public string SetupFutureUsage { get; set; }

        /// <summary>
        /// Subscription details if setting up or charging a subscription.
        /// </summary>
        [JsonProperty("subscriptions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscriptions")]
#endif
        public List<PaymentIntentPaymentMethodOptionsKlarnaSubscriptionOptions> Subscriptions { get; set; }

        /// <summary>
        /// Supplementary Purchase Data for the corresponding Klarna payment.
        /// </summary>
        [JsonProperty("supplementary_purchase_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("supplementary_purchase_data")]
#endif
        public PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataOptions SupplementaryPurchaseData { get; set; }
    }
}
