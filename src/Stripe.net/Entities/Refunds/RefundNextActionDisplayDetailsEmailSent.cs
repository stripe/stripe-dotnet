// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RefundNextActionDisplayDetailsEmailSent : StripeEntity<RefundNextActionDisplayDetailsEmailSent>
    {
        /// <summary>
        /// The timestamp when the email was sent.
        /// </summary>
        [JsonProperty("email_sent_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email_sent_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime EmailSentAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The recipient's email address.
        /// </summary>
        [JsonProperty("email_sent_to")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email_sent_to")]
#endif

        public string EmailSentTo { get; set; }
    }
}
