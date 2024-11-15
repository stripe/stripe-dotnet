// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return authorizations that belong to the given card.
        /// </summary>
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif

        public string Card { get; set; }

        /// <summary>
        /// Only return authorizations that belong to the given cardholder.
        /// </summary>
        [JsonProperty("cardholder")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cardholder")]
#endif

        public string Cardholder { get; set; }

        /// <summary>
        /// Only return authorizations with the given status. One of <c>pending</c>, <c>closed</c>,
        /// or <c>reversed</c>.
        /// One of: <c>closed</c>, <c>pending</c>, or <c>reversed</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif

        public string Status { get; set; }
    }
}
