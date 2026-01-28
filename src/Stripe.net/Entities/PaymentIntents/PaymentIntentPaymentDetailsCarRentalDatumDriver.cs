// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsCarRentalDatumDriver : StripeEntity<PaymentIntentPaymentDetailsCarRentalDatumDriver>
    {
        [JsonProperty("date_of_birth")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("date_of_birth")]
#endif
        public PaymentIntentPaymentDetailsCarRentalDatumDriverDateOfBirth DateOfBirth { get; set; }

        /// <summary>
        /// Driver's identification number.
        /// </summary>
        [JsonProperty("driver_identification_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("driver_identification_number")]
#endif
        public string DriverIdentificationNumber { get; set; }

        /// <summary>
        /// Driver's tax number.
        /// </summary>
        [JsonProperty("driver_tax_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("driver_tax_number")]
#endif
        public string DriverTaxNumber { get; set; }

        /// <summary>
        /// Full name of the driver.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }
    }
}
