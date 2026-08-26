// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class VerificationSessionUserConsentOptions : INestedOptions
    {
        /// <summary>
        /// The time at which the user gave consent, as a Unix timestamp.
        /// </summary>
        [JsonProperty("date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The IP address of the user when they gave consent.
        /// </summary>
        [JsonProperty("ip")]
        [STJS.JsonPropertyName("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// The user agent of the browser or device the user used to give consent.
        /// </summary>
        [JsonProperty("user_agent")]
        [STJS.JsonPropertyName("user_agent")]
        public string UserAgent { get; set; }
    }
}
