// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Cartes Bancaires-specific 3DS fields.
        /// </summary>
        [JsonProperty("cartes_bancaires")]
        public PaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsCartesBancairesOptions CartesBancaires { get; set; }
    }
}
