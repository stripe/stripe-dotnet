// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PersonAdditionalTosAcceptancesAccount : StripeEntity<PersonAdditionalTosAcceptancesAccount>
    {
        /// <summary>
        /// The Unix timestamp marking when the legal guardian accepted the service agreement.
        /// </summary>
        [JsonProperty("date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("date")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? Date { get; set; }

        /// <summary>
        /// The IP address from which the legal guardian accepted the service agreement.
        /// </summary>
        [JsonProperty("ip")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ip")]
#endif

        public string Ip { get; set; }

        /// <summary>
        /// The user agent of the browser from which the legal guardian accepted the service
        /// agreement.
        /// </summary>
        [JsonProperty("user_agent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("user_agent")]
#endif

        public string UserAgent { get; set; }
    }
}
