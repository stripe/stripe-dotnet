// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentMethodDetailsKonbiniStore : StripeEntity<ChargePaymentMethodDetailsKonbiniStore>
    {
        /// <summary>
        /// The name of the convenience store chain where the payment was completed.
        /// One of: <c>familymart</c>, <c>lawson</c>, <c>ministop</c>, or <c>seicomart</c>.
        /// </summary>
        [JsonProperty("chain")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("chain")]
#endif
        public string Chain { get; set; }
    }
}
