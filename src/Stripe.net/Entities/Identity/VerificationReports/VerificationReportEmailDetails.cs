// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class VerificationReportEmailDetails : StripeEntity<VerificationReportEmailDetails>
    {
        /// <summary>
        /// Number of days from the time when the email domain was first observed to the time of
        /// verification.
        /// </summary>
        [JsonProperty("days_since_domain_creation")]
        [STJS.JsonPropertyName("days_since_domain_creation")]
        public decimal DaysSinceDomainCreation { get; set; }

        /// <summary>
        /// Number of days from the time when the email address was first observed to the time of
        /// verification.
        /// </summary>
        [JsonProperty("days_since_ownership_started")]
        [STJS.JsonPropertyName("days_since_ownership_started")]
        public decimal DaysSinceOwnershipStarted { get; set; }

        /// <summary>
        /// Two-letter ISO 3166-1 alpha-2 country code of the email domain's country.
        /// </summary>
        [JsonProperty("domain_country")]
        [STJS.JsonPropertyName("domain_country")]
        public string DomainCountry { get; set; }
    }
}
