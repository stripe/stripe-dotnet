// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class TokenUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Specifies which status the token should be updated to.
        /// One of: <c>active</c>, <c>deleted</c>, or <c>suspended</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
