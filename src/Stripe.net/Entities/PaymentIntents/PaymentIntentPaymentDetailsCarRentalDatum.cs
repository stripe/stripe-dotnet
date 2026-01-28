// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsCarRentalDatum : StripeEntity<PaymentIntentPaymentDetailsCarRentalDatum>
    {
        [JsonProperty("affiliate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affiliate")]
#endif
        public PaymentIntentPaymentDetailsCarRentalDatumAffiliate Affiliate { get; set; }

        /// <summary>
        /// The booking number associated with the car rental.
        /// </summary>
        [JsonProperty("booking_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("booking_number")]
#endif
        public string BookingNumber { get; set; }

        /// <summary>
        /// The name of the car rental company.
        /// </summary>
        [JsonProperty("carrier_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("carrier_name")]
#endif
        public string CarrierName { get; set; }

        /// <summary>
        /// The customer service phone number of the car rental company.
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
        public long DaysRented { get; set; }

        [JsonProperty("distance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("distance")]
#endif
        public PaymentIntentPaymentDetailsCarRentalDatumDistance Distance { get; set; }

        /// <summary>
        /// The details of the drivers associated with the rental.
        /// </summary>
        [JsonProperty("drivers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("drivers")]
#endif
        public List<PaymentIntentPaymentDetailsCarRentalDatumDriver> Drivers { get; set; }

        [JsonProperty("drop_off")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("drop_off")]
#endif
        public PaymentIntentPaymentDetailsCarRentalDatumDropOff DropOff { get; set; }

        /// <summary>
        /// Insurance details for the car rental.
        /// </summary>
        [JsonProperty("insurances")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("insurances")]
#endif
        public List<PaymentIntentPaymentDetailsCarRentalDatumInsurance> Insurances { get; set; }

        /// <summary>
        /// Indicates if the customer did not keep nor cancel their booking.
        /// </summary>
        [JsonProperty("no_show_indicator")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("no_show_indicator")]
#endif
        public bool NoShowIndicator { get; set; }

        [JsonProperty("pickup")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pickup")]
#endif
        public PaymentIntentPaymentDetailsCarRentalDatumPickup Pickup { get; set; }

        /// <summary>
        /// Name of the person renting the vehicle.
        /// </summary>
        [JsonProperty("renter_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("renter_name")]
#endif
        public string RenterName { get; set; }

        [JsonProperty("total")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("total")]
#endif
        public PaymentIntentPaymentDetailsCarRentalDatumTotal Total { get; set; }

        [JsonProperty("vehicle")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("vehicle")]
#endif
        public PaymentIntentPaymentDetailsCarRentalDatumVehicle Vehicle { get; set; }
    }
}
