// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IssuingAuthorizationEvaluationCardholderDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The time when the cardholder was created (Unix timestamp).
        /// </summary>
        [JsonProperty("created_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// External reference for the cardholder.
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif
        public string Reference { get; set; }
    }
}
