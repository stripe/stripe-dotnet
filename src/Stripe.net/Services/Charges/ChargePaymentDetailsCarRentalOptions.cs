// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargePaymentDetailsCarRentalOptions : INestedOptions
    {
        /// <summary>
        /// Affiliate details for this purchase.
        /// </summary>
        [JsonProperty("affiliate")]
        public ChargePaymentDetailsCarRentalAffiliateOptions Affiliate { get; set; }

        /// <summary>
        /// The booking number associated with the car rental.
        /// </summary>
        [JsonProperty("booking_number")]
        public string BookingNumber { get; set; }

        /// <summary>
        /// Class code of the car.
        /// </summary>
        [JsonProperty("car_class_code")]
        public string CarClassCode { get; set; }

        /// <summary>
        /// Make of the car.
        /// </summary>
        [JsonProperty("car_make")]
        public string CarMake { get; set; }

        /// <summary>
        /// Model of the car.
        /// </summary>
        [JsonProperty("car_model")]
        public string CarModel { get; set; }

        /// <summary>
        /// The name of the rental car company.
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }

        /// <summary>
        /// The customer service phone number of the car rental company.
        /// </summary>
        [JsonProperty("customer_service_phone_number")]
        public string CustomerServicePhoneNumber { get; set; }

        /// <summary>
        /// Number of days the car is being rented.
        /// </summary>
        [JsonProperty("days_rented")]
        public long? DaysRented { get; set; }

        /// <summary>
        /// Delivery details for this purchase.
        /// </summary>
        [JsonProperty("delivery")]
        public ChargePaymentDetailsCarRentalDeliveryOptions Delivery { get; set; }

        /// <summary>
        /// The details of the passengers in the travel reservation.
        /// </summary>
        [JsonProperty("drivers")]
        public List<ChargePaymentDetailsCarRentalDriverOptions> Drivers { get; set; }

        /// <summary>
        /// List of additional charges being billed.
        /// One of: <c>extra_mileage</c>, <c>gas</c>, <c>late_return</c>, <c>one_way_service</c>, or
        /// <c>parking_violation</c>.
        /// </summary>
        [JsonProperty("extra_charges")]
        public List<string> ExtraCharges { get; set; }

        /// <summary>
        /// Indicates if the customer did not keep nor cancel their booking.
        /// </summary>
        [JsonProperty("no_show")]
        public bool? NoShow { get; set; }

        /// <summary>
        /// Car pick-up address.
        /// </summary>
        [JsonProperty("pickup_address")]
        public AddressOptions PickupAddress { get; set; }

        /// <summary>
        /// Car pick-up time. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("pickup_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? PickupAt { get; set; }

        /// <summary>
        /// Rental rate.
        /// </summary>
        [JsonProperty("rate_amount")]
        public long? RateAmount { get; set; }

        /// <summary>
        /// The frequency at which the rate amount is applied. One of <c>day</c>, <c>week</c> or
        /// <c>month</c>.
        /// One of: <c>day</c>, <c>month</c>, or <c>week</c>.
        /// </summary>
        [JsonProperty("rate_interval")]
        public string RateInterval { get; set; }

        /// <summary>
        /// The name of the person or entity renting the car.
        /// </summary>
        [JsonProperty("renter_name")]
        public string RenterName { get; set; }

        /// <summary>
        /// Car return address.
        /// </summary>
        [JsonProperty("return_address")]
        public AddressOptions ReturnAddress { get; set; }

        /// <summary>
        /// Car return time. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("return_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ReturnAt { get; set; }

        /// <summary>
        /// Indicates whether the goods or services are tax-exempt or tax is not collected.
        /// </summary>
        [JsonProperty("tax_exempt")]
        public bool? TaxExempt { get; set; }
    }
}
