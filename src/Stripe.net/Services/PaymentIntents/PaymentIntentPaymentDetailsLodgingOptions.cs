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

    public class PaymentIntentPaymentDetailsLodgingOptions : INestedOptions
    {
        /// <summary>
        /// The lodging location's address.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The number of adults on the booking.
        /// </summary>
        [JsonProperty("adults")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("adults")]
#endif
        public long? Adults { get; set; }

        /// <summary>
        /// Affiliate details for this purchase.
        /// </summary>
        [JsonProperty("affiliate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affiliate")]
#endif
        public PaymentIntentPaymentDetailsLodgingAffiliateOptions Affiliate { get; set; }

        /// <summary>
        /// The booking number associated with the lodging reservation.
        /// </summary>
        [JsonProperty("booking_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("booking_number")]
#endif
        public string BookingNumber { get; set; }

        /// <summary>
        /// The lodging category.
        /// One of: <c>hotel</c>, or <c>vacation_rental</c>.
        /// </summary>
        [JsonProperty("category")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("category")]
#endif
        public string Category { get; set; }

        /// <summary>
        /// Loding check-in time. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("checkin_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("checkin_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? CheckinAt { get; set; }

        /// <summary>
        /// Lodging check-out time. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("checkout_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("checkout_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? CheckoutAt { get; set; }

        /// <summary>
        /// The customer service phone number of the lodging company.
        /// </summary>
        [JsonProperty("customer_service_phone_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_service_phone_number")]
#endif
        public string CustomerServicePhoneNumber { get; set; }

        /// <summary>
        /// The daily lodging room rate.
        /// </summary>
        [JsonProperty("daily_room_rate_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("daily_room_rate_amount")]
#endif
        public long? DailyRoomRateAmount { get; set; }

        /// <summary>
        /// Delivery details for this purchase.
        /// </summary>
        [JsonProperty("delivery")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("delivery")]
#endif
        public PaymentIntentPaymentDetailsLodgingDeliveryOptions Delivery { get; set; }

        /// <summary>
        /// List of additional charges being billed.
        /// One of: <c>gift_shop</c>, <c>laundry</c>, <c>mini_bar</c>, <c>other</c>,
        /// <c>restaurant</c>, or <c>telephone</c>.
        /// </summary>
        [JsonProperty("extra_charges")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("extra_charges")]
#endif
        public List<string> ExtraCharges { get; set; }

        /// <summary>
        /// Indicates whether the lodging location is compliant with the Fire Safety Act.
        /// </summary>
        [JsonProperty("fire_safety_act_compliance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fire_safety_act_compliance")]
#endif
        public bool? FireSafetyActCompliance { get; set; }

        /// <summary>
        /// The name of the lodging location.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// Indicates if the customer did not keep their booking while failing to cancel the
        /// reservation.
        /// </summary>
        [JsonProperty("no_show")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("no_show")]
#endif
        public bool? NoShow { get; set; }

        /// <summary>
        /// The number of rooms on the booking.
        /// </summary>
        [JsonProperty("number_of_rooms")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("number_of_rooms")]
#endif
        public long? NumberOfRooms { get; set; }

        /// <summary>
        /// The details of the passengers in the travel reservation.
        /// </summary>
        [JsonProperty("passengers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("passengers")]
#endif
        public List<PaymentIntentPaymentDetailsLodgingPassengerOptions> Passengers { get; set; }

        /// <summary>
        /// The phone number of the lodging location.
        /// </summary>
        [JsonProperty("property_phone_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("property_phone_number")]
#endif
        public string PropertyPhoneNumber { get; set; }

        /// <summary>
        /// The room class for this purchase.
        /// </summary>
        [JsonProperty("room_class")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("room_class")]
#endif
        public string RoomClass { get; set; }

        /// <summary>
        /// The number of room nights.
        /// </summary>
        [JsonProperty("room_nights")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("room_nights")]
#endif
        public long? RoomNights { get; set; }

        /// <summary>
        /// The total tax amount associating with the room reservation.
        /// </summary>
        [JsonProperty("total_room_tax_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("total_room_tax_amount")]
#endif
        public long? TotalRoomTaxAmount { get; set; }

        /// <summary>
        /// The total tax amount.
        /// </summary>
        [JsonProperty("total_tax_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("total_tax_amount")]
#endif
        public long? TotalTaxAmount { get; set; }
    }
}
