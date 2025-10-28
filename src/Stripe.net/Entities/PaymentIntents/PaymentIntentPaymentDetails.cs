// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetails : StripeEntity<PaymentIntentPaymentDetails>
    {
        [JsonProperty("car_rental")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("car_rental")]
#endif
        public PaymentIntentPaymentDetailsCarRental CarRental { get; set; }

        /// <summary>
        /// A unique value to identify the customer. This field is available only for card payments.
        ///
        /// This field is truncated to 25 alphanumeric characters, excluding spaces, before being
        /// sent to card networks.
        /// </summary>
        [JsonProperty("customer_reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_reference")]
#endif
        public string CustomerReference { get; set; }

        [JsonProperty("event_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("event_details")]
#endif
        public PaymentIntentPaymentDetailsEventDetails EventDetails { get; set; }

        /// <summary>
        /// A unique value assigned by the business to identify the transaction. Required for L2 and
        /// L3 rates.
        ///
        /// Required when the Payment Method Types array contains <c>card</c>, including when <a
        /// href="https://stripe.com/api/payment_intents/create#create_payment_intent-automatic_payment_methods-enabled">automatic_payment_methods.enabled</a>
        /// is set to <c>true</c>.
        ///
        /// For Cards, this field is truncated to 25 alphanumeric characters, excluding spaces,
        /// before being sent to card networks. For Klarna, this field is truncated to 255
        /// characters and is visible to customers when they view the order in the Klarna app.
        /// </summary>
        [JsonProperty("order_reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("order_reference")]
#endif
        public string OrderReference { get; set; }

        [JsonProperty("subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription")]
#endif
        public PaymentIntentPaymentDetailsSubscription Subscription { get; set; }
    }
}
