// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsCarRental : StripeEntity<PaymentIntentPaymentDetailsCarRental>
    {
        [JsonProperty("affiliate")]
        [STJS.JsonPropertyName("affiliate")]
        public PaymentIntentPaymentDetailsCarRentalAffiliate Affiliate { get; set; }

        /// <summary>
        /// The booking number associated with the car rental.
        /// </summary>
        [JsonProperty("booking_number")]
        [STJS.JsonPropertyName("booking_number")]
        public string BookingNumber { get; set; }

        /// <summary>
        /// Class code of the car.
        /// </summary>
        [JsonProperty("car_class_code")]
        [STJS.JsonPropertyName("car_class_code")]
        public string CarClassCode { get; set; }

        /// <summary>
        /// Make of the car.
        /// </summary>
        [JsonProperty("car_make")]
        [STJS.JsonPropertyName("car_make")]
        public string CarMake { get; set; }

        /// <summary>
        /// Model of the car.
        /// </summary>
        [JsonProperty("car_model")]
        [STJS.JsonPropertyName("car_model")]
        public string CarModel { get; set; }

        /// <summary>
        /// The name of the rental car company.
        /// </summary>
        [JsonProperty("company")]
        [STJS.JsonPropertyName("company")]
        public string Company { get; set; }

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

        [JsonProperty("delivery")]
        [STJS.JsonPropertyName("delivery")]
        public PaymentIntentPaymentDetailsCarRentalDelivery Delivery { get; set; }

        [JsonProperty("distance")]
        [STJS.JsonPropertyName("distance")]
        public PaymentIntentPaymentDetailsCarRentalDistance Distance { get; set; }

        /// <summary>
        /// The details of the drivers associated with the trip.
        /// </summary>
        [JsonProperty("drivers")]
        [STJS.JsonPropertyName("drivers")]
        public List<PaymentIntentPaymentDetailsCarRentalDriver> Drivers { get; set; }

        /// <summary>
        /// List of additional charges being billed.
        /// One of: <c>extra_mileage</c>, <c>gas</c>, <c>late_return</c>, <c>one_way_service</c>, or
        /// <c>parking_violation</c>.
        /// </summary>
        [JsonProperty("extra_charges")]
        [STJS.JsonPropertyName("extra_charges")]
        public List<string> ExtraCharges { get; set; }

        /// <summary>
        /// Indicates if the customer did not keep nor cancel their booking.
        /// </summary>
        [JsonProperty("no_show")]
        [STJS.JsonPropertyName("no_show")]
        public bool NoShow { get; set; }

        [JsonProperty("pickup_address")]
        [STJS.JsonPropertyName("pickup_address")]
        public Address PickupAddress { get; set; }

        /// <summary>
        /// Car pick-up time. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("pickup_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("pickup_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime PickupAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Name of the pickup location.
        /// </summary>
        [JsonProperty("pickup_location_name")]
        [STJS.JsonPropertyName("pickup_location_name")]
        public string PickupLocationName { get; set; }

        /// <summary>
        /// Rental rate.
        /// </summary>
        [JsonProperty("rate_amount")]
        [STJS.JsonPropertyName("rate_amount")]
        public long RateAmount { get; set; }

        /// <summary>
        /// The frequency at which the rate amount is applied. One of <c>day</c>, <c>week</c> or
        /// <c>month</c>.
        /// One of: <c>day</c>, <c>month</c>, or <c>week</c>.
        /// </summary>
        [JsonProperty("rate_interval")]
        [STJS.JsonPropertyName("rate_interval")]
        public string RateInterval { get; set; }

        /// <summary>
        /// The full name of the person or entity renting the car.
        /// </summary>
        [JsonProperty("renter_name")]
        [STJS.JsonPropertyName("renter_name")]
        public string RenterName { get; set; }

        [JsonProperty("return_address")]
        [STJS.JsonPropertyName("return_address")]
        public Address ReturnAddress { get; set; }

        /// <summary>
        /// Car return time. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("return_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("return_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime ReturnAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Name of the return location.
        /// </summary>
        [JsonProperty("return_location_name")]
        [STJS.JsonPropertyName("return_location_name")]
        public string ReturnLocationName { get; set; }

        /// <summary>
        /// Indicates whether the goods or services are tax-exempt or tax is not collected.
        /// </summary>
        [JsonProperty("tax_exempt")]
        [STJS.JsonPropertyName("tax_exempt")]
        public bool TaxExempt { get; set; }

        /// <summary>
        /// The vehicle identification number of the car.
        /// </summary>
        [JsonProperty("vehicle_identification_number")]
        [STJS.JsonPropertyName("vehicle_identification_number")]
        public string VehicleIdentificationNumber { get; set; }
    }
}
