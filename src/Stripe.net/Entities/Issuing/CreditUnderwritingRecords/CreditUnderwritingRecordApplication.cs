// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CreditUnderwritingRecordApplication : StripeEntity<CreditUnderwritingRecordApplication>
    {
        /// <summary>
        /// The channel through which the applicant has submitted their application.
        /// One of: <c>in_person</c>, <c>mail</c>, <c>online</c>, or <c>phone</c>.
        /// </summary>
        [JsonProperty("application_method")]
        [STJS.JsonPropertyName("application_method")]
        public string ApplicationMethod { get; set; }

        /// <summary>
        /// Scope of demand made by the applicant.
        /// One of: <c>credit_limit_increase</c>, or <c>credit_line_opening</c>.
        /// </summary>
        [JsonProperty("purpose")]
        [STJS.JsonPropertyName("purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// Date when the applicant submitted their application.
        /// </summary>
        [JsonProperty("submitted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("submitted_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime SubmittedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
