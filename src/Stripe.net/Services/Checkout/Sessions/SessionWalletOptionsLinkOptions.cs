// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionWalletOptionsLinkOptions : INestedOptions
    {
        /// <summary>
        /// Specifies whether Checkout should display Link as a payment option. By default, Checkout
        /// will display all the supported wallets that the Checkout Session was created with. This
        /// is the <c>auto</c> behavior, and it is the default choice.
        /// One of: <c>auto</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("display")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display")]
#endif
        public string Display { get; set; }
    }
}
