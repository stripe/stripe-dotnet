// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentMethodDetailsKonbini : StripeEntity<ChargePaymentMethodDetailsKonbini>
    {
        /// <summary>
        /// If the payment succeeded, this contains the details of the convenience store where the
        /// payment was completed.
        /// </summary>
        [JsonProperty("store")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("store")]
#endif

        public ChargePaymentMethodDetailsKonbiniStore Store { get; set; }
    }
}
