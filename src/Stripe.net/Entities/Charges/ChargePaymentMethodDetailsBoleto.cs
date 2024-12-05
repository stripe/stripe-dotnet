// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsBoleto : StripeEntity<ChargePaymentMethodDetailsBoleto>
    {
        /// <summary>
        /// The tax ID of the customer (CPF for individuals consumers or CNPJ for businesses
        /// consumers).
        /// </summary>
        [JsonProperty("tax_id")]
        public string TaxId { get; set; }
    }
}
