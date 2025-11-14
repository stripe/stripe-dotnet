// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentDetailsCarRentalDatumOptions : INestedOptions
    {
        /// <summary>
        /// Affiliate (such as travel agency) details for the rental.
        /// </summary>
        [JsonProperty("affiliate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affiliate")]
#endif
        public ChargePaymentDetailsCarRentalDatumAffiliateOptions Affiliate { get; set; }

        /// <summary>
        /// Booking confirmation number for the car rental.
        /// </summary>
        [JsonProperty("booking_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("booking_number")]
#endif
        public string BookingNumber { get; set; }

        /// <summary>
        /// Name of the car rental company.
        /// </summary>
        [JsonProperty("carrier_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("carrier_name")]
#endif
        public string CarrierName { get; set; }

        /// <summary>
        /// Customer service phone number for the car rental company.
        /// </summary>
        [JsonProperty("customer_service_phone_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_service_phone_number")]
#endif
        public string CustomerServicePhoneNumber { get; set; }

        /// <summary>
        /// Number of days the car is being rented.
        /// </summary>
        [JsonProperty("days_rented")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("days_rented")]
#endif
        public long? DaysRented { get; set; }

        /// <summary>
        /// Distance details for the rental.
        /// </summary>
        [JsonProperty("distance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("distance")]
#endif
        public ChargePaymentDetailsCarRentalDatumDistanceOptions Distance { get; set; }

        /// <summary>
        /// List of drivers for the rental.
        /// </summary>
        [JsonProperty("drivers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("drivers")]
#endif
        public List<ChargePaymentDetailsCarRentalDatumDriverOptions> Drivers { get; set; }

        /// <summary>
        /// Drop-off location details.
        /// </summary>
        [JsonProperty("drop_off")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("drop_off")]
#endif
        public ChargePaymentDetailsCarRentalDatumDropOffOptions DropOff { get; set; }

        /// <summary>
        /// Insurance details for the rental.
        /// </summary>
        [JsonProperty("insurances")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("insurances")]
#endif
        public List<ChargePaymentDetailsCarRentalDatumInsuranceOptions> Insurances { get; set; }

        /// <summary>
        /// Indicates if the customer was a no-show.
        /// </summary>
        [JsonProperty("no_show_indicator")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("no_show_indicator")]
#endif
        public bool? NoShowIndicator { get; set; }

        /// <summary>
        /// Pickup location details.
        /// </summary>
        [JsonProperty("pickup")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pickup")]
#endif
        public ChargePaymentDetailsCarRentalDatumPickupOptions Pickup { get; set; }

        /// <summary>
        /// Name of the person renting the vehicle.
        /// </summary>
        [JsonProperty("renter_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("renter_name")]
#endif
        public string RenterName { get; set; }

        /// <summary>
        /// Total cost breakdown for the rental.
        /// </summary>
        [JsonProperty("total")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("total")]
#endif
        public ChargePaymentDetailsCarRentalDatumTotalOptions Total { get; set; }

        /// <summary>
        /// Vehicle details for the rental.
        /// </summary>
        [JsonProperty("vehicle")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("vehicle")]
#endif
        public ChargePaymentDetailsCarRentalDatumVehicleOptions Vehicle { get; set; }
    }
}
