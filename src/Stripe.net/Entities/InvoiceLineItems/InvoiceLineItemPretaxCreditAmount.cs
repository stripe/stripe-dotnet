// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceLineItemPretaxCreditAmount : StripeEntity<InvoiceLineItemPretaxCreditAmount>
    {
        /// <summary>
        /// The amount, in cents (or local equivalent), of the pretax credit amount.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        #region Expandable CreditBalanceTransaction

        /// <summary>
        /// (ID of the Billing.CreditBalanceTransaction)
        /// The credit balance transaction that was applied to get this pretax credit amount.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string CreditBalanceTransactionId
        {
            get => this.InternalCreditBalanceTransaction?.Id;
            set => this.InternalCreditBalanceTransaction = SetExpandableFieldId(value, this.InternalCreditBalanceTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// The credit balance transaction that was applied to get this pretax credit amount.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Billing.CreditBalanceTransaction CreditBalanceTransaction
        {
            get => this.InternalCreditBalanceTransaction?.ExpandedObject;
            set => this.InternalCreditBalanceTransaction = SetExpandableFieldObject(value, this.InternalCreditBalanceTransaction);
        }

        [JsonProperty("credit_balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<Billing.CreditBalanceTransaction>))]
        [STJS.JsonPropertyName("credit_balance_transaction")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Billing.CreditBalanceTransaction>))]
        internal ExpandableField<Billing.CreditBalanceTransaction> InternalCreditBalanceTransaction { get; set; }
        #endregion

        #region Expandable Discount

        /// <summary>
        /// (ID of the Discount)
        /// The discount that was applied to get this pretax credit amount.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string DiscountId
        {
            get => this.InternalDiscount?.Id;
            set => this.InternalDiscount = SetExpandableFieldId(value, this.InternalDiscount);
        }

        /// <summary>
        /// (Expanded)
        /// The discount that was applied to get this pretax credit amount.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Discount Discount
        {
            get => this.InternalDiscount?.ExpandedObject;
            set => this.InternalDiscount = SetExpandableFieldObject(value, this.InternalDiscount);
        }

        [JsonProperty("discount")]
        [JsonConverter(typeof(ExpandableFieldConverter<Discount>))]
        [STJS.JsonPropertyName("discount")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Discount>))]
        internal ExpandableField<Discount> InternalDiscount { get; set; }
        #endregion

        /// <summary>
        /// Type of the pretax credit amount referenced.
        /// One of: <c>credit_balance_transaction</c>, or <c>discount</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
