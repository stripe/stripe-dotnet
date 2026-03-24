// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsCarRentalDatumDriver : StripeEntity<PaymentIntentPaymentDetailsCarRentalDatumDriver>
    {
        [JsonProperty("date_of_birth")]
        [STJS.JsonPropertyName("date_of_birth")]
        public PaymentIntentPaymentDetailsCarRentalDatumDriverDateOfBirth DateOfBirth { get; set; }

        /// <summary>
        /// Driver's identification number.
        /// </summary>
        [JsonProperty("driver_identification_number")]
        [STJS.JsonPropertyName("driver_identification_number")]
        public string DriverIdentificationNumber { get; set; }

        /// <summary>
        /// Driver's tax number.
        /// </summary>
        [JsonProperty("driver_tax_number")]
        [STJS.JsonPropertyName("driver_tax_number")]
        public string DriverTaxNumber { get; set; }

        /// <summary>
        /// Full name of the driver.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
