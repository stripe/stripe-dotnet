// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class RefundNextActionDisplayDetails : StripeEntity<RefundNextActionDisplayDetails>
    {
        [JsonProperty("email_sent")]
        public RefundNextActionDisplayDetailsEmailSent EmailSent { get; set; }

        /// <summary>
        /// The expiry timestamp.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
