// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IssuingAuthorizationEvaluationCardholderDetails : StripeEntity<IssuingAuthorizationEvaluationCardholderDetails>
    {
        /// <summary>
        /// The timestamp when the cardholder was created.
        /// </summary>
        [JsonProperty("created_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// User's specified unique ID of the cardholder for this authorization attempt (e.g., RRN
        /// or internal reference).
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }
    }
}
