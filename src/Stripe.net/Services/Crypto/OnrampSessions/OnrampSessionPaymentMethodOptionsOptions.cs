// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OnrampSessionPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Configuration for any card payments attempted during checkout.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public OnrampSessionPaymentMethodOptionsCardOptions Card { get; set; }
    }
}
