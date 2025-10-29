// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetails : StripeEntity<PaymentIntentPaymentDetails>
    {
        [JsonProperty("benefit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("benefit")]
#endif
        public PaymentIntentPaymentDetailsBenefit Benefit { get; set; }

        [JsonProperty("car_rental")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("car_rental")]
#endif
        public PaymentIntentPaymentDetailsCarRental CarRental { get; set; }

        /// <summary>
        /// Some customers might be required by their company or organization to provide this
        /// information. If so, provide this value. Otherwise you can ignore this field.
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
        /// A unique value assigned by the business to identify the transaction.
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
