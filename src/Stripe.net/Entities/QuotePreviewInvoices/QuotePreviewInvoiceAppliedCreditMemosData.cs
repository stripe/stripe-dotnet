// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuotePreviewInvoiceAppliedCreditMemosData : StripeEntity<QuotePreviewInvoiceAppliedCreditMemosData>
    {
        /// <summary>
        /// The credit currently applied to this invoice from the Credit Memo, in cents (or local
        /// equivalent). Applying credit reduces <c>amount_due</c> and <c>amount_remaining</c>
        /// without changing <c>amount_paid</c>.
        /// </summary>
        [JsonProperty("applied_amount")]
        [STJS.JsonPropertyName("applied_amount")]
        public long AppliedAmount { get; set; }

        /// <summary>
        /// The ID of the Credit Memo whose credit is applied to this invoice.
        /// </summary>
        [JsonProperty("credit_memo")]
        [STJS.JsonPropertyName("credit_memo")]
        public string CreditMemo { get; set; }
    }
}
