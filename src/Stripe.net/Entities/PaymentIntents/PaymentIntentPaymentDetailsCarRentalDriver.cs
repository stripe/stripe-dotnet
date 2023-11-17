// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentDetailsCarRentalDriver : StripeEntity<PaymentIntentPaymentDetailsCarRentalDriver>
    {
        /// <summary>
        /// Full name of the driver on the reservation.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
