// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentMethodDetailsKlarnaPayerDetailsAddress : StripeEntity<ChargePaymentMethodDetailsKlarnaPayerDetailsAddress>
    {
        /// <summary>
        /// The payer address country.
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif

        public string Country { get; set; }
    }
}
