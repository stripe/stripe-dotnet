// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundPaymentTrackingDetailsPaperCheck : StripeEntity<OutboundPaymentTrackingDetailsPaperCheck>
    {
        /// <summary>
        /// Open Enum. Carrier of the paper check.
        /// One of: <c>fedex</c>, or <c>usps</c>.
        /// </summary>
        [JsonProperty("carrier")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("carrier")]
#endif
        public string Carrier { get; set; }

        /// <summary>
        /// Check number.
        /// </summary>
        [JsonProperty("check_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("check_number")]
#endif
        public string CheckNumber { get; set; }

        /// <summary>
        /// Postal code of the latest tracking update.
        /// </summary>
        [JsonProperty("current_postal_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("current_postal_code")]
#endif
        public string CurrentPostalCode { get; set; }

        /// <summary>
        /// Mailing address of the paper check.
        /// </summary>
        [JsonProperty("mailing_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mailing_address")]
#endif
        public OutboundPaymentTrackingDetailsPaperCheckMailingAddress MailingAddress { get; set; }

        /// <summary>
        /// Tracking number for the check.
        /// </summary>
        [JsonProperty("tracking_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tracking_number")]
#endif
        public string TrackingNumber { get; set; }

        /// <summary>
        /// Open Enum. Tracking status of the paper check.
        /// One of: <c>delivered</c>, <c>in_transit</c>, or <c>mailed</c>.
        /// </summary>
        [JsonProperty("tracking_status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tracking_status")]
#endif
        public string TrackingStatus { get; set; }

        /// <summary>
        /// When the tracking details were last updated.
        /// </summary>
        [JsonProperty("updated_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("updated_at")]
#endif
        public DateTime UpdatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
