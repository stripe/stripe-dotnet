// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoicePaymentSettingsPaymentMethodOptionsUsBankAccount : StripeEntity<InvoicePaymentSettingsPaymentMethodOptionsUsBankAccount>
    {
        [JsonProperty("financial_connections")]
        [STJS.JsonPropertyName("financial_connections")]
        public InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections FinancialConnections { get; set; }

        /// <summary>
        /// Bank account verification method. The default value is <c>automatic</c>.
        /// One of: <c>automatic</c>, <c>instant</c>, or <c>microdeposits</c>.
        /// </summary>
        [JsonProperty("verification_method")]
        [STJS.JsonPropertyName("verification_method")]
        public string VerificationMethod { get; set; }
    }
}
