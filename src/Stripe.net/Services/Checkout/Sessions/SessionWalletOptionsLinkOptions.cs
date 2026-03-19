// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionWalletOptionsLinkOptions : INestedOptions
    {
        /// <summary>
        /// Specifies whether Checkout should display Link as a payment option. By default, Checkout
        /// will display all the supported wallets that the Checkout Session was created with. This
        /// is the <c>auto</c> behavior, and it is the default choice.
        /// One of: <c>auto</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("display")]
        [STJS.JsonPropertyName("display")]
        public string Display { get; set; }
    }
}
