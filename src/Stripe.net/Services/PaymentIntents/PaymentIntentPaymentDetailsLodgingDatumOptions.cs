// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentDetailsLodgingDatumOptions : INestedOptions
    {
        /// <summary>
        /// Accommodation details for the lodging.
        /// </summary>
        [JsonProperty("accommodation")]
        [STJS.JsonPropertyName("accommodation")]
        public PaymentIntentPaymentDetailsLodgingDatumAccommodationOptions Accommodation { get; set; }

        /// <summary>
        /// Affiliate details if applicable.
        /// </summary>
        [JsonProperty("affiliate")]
        [STJS.JsonPropertyName("affiliate")]
        public PaymentIntentPaymentDetailsLodgingDatumAffiliateOptions Affiliate { get; set; }

        /// <summary>
        /// Booking confirmation number for the lodging.
        /// </summary>
        [JsonProperty("booking_number")]
        [STJS.JsonPropertyName("booking_number")]
        public string BookingNumber { get; set; }

        /// <summary>
        /// Check-in date.
        /// </summary>
        [JsonProperty("checkin_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("checkin_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? CheckinAt { get; set; }

        /// <summary>
        /// Check-out date.
        /// </summary>
        [JsonProperty("checkout_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("checkout_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? CheckoutAt { get; set; }

        /// <summary>
        /// Customer service phone number for the lodging company.
        /// </summary>
        [JsonProperty("customer_service_phone_number")]
        [STJS.JsonPropertyName("customer_service_phone_number")]
        public string CustomerServicePhoneNumber { get; set; }

        /// <summary>
        /// Whether the lodging is compliant with any hotel fire safety regulations.
        /// </summary>
        [JsonProperty("fire_safety_act_compliance_indicator")]
        [STJS.JsonPropertyName("fire_safety_act_compliance_indicator")]
        public bool? FireSafetyActComplianceIndicator { get; set; }

        /// <summary>
        /// List of guests for the lodging.
        /// </summary>
        [JsonProperty("guests")]
        [STJS.JsonPropertyName("guests")]
        public List<PaymentIntentPaymentDetailsLodgingDatumGuestOptions> Guests { get; set; }

        /// <summary>
        /// Host details for the lodging.
        /// </summary>
        [JsonProperty("host")]
        [STJS.JsonPropertyName("host")]
        public PaymentIntentPaymentDetailsLodgingDatumHostOptions Host { get; set; }

        /// <summary>
        /// List of insurances for the lodging.
        /// </summary>
        [JsonProperty("insurances")]
        [STJS.JsonPropertyName("insurances")]
        public List<PaymentIntentPaymentDetailsLodgingDatumInsuranceOptions> Insurances { get; set; }

        /// <summary>
        /// Whether the renter is a no-show.
        /// </summary>
        [JsonProperty("no_show_indicator")]
        [STJS.JsonPropertyName("no_show_indicator")]
        public bool? NoShowIndicator { get; set; }

        /// <summary>
        /// Renter ID number for the lodging.
        /// </summary>
        [JsonProperty("renter_id_number")]
        [STJS.JsonPropertyName("renter_id_number")]
        public string RenterIdNumber { get; set; }

        /// <summary>
        /// Renter name for the lodging.
        /// </summary>
        [JsonProperty("renter_name")]
        [STJS.JsonPropertyName("renter_name")]
        public string RenterName { get; set; }

        /// <summary>
        /// Total details for the lodging.
        /// </summary>
        [JsonProperty("total")]
        [STJS.JsonPropertyName("total")]
        public PaymentIntentPaymentDetailsLodgingDatumTotalOptions Total { get; set; }
    }
}
