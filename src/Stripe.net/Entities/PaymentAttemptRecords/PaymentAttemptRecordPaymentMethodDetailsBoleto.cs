// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentAttemptRecordPaymentMethodDetailsBoleto : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsBoleto>
    {
        /// <summary>
        /// The tax ID of the customer (CPF for individuals consumers or CNPJ for businesses
        /// consumers).
        /// </summary>
        [JsonProperty("tax_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_id")]
#endif
        public string TaxId { get; set; }
    }
}
