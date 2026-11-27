// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OnrampSessionPaymentMethodOptionsCardOptions : INestedOptions
    {
        /// <summary>
        /// Network token specific transaction options.
        /// </summary>
        [JsonProperty("network_token")]
        [STJS.JsonPropertyName("network_token")]
        public OnrampSessionPaymentMethodOptionsCardNetworkTokenOptions NetworkToken { get; set; }
    }
}
