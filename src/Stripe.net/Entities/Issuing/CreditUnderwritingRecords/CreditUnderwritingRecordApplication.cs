// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditUnderwritingRecordApplication : StripeEntity<CreditUnderwritingRecordApplication>
    {
        /// <summary>
        /// The channel through which the applicant has submitted their application.
        /// One of: <c>in_person</c>, <c>mail</c>, <c>online</c>, or <c>phone</c>.
        /// </summary>
        [JsonProperty("application_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application_method")]
#endif
        public string ApplicationMethod { get; set; }

        /// <summary>
        /// Scope of demand made by the applicant.
        /// One of: <c>credit_limit_increase</c>, or <c>credit_line_opening</c>.
        /// </summary>
        [JsonProperty("purpose")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("purpose")]
#endif
        public string Purpose { get; set; }

        /// <summary>
        /// Date when the applicant submitted their application.
        /// </summary>
        [JsonProperty("submitted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("submitted_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime SubmittedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
