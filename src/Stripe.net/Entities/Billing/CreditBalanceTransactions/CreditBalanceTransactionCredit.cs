// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditBalanceTransactionCredit : StripeEntity<CreditBalanceTransactionCredit>
    {
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public CreditBalanceTransactionCreditAmount Amount { get; set; }

        /// <summary>
        /// Details of the invoice to which the reinstated credits were originally applied. Only
        /// present if <c>type</c> is <c>credits_application_invoice_voided</c>.
        /// </summary>
        [JsonProperty("credits_application_invoice_voided")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credits_application_invoice_voided")]
#endif
        public CreditBalanceTransactionCreditCreditsApplicationInvoiceVoided CreditsApplicationInvoiceVoided { get; set; }

        /// <summary>
        /// The type of credit transaction.
        /// One of: <c>credits_application_invoice_voided</c>, or <c>credits_granted</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
