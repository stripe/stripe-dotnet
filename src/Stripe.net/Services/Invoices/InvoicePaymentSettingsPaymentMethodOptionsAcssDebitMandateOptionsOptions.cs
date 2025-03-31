// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoicePaymentSettingsPaymentMethodOptionsAcssDebitMandateOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Transaction type of the mandate.
        /// One of: <c>business</c>, or <c>personal</c>.
        /// </summary>
        [JsonProperty("transaction_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction_type")]
#endif
        public string TransactionType { get; set; }
    }
}
