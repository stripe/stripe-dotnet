// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class TokenListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// The Issuing card identifier to list tokens for.
        /// </summary>
        [JsonProperty("card")]
        public string Card { get; set; }

        /// <summary>
        /// Select Issuing tokens with the given status.
        /// One of: <c>active</c>, <c>deleted</c>, <c>requested</c>, or <c>suspended</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
