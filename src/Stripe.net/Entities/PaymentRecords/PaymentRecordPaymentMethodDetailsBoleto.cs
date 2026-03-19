// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentRecordPaymentMethodDetailsBoleto : StripeEntity<PaymentRecordPaymentMethodDetailsBoleto>
    {
        /// <summary>
        /// The tax ID of the customer (CPF for individuals consumers or CNPJ for businesses
        /// consumers).
        /// </summary>
        [JsonProperty("tax_id")]
        [STJS.JsonPropertyName("tax_id")]
        public string TaxId { get; set; }
    }
}
