// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentDetailsCarRentalDriverOptions : INestedOptions
    {
        /// <summary>
        /// Full name of the person or entity on the car reservation.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
