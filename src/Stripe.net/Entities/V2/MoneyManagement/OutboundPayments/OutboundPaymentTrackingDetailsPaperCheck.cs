// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundPaymentTrackingDetailsPaperCheck : StripeEntity<OutboundPaymentTrackingDetailsPaperCheck>
    {
        /// <summary>
        /// Open Enum. Carrier of the paper check.
        /// One of: <c>fedex</c>, or <c>usps</c>.
        /// </summary>
        [JsonProperty("carrier")]
        [STJS.JsonPropertyName("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// Check number.
        /// </summary>
        [JsonProperty("check_number")]
        [STJS.JsonPropertyName("check_number")]
        public string CheckNumber { get; set; }

        /// <summary>
        /// Postal code of the latest tracking update.
        /// </summary>
        [JsonProperty("current_postal_code")]
        [STJS.JsonPropertyName("current_postal_code")]
        public string CurrentPostalCode { get; set; }

        /// <summary>
        /// Mailing address of the paper check.
        /// </summary>
        [JsonProperty("mailing_address")]
        [STJS.JsonPropertyName("mailing_address")]
        public OutboundPaymentTrackingDetailsPaperCheckMailingAddress MailingAddress { get; set; }

        /// <summary>
        /// Tracking number for the check.
        /// </summary>
        [JsonProperty("tracking_number")]
        [STJS.JsonPropertyName("tracking_number")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// Open Enum. Tracking status of the paper check.
        /// One of: <c>delivered</c>, <c>in_transit</c>, or <c>mailed</c>.
        /// </summary>
        [JsonProperty("tracking_status")]
        [STJS.JsonPropertyName("tracking_status")]
        public string TrackingStatus { get; set; }

        /// <summary>
        /// When the tracking details were last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        [STJS.JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
