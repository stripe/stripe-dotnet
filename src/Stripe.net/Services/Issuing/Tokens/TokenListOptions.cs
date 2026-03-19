// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TokenListOptions : ListOptions
    {
        /// <summary>
        /// The Issuing card identifier to list tokens for.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public string Card { get; set; }

        /// <summary>
        /// Only return Issuing tokens that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Select Issuing tokens with the given status.
        /// One of: <c>active</c>, <c>deleted</c>, <c>requested</c>, or <c>suspended</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
