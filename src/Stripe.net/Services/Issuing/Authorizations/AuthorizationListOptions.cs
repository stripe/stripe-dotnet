// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AuthorizationListOptions : ListOptions
    {
        /// <summary>
        /// Only return authorizations that belong to the given card.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public string Card { get; set; }

        /// <summary>
        /// Only return authorizations that belong to the given cardholder.
        /// </summary>
        [JsonProperty("cardholder")]
        [STJS.JsonPropertyName("cardholder")]
        public string Cardholder { get; set; }

        /// <summary>
        /// Only return authorizations that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Only return authorizations with the given status. One of <c>pending</c>, <c>closed</c>,
        /// or <c>reversed</c>.
        /// One of: <c>closed</c>, <c>expired</c>, <c>pending</c>, or <c>reversed</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
