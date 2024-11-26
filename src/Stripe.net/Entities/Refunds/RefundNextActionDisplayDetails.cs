// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RefundNextActionDisplayDetails : StripeEntity<RefundNextActionDisplayDetails>
    {
        [JsonProperty("email_sent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email_sent")]
#endif
        public RefundNextActionDisplayDetailsEmailSent EmailSent { get; set; }

        /// <summary>
        /// The expiry timestamp.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
