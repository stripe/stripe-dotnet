// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsCarRental : StripeEntity<PaymentIntentPaymentDetailsCarRental>
    {
        [JsonProperty("affiliate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affiliate")]
#endif
        public PaymentIntentPaymentDetailsCarRentalAffiliate Affiliate { get; set; }

        /// <summary>
        /// The booking number associated with the car rental.
        /// </summary>
        [JsonProperty("booking_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("booking_number")]
#endif
        public string BookingNumber { get; set; }

        /// <summary>
        /// Class code of the car.
        /// </summary>
        [JsonProperty("car_class_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("car_class_code")]
#endif
        public string CarClassCode { get; set; }

        /// <summary>
        /// Make of the car.
        /// </summary>
        [JsonProperty("car_make")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("car_make")]
#endif
        public string CarMake { get; set; }

        /// <summary>
        /// Model of the car.
        /// </summary>
        [JsonProperty("car_model")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("car_model")]
#endif
        public string CarModel { get; set; }

        /// <summary>
        /// The name of the rental car company.
        /// </summary>
        [JsonProperty("company")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("company")]
#endif
        public string Company { get; set; }

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

        [JsonProperty("delivery")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("delivery")]
#endif
        public PaymentIntentPaymentDetailsCarRentalDelivery Delivery { get; set; }

        [JsonProperty("distance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("distance")]
#endif
        public PaymentIntentPaymentDetailsCarRentalDistance Distance { get; set; }

        /// <summary>
        /// The details of the drivers associated with the trip.
        /// </summary>
        [JsonProperty("drivers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("drivers")]
#endif
        public List<PaymentIntentPaymentDetailsCarRentalDriver> Drivers { get; set; }

        /// <summary>
        /// List of additional charges being billed.
        /// One of: <c>extra_mileage</c>, <c>gas</c>, <c>late_return</c>, <c>one_way_service</c>, or
        /// <c>parking_violation</c>.
        /// </summary>
        [JsonProperty("extra_charges")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("extra_charges")]
#endif
        public List<string> ExtraCharges { get; set; }

        /// <summary>
        /// Indicates if the customer did not keep nor cancel their booking.
        /// </summary>
        [JsonProperty("no_show")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("no_show")]
#endif
        public bool NoShow { get; set; }

        [JsonProperty("pickup_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pickup_address")]
#endif
        public Address PickupAddress { get; set; }

        /// <summary>
        /// Car pick-up time. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("pickup_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pickup_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime PickupAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Name of the pickup location.
        /// </summary>
        [JsonProperty("pickup_location_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pickup_location_name")]
#endif
        public string PickupLocationName { get; set; }

        /// <summary>
        /// Rental rate.
        /// </summary>
        [JsonProperty("rate_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_amount")]
#endif
        public long RateAmount { get; set; }

        /// <summary>
        /// The frequency at which the rate amount is applied. One of <c>day</c>, <c>week</c> or
        /// <c>month</c>.
        /// One of: <c>day</c>, <c>month</c>, or <c>week</c>.
        /// </summary>
        [JsonProperty("rate_interval")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_interval")]
#endif
        public string RateInterval { get; set; }

        /// <summary>
        /// The full name of the person or entity renting the car.
        /// </summary>
        [JsonProperty("renter_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("renter_name")]
#endif
        public string RenterName { get; set; }

        [JsonProperty("return_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("return_address")]
#endif
        public Address ReturnAddress { get; set; }

        /// <summary>
        /// Car return time. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("return_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("return_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime ReturnAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Name of the return location.
        /// </summary>
        [JsonProperty("return_location_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("return_location_name")]
#endif
        public string ReturnLocationName { get; set; }

        /// <summary>
        /// Indicates whether the goods or services are tax-exempt or tax is not collected.
        /// </summary>
        [JsonProperty("tax_exempt")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_exempt")]
#endif
        public bool TaxExempt { get; set; }

        /// <summary>
        /// The vehicle identification number of the car.
        /// </summary>
        [JsonProperty("vehicle_identification_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("vehicle_identification_number")]
#endif
        public string VehicleIdentificationNumber { get; set; }
    }
}
