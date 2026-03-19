// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Cartes Bancaires-specific 3DS fields.
        /// </summary>
        [JsonProperty("cartes_bancaires")]
        [STJS.JsonPropertyName("cartes_bancaires")]
        public PaymentIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsCartesBancairesOptions CartesBancaires { get; set; }
    }
}
