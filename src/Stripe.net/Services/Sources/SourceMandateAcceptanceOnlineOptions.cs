// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceMandateAcceptanceOnlineOptions : INestedOptions
    {
        /// <summary>
        /// The Unix timestamp (in seconds) when the mandate was accepted or refused by the
        /// customer.
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
        /// The IP address from which the mandate was accepted or refused by the customer.
        /// </summary>
        [JsonProperty("ip")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ip")]
#endif

        public string Ip { get; set; }

        /// <summary>
        /// The user agent of the browser from which the mandate was accepted or refused by the
        /// customer.
        /// </summary>
        [JsonProperty("user_agent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("user_agent")]
#endif

        public string UserAgent { get; set; }
    }
}
