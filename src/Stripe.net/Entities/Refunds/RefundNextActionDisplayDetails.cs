// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RefundNextActionDisplayDetails : StripeEntity<RefundNextActionDisplayDetails>
    {
        [JsonProperty("email_sent")]
        [STJS.JsonPropertyName("email_sent")]
        public RefundNextActionDisplayDetailsEmailSent EmailSent { get; set; }

        /// <summary>
        /// The expiry timestamp.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
