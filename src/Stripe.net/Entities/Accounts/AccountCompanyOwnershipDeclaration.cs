namespace Stripe
{
    using System;
#if USE_SYSTEM_TEXT_JSON
    using System.Text.Json.Serialization;
#else
    using Newtonsoft.Json;
#endif
    using Stripe.Infrastructure;

    public class AccountCompanyOwnershipDeclaration : StripeEntity<AccountCompanyOwnershipDeclaration>
    {
        /// <summary>
        /// The Unix timestamp marking when the beneficial owner attestation was made.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#else
        [JsonProperty("date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#endif
        public DateTime? Date { get; set; }

        /// <summary>
        /// The IP address from which the beneficial owner attestation was made.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("ip")]
#else
        [JsonProperty("ip")]
#endif
        public string Ip { get; set; }

        /// <summary>
        /// The user-agent string from the browser where the beneficial owner attestation was made.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("user_agent")]
#else
        [JsonProperty("user_agent")]
#endif
        public string UserAgent { get; set; }
    }
}
