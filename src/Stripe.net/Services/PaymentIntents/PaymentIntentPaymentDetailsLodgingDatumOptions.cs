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

    public class PaymentIntentPaymentDetailsLodgingDatumOptions : INestedOptions
    {
        /// <summary>
        /// Accommodation details for the lodging.
        /// </summary>
        [JsonProperty("accommodation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("accommodation")]
#endif
        public PaymentIntentPaymentDetailsLodgingDatumAccommodationOptions Accommodation { get; set; }

        /// <summary>
        /// Affiliate details if applicable.
        /// </summary>
        [JsonProperty("affiliate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affiliate")]
#endif
        public PaymentIntentPaymentDetailsLodgingDatumAffiliateOptions Affiliate { get; set; }

        /// <summary>
        /// Booking confirmation number for the lodging.
        /// </summary>
        [JsonProperty("booking_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("booking_number")]
#endif
        public string BookingNumber { get; set; }

        /// <summary>
        /// Check-in date.
        /// </summary>
        [JsonProperty("checkin_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("checkin_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? CheckinAt { get; set; }

        /// <summary>
        /// Check-out date.
        /// </summary>
        [JsonProperty("checkout_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("checkout_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? CheckoutAt { get; set; }

        /// <summary>
        /// Customer service phone number for the lodging company.
        /// </summary>
        [JsonProperty("customer_service_phone_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_service_phone_number")]
#endif
        public string CustomerServicePhoneNumber { get; set; }

        /// <summary>
        /// Whether the lodging is compliant with any hotel fire safety regulations.
        /// </summary>
        [JsonProperty("fire_safety_act_compliance_indicator")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fire_safety_act_compliance_indicator")]
#endif
        public bool? FireSafetyActComplianceIndicator { get; set; }

        /// <summary>
        /// List of guests for the lodging.
        /// </summary>
        [JsonProperty("guests")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("guests")]
#endif
        public List<PaymentIntentPaymentDetailsLodgingDatumGuestOptions> Guests { get; set; }

        /// <summary>
        /// Host details for the lodging.
        /// </summary>
        [JsonProperty("host")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("host")]
#endif
        public PaymentIntentPaymentDetailsLodgingDatumHostOptions Host { get; set; }

        /// <summary>
        /// List of insurances for the lodging.
        /// </summary>
        [JsonProperty("insurances")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("insurances")]
#endif
        public List<PaymentIntentPaymentDetailsLodgingDatumInsuranceOptions> Insurances { get; set; }

        /// <summary>
        /// Whether the renter is a no-show.
        /// </summary>
        [JsonProperty("no_show_indicator")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("no_show_indicator")]
#endif
        public bool? NoShowIndicator { get; set; }

        /// <summary>
        /// Renter ID number for the lodging.
        /// </summary>
        [JsonProperty("renter_id_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("renter_id_number")]
#endif
        public string RenterIdNumber { get; set; }

        /// <summary>
        /// Renter name for the lodging.
        /// </summary>
        [JsonProperty("renter_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("renter_name")]
#endif
        public string RenterName { get; set; }

        /// <summary>
        /// Total details for the lodging.
        /// </summary>
        [JsonProperty("total")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("total")]
#endif
        public PaymentIntentPaymentDetailsLodgingDatumTotalOptions Total { get; set; }
    }
}
