// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentLocationBusinessRegistration : StripeEntity<PaymentLocationBusinessRegistration>
    {
        /// <summary>
        /// 14-digit SIRET (Système d'identification du répertoire des établissements) number for
        /// the location.
        /// </summary>
        [JsonProperty("siret")]
        [STJS.JsonPropertyName("siret")]
        public string Siret { get; set; }
    }
}
