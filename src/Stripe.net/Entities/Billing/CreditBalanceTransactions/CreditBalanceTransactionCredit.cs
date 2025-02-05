// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class CreditBalanceTransactionCredit : StripeEntity<CreditBalanceTransactionCredit>
    {
        [JsonProperty("amount")]
        public CreditBalanceTransactionCreditAmount Amount { get; set; }

        /// <summary>
        /// Details of the invoice to which the reinstated credits were originally applied. Only
        /// present if <c>type</c> is <c>credits_application_invoice_voided</c>.
        /// </summary>
        [JsonProperty("credits_application_invoice_voided")]
        public CreditBalanceTransactionCreditCreditsApplicationInvoiceVoided CreditsApplicationInvoiceVoided { get; set; }

        /// <summary>
        /// The type of credit transaction.
        /// One of: <c>credits_application_invoice_voided</c>, or <c>credits_granted</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
