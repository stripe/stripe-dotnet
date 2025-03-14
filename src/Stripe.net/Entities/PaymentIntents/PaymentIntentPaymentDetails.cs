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

        [JsonProperty("event_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("event_details")]
#endif
        public PaymentIntentPaymentDetailsEventDetails EventDetails { get; set; }

        [JsonProperty("subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription")]
#endif
        public PaymentIntentPaymentDetailsSubscription Subscription { get; set; }
    }
}
