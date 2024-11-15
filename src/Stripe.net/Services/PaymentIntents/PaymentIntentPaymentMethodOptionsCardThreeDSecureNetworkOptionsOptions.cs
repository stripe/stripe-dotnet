// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Cartes Bancaires-specific 3DS fields.
        /// </summary>
        [JsonProperty("cartes_bancaires")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cartes_bancaires")]
#endif

        public PaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsCartesBancairesOptions CartesBancaires { get; set; }
    }
}
