// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentDetails : StripeEntity<PaymentIntentPaymentDetails>
    {
        [JsonProperty("car_rental")]
        public PaymentIntentPaymentDetailsCarRental CarRental { get; set; }

        [JsonProperty("event_details")]
        public PaymentIntentPaymentDetailsEventDetails EventDetails { get; set; }

        [JsonProperty("subscription")]
        public PaymentIntentPaymentDetailsSubscription Subscription { get; set; }
    }
}
