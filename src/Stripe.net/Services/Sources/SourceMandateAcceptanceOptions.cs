// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceMandateAcceptanceOptions : INestedOptions
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
        /// The parameters required to store a mandate accepted offline. Should only be set if
        /// <c>mandate[type]</c> is <c>offline</c>.
        /// </summary>
        [JsonProperty("offline")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("offline")]
#endif

        public SourceMandateAcceptanceOfflineOptions Offline { get; set; }

        /// <summary>
        /// The parameters required to store a mandate accepted online. Should only be set if
        /// <c>mandate[type]</c> is <c>online</c>.
        /// </summary>
        [JsonProperty("online")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("online")]
#endif

        public SourceMandateAcceptanceOnlineOptions Online { get; set; }

        /// <summary>
        /// The status of the mandate acceptance. Either <c>accepted</c> (the mandate was accepted)
        /// or <c>refused</c> (the mandate was refused).
        /// One of: <c>accepted</c>, <c>pending</c>, <c>refused</c>, or <c>revoked</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif

        public string Status { get; set; }

        /// <summary>
        /// The type of acceptance information included with the mandate. Either <c>online</c> or
        /// <c>offline</c>.
        /// One of: <c>offline</c>, or <c>online</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }

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
