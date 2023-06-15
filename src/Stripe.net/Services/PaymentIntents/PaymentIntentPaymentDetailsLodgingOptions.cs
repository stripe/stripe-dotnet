// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentPaymentDetailsLodgingOptions : INestedOptions
    {
        /// <summary>
        /// The lodging location's address.
        /// </summary>
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The number of adults on the booking.
        /// </summary>
        [JsonProperty("adults")]
        public long? Adults { get; set; }

        /// <summary>
        /// The booking number associated with the lodging reservation.
        /// </summary>
        [JsonProperty("booking_number")]
        public string BookingNumber { get; set; }

        /// <summary>
        /// The lodging category.
        /// One of: <c>hotel</c>, or <c>vacation_rental</c>.
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// Loding check-in time. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("checkin_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CheckinAt { get; set; }

        /// <summary>
        /// Lodging check-out time. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("checkout_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CheckoutAt { get; set; }

        /// <summary>
        /// The customer service phone number of the lodging company.
        /// </summary>
        [JsonProperty("customer_service_phone_number")]
        public string CustomerServicePhoneNumber { get; set; }

        /// <summary>
        /// The daily lodging room rate.
        /// </summary>
        [JsonProperty("daily_room_rate_amount")]
        public long? DailyRoomRateAmount { get; set; }

        /// <summary>
        /// List of additional charges being billed.
        /// </summary>
        [JsonProperty("extra_charges")]
        public List<string> ExtraCharges { get; set; }

        /// <summary>
        /// Indicates whether the lodging location is compliant with the Fire Safety Act.
        /// </summary>
        [JsonProperty("fire_safety_act_compliance")]
        public bool? FireSafetyActCompliance { get; set; }

        /// <summary>
        /// The name of the lodging location.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Indicates if the customer did not keep their booking while failing to cancel the
        /// reservation.
        /// </summary>
        [JsonProperty("no_show")]
        public bool? NoShow { get; set; }

        /// <summary>
        /// The phone number of the lodging location.
        /// </summary>
        [JsonProperty("property_phone_number")]
        public string PropertyPhoneNumber { get; set; }

        /// <summary>
        /// The number of room nights.
        /// </summary>
        [JsonProperty("room_nights")]
        public long? RoomNights { get; set; }

        /// <summary>
        /// The total tax amount associating with the room reservation.
        /// </summary>
        [JsonProperty("total_room_tax_amount")]
        public long? TotalRoomTaxAmount { get; set; }

        /// <summary>
        /// The total tax amount.
        /// </summary>
        [JsonProperty("total_tax_amount")]
        public long? TotalTaxAmount { get; set; }
    }
}
