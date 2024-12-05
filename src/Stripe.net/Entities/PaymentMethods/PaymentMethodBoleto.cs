// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodBoleto : StripeEntity<PaymentMethodBoleto>
    {
        /// <summary>
        /// Uniquely identifies the customer tax id (CNPJ or CPF).
        /// </summary>
        [JsonProperty("tax_id")]
        public string TaxId { get; set; }
    }
}
