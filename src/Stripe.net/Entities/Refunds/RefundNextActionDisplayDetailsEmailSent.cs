// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class RefundNextActionDisplayDetailsEmailSent : StripeEntity<RefundNextActionDisplayDetailsEmailSent>
    {
        /// <summary>
        /// The timestamp when the email was sent.
        /// </summary>
        [JsonProperty("email_sent_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime EmailSentAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The recipient's email address.
        /// </summary>
        [JsonProperty("email_sent_to")]
        public string EmailSentTo { get; set; }
    }
}
