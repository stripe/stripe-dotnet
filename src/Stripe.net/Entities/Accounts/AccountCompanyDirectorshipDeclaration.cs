// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountCompanyDirectorshipDeclaration : StripeEntity<AccountCompanyDirectorshipDeclaration>
    {
        /// <summary>
        /// The Unix timestamp marking when the directorship declaration attestation was made.
        /// </summary>
        [JsonProperty("date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The IP address from which the directorship declaration attestation was made.
        /// </summary>
        [JsonProperty("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// The user-agent string from the browser where the directorship declaration attestation
        /// was made.
        /// </summary>
        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }
    }
}
