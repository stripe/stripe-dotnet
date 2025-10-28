// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Car rental details for this PaymentIntent.
        /// </summary>
        [JsonProperty("car_rental")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("car_rental")]
#endif
        public PaymentIntentPaymentDetailsCarRentalOptions CarRental { get; set; }

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

        /// <summary>
        /// Event details for this PaymentIntent.
        /// </summary>
        [JsonProperty("event_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("event_details")]
#endif
        public PaymentIntentPaymentDetailsEventDetailsOptions EventDetails { get; set; }

        /// <summary>
        /// Flight reservation details for this PaymentIntent.
        /// </summary>
        [JsonProperty("flight")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flight")]
#endif
        public PaymentIntentPaymentDetailsFlightOptions Flight { get; set; }

        /// <summary>
        /// Lodging reservation details for this PaymentIntent.
        /// </summary>
        [JsonProperty("lodging")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lodging")]
#endif
        public PaymentIntentPaymentDetailsLodgingOptions Lodging { get; set; }

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

        /// <summary>
        /// Subscription details for this PaymentIntent.
        /// </summary>
        [JsonProperty("subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription")]
#endif
        public PaymentIntentPaymentDetailsSubscriptionOptions Subscription { get; set; }
    }
}
