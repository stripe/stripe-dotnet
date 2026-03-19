// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentMethodBoleto : StripeEntity<PaymentMethodBoleto>
    {
        /// <summary>
        /// Uniquely identifies the customer tax id (CNPJ or CPF).
        /// </summary>
        [JsonProperty("tax_id")]
        [STJS.JsonPropertyName("tax_id")]
        public string TaxId { get; set; }
    }
}
