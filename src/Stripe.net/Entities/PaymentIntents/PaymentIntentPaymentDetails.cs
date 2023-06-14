// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentDetails : StripeEntity<PaymentIntentPaymentDetails>
    {
        [JsonProperty("car_rental")]
        public PaymentIntentPaymentDetailsCarRental CarRental { get; set; }
    }
}
