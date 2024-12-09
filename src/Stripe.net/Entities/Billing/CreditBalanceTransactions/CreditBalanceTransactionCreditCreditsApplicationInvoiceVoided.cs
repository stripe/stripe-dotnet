// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CreditBalanceTransactionCreditCreditsApplicationInvoiceVoided : StripeEntity<CreditBalanceTransactionCreditCreditsApplicationInvoiceVoided>
    {
        #region Expandable Invoice

        /// <summary>
        /// (ID of the Invoice)
        /// The invoice to which the reinstated billing credits were originally applied.
        /// </summary>
        [JsonIgnore]
        public string InvoiceId
        {
            get => this.InternalInvoice?.Id;
            set => this.InternalInvoice = SetExpandableFieldId(value, this.InternalInvoice);
        }

        /// <summary>
        /// (Expanded)
        /// The invoice to which the reinstated billing credits were originally applied.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Invoice Invoice
        {
            get => this.InternalInvoice?.ExpandedObject;
            set => this.InternalInvoice = SetExpandableFieldObject(value, this.InternalInvoice);
        }

        [JsonProperty("invoice")]
        [JsonConverter(typeof(ExpandableFieldConverter<Invoice>))]
        internal ExpandableField<Invoice> InternalInvoice { get; set; }
        #endregion

        /// <summary>
        /// The invoice line item to which the reinstated billing credits were originally applied.
        /// </summary>
        [JsonProperty("invoice_line_item")]
        public string InvoiceLineItem { get; set; }
    }
}
