// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentDetailsFlightPassengerOptions : INestedOptions
    {
        /// <summary>
        /// Full name of the person or entity on the flight reservation.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
