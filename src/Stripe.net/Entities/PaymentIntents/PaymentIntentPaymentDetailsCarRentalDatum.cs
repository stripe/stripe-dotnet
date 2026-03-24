// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsCarRentalDatum : StripeEntity<PaymentIntentPaymentDetailsCarRentalDatum>
    {
        [JsonProperty("affiliate")]
        [STJS.JsonPropertyName("affiliate")]
        public PaymentIntentPaymentDetailsCarRentalDatumAffiliate Affiliate { get; set; }

        /// <summary>
        /// The booking number associated with the car rental.
        /// </summary>
        [JsonProperty("booking_number")]
        [STJS.JsonPropertyName("booking_number")]
        public string BookingNumber { get; set; }

        /// <summary>
        /// The name of the car rental company.
        /// </summary>
        [JsonProperty("carrier_name")]
        [STJS.JsonPropertyName("carrier_name")]
        public string CarrierName { get; set; }

        /// <summary>
        /// The customer service phone number of the car rental company.
        /// </summary>
        [JsonProperty("customer_service_phone_number")]
        [STJS.JsonPropertyName("customer_service_phone_number")]
        public string CustomerServicePhoneNumber { get; set; }

        /// <summary>
        /// Number of days the car is being rented.
        /// </summary>
        [JsonProperty("days_rented")]
        [STJS.JsonPropertyName("days_rented")]
        public long DaysRented { get; set; }

        [JsonProperty("distance")]
        [STJS.JsonPropertyName("distance")]
        public PaymentIntentPaymentDetailsCarRentalDatumDistance Distance { get; set; }

        /// <summary>
        /// The details of the drivers associated with the rental.
        /// </summary>
        [JsonProperty("drivers")]
        [STJS.JsonPropertyName("drivers")]
        public List<PaymentIntentPaymentDetailsCarRentalDatumDriver> Drivers { get; set; }

        [JsonProperty("drop_off")]
        [STJS.JsonPropertyName("drop_off")]
        public PaymentIntentPaymentDetailsCarRentalDatumDropOff DropOff { get; set; }

        /// <summary>
        /// Insurance details for the car rental.
        /// </summary>
        [JsonProperty("insurances")]
        [STJS.JsonPropertyName("insurances")]
        public List<PaymentIntentPaymentDetailsCarRentalDatumInsurance> Insurances { get; set; }

        /// <summary>
        /// Indicates if the customer did not keep nor cancel their booking.
        /// </summary>
        [JsonProperty("no_show_indicator")]
        [STJS.JsonPropertyName("no_show_indicator")]
        public bool NoShowIndicator { get; set; }

        [JsonProperty("pickup")]
        [STJS.JsonPropertyName("pickup")]
        public PaymentIntentPaymentDetailsCarRentalDatumPickup Pickup { get; set; }

        /// <summary>
        /// Name of the person renting the vehicle.
        /// </summary>
        [JsonProperty("renter_name")]
        [STJS.JsonPropertyName("renter_name")]
        public string RenterName { get; set; }

        [JsonProperty("total")]
        [STJS.JsonPropertyName("total")]
        public PaymentIntentPaymentDetailsCarRentalDatumTotal Total { get; set; }

        [JsonProperty("vehicle")]
        [STJS.JsonPropertyName("vehicle")]
        public PaymentIntentPaymentDetailsCarRentalDatumVehicle Vehicle { get; set; }
    }
}
