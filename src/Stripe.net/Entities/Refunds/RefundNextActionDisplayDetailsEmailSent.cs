// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RefundNextActionDisplayDetailsEmailSent : StripeEntity<RefundNextActionDisplayDetailsEmailSent>
    {
        /// <summary>
        /// The timestamp when the email was sent.
        /// </summary>
        [JsonProperty("email_sent_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("email_sent_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime EmailSentAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The recipient's email address.
        /// </summary>
        [JsonProperty("email_sent_to")]
        [STJS.JsonPropertyName("email_sent_to")]
        public string EmailSentTo { get; set; }
    }
}
