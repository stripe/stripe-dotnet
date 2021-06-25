// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodBoletoOptions : INestedOptions
    {
        /// <summary>
        /// Uniquely identifies this customer tax_id (CNPJ or CPF).
        /// </summary>
        [JsonProperty("tax_id")]
        public string TaxId { get; set; }
    }
}
