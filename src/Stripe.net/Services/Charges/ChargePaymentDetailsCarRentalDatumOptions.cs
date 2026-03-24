// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ChargePaymentDetailsCarRentalDatumOptions : INestedOptions
    {
        /// <summary>
        /// Affiliate (such as travel agency) details for the rental.
        /// </summary>
        [JsonProperty("affiliate")]
        [STJS.JsonPropertyName("affiliate")]
        public ChargePaymentDetailsCarRentalDatumAffiliateOptions Affiliate { get; set; }

        /// <summary>
        /// Booking confirmation number for the car rental.
        /// </summary>
        [JsonProperty("booking_number")]
        [STJS.JsonPropertyName("booking_number")]
        public string BookingNumber { get; set; }

        /// <summary>
        /// Name of the car rental company.
        /// </summary>
        [JsonProperty("carrier_name")]
        [STJS.JsonPropertyName("carrier_name")]
        public string CarrierName { get; set; }

        /// <summary>
        /// Customer service phone number for the car rental company.
        /// </summary>
        [JsonProperty("customer_service_phone_number")]
        [STJS.JsonPropertyName("customer_service_phone_number")]
        public string CustomerServicePhoneNumber { get; set; }

        /// <summary>
        /// Number of days the car is being rented.
        /// </summary>
        [JsonProperty("days_rented")]
        [STJS.JsonPropertyName("days_rented")]
        public long? DaysRented { get; set; }

        /// <summary>
        /// Distance details for the rental.
        /// </summary>
        [JsonProperty("distance")]
        [STJS.JsonPropertyName("distance")]
        public ChargePaymentDetailsCarRentalDatumDistanceOptions Distance { get; set; }

        /// <summary>
        /// List of drivers for the rental.
        /// </summary>
        [JsonProperty("drivers")]
        [STJS.JsonPropertyName("drivers")]
        public List<ChargePaymentDetailsCarRentalDatumDriverOptions> Drivers { get; set; }

        /// <summary>
        /// Drop-off location details.
        /// </summary>
        [JsonProperty("drop_off")]
        [STJS.JsonPropertyName("drop_off")]
        public ChargePaymentDetailsCarRentalDatumDropOffOptions DropOff { get; set; }

        /// <summary>
        /// Insurance details for the rental.
        /// </summary>
        [JsonProperty("insurances")]
        [STJS.JsonPropertyName("insurances")]
        public List<ChargePaymentDetailsCarRentalDatumInsuranceOptions> Insurances { get; set; }

        /// <summary>
        /// Indicates if the customer was a no-show.
        /// </summary>
        [JsonProperty("no_show_indicator")]
        [STJS.JsonPropertyName("no_show_indicator")]
        public bool? NoShowIndicator { get; set; }

        /// <summary>
        /// Pickup location details.
        /// </summary>
        [JsonProperty("pickup")]
        [STJS.JsonPropertyName("pickup")]
        public ChargePaymentDetailsCarRentalDatumPickupOptions Pickup { get; set; }

        /// <summary>
        /// Name of the person renting the vehicle.
        /// </summary>
        [JsonProperty("renter_name")]
        [STJS.JsonPropertyName("renter_name")]
        public string RenterName { get; set; }

        /// <summary>
        /// Total cost breakdown for the rental.
        /// </summary>
        [JsonProperty("total")]
        [STJS.JsonPropertyName("total")]
        public ChargePaymentDetailsCarRentalDatumTotalOptions Total { get; set; }

        /// <summary>
        /// Vehicle details for the rental.
        /// </summary>
        [JsonProperty("vehicle")]
        [STJS.JsonPropertyName("vehicle")]
        public ChargePaymentDetailsCarRentalDatumVehicleOptions Vehicle { get; set; }
    }
}
