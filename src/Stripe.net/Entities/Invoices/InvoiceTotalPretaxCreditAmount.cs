// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceTotalPretaxCreditAmount : StripeEntity<InvoiceTotalPretaxCreditAmount>
    {
        /// <summary>
        /// The amount, in cents (or local equivalent), of the pretax credit amount.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        #region Expandable CreditBalanceTransaction

        /// <summary>
        /// (ID of the Billing.CreditBalanceTransaction)
        /// The credit balance transaction that was applied to get this pretax credit amount.
        /// </summary>
        [JsonIgnore]
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
        public Billing.CreditBalanceTransaction CreditBalanceTransaction
        {
            get => this.InternalCreditBalanceTransaction?.ExpandedObject;
            set => this.InternalCreditBalanceTransaction = SetExpandableFieldObject(value, this.InternalCreditBalanceTransaction);
        }

        [JsonProperty("credit_balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<Billing.CreditBalanceTransaction>))]
        internal ExpandableField<Billing.CreditBalanceTransaction> InternalCreditBalanceTransaction { get; set; }
        #endregion

        #region Expandable Discount

        /// <summary>
        /// (ID of the Discount)
        /// The discount that was applied to get this pretax credit amount.
        /// </summary>
        [JsonIgnore]
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
        public Discount Discount
        {
            get => this.InternalDiscount?.ExpandedObject;
            set => this.InternalDiscount = SetExpandableFieldObject(value, this.InternalDiscount);
        }

        [JsonProperty("discount")]
        [JsonConverter(typeof(ExpandableFieldConverter<Discount>))]
        internal ExpandableField<Discount> InternalDiscount { get; set; }
        #endregion

        #region Expandable Margin

        /// <summary>
        /// (ID of the Margin)
        /// The margin that was applied to get this pretax credit amount.
        /// </summary>
        [JsonIgnore]
        public string MarginId
        {
            get => this.InternalMargin?.Id;
            set => this.InternalMargin = SetExpandableFieldId(value, this.InternalMargin);
        }

        /// <summary>
        /// (Expanded)
        /// The margin that was applied to get this pretax credit amount.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Margin Margin
        {
            get => this.InternalMargin?.ExpandedObject;
            set => this.InternalMargin = SetExpandableFieldObject(value, this.InternalMargin);
        }

        [JsonProperty("margin")]
        [JsonConverter(typeof(ExpandableFieldConverter<Margin>))]
        internal ExpandableField<Margin> InternalMargin { get; set; }
        #endregion

        /// <summary>
        /// Type of the pretax credit amount referenced.
        /// One of: <c>credit_balance_transaction</c>, <c>discount</c>, or <c>margin</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
