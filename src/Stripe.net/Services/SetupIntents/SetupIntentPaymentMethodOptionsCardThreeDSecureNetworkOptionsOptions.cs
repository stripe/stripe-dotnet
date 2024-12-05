// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Cartes Bancaires-specific 3DS fields.
        /// </summary>
        [JsonProperty("cartes_bancaires")]
        public SetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsCartesBancairesOptions CartesBancaires { get; set; }
    }
}
