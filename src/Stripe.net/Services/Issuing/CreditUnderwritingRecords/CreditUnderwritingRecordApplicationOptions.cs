// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CreditUnderwritingRecordApplicationOptions : INestedOptions
    {
        /// <summary>
        /// The channel through which the applicant has submitted their application. Defaults to
        /// <c>online</c>.
        /// One of: <c>in_person</c>, <c>mail</c>, <c>online</c>, or <c>phone</c>.
        /// </summary>
        [JsonProperty("application_method")]
        public string ApplicationMethod { get; set; }

        /// <summary>
        /// Scope of demand made by the applicant.
        /// One of: <c>credit_limit_increase</c>, or <c>credit_line_opening</c>.
        /// </summary>
        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// Date when the applicant submitted their application.
        /// </summary>
        [JsonProperty("submitted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? SubmittedAt { get; set; }
    }
}
