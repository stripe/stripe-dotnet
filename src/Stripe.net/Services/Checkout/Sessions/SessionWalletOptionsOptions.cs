// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionWalletOptionsOptions : INestedOptions
    {
        /// <summary>
        /// contains details about the Link wallet options.
        /// </summary>
        [JsonProperty("link")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("link")]
#endif
        public SessionWalletOptionsLinkOptions Link { get; set; }
    }
}
