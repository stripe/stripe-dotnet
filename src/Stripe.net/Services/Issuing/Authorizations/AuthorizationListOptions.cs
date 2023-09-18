// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return authorizations that belong to the given card.
        /// </summary>
        [JsonProperty("card")]
        public string Card { get; set; }

        /// <summary>
        /// Only return authorizations that belong to the given cardholder.
        /// </summary>
        [JsonProperty("cardholder")]
        public string Cardholder { get; set; }

        /// <summary>
        /// Only return authorizations with the given status. One of <c>pending</c>, <c>closed</c>,
        /// or <c>reversed</c>.
        /// One of: <c>closed</c>, <c>pending</c>, or <c>reversed</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
