// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionWalletOptionsOptions : INestedOptions
    {
        /// <summary>
        /// contains details about the Link wallet options.
        /// </summary>
        [JsonProperty("link")]
        [STJS.JsonPropertyName("link")]
        public SessionWalletOptionsLinkOptions Link { get; set; }
    }
}
