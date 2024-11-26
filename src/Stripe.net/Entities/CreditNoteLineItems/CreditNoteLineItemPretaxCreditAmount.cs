// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditNoteLineItemPretaxCreditAmount : StripeEntity<CreditNoteLineItemPretaxCreditAmount>
    {
        /// <summary>
        /// The amount, in cents (or local equivalent), of the pretax credit amount.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        #region Expandable CreditBalanceTransaction

        /// <summary>
        /// (ID of the Billing.CreditBalanceTransaction)
        /// The credit balance transaction that was applied to get this pretax credit amount.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Billing.CreditBalanceTransaction CreditBalanceTransaction
        {
            get => this.InternalCreditBalanceTransaction?.ExpandedObject;
            set => this.InternalCreditBalanceTransaction = SetExpandableFieldObject(value, this.InternalCreditBalanceTransaction);
        }

        [JsonProperty("credit_balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<Billing.CreditBalanceTransaction>))]
#if NET6_0_OR_GREATER
        [STJS.JsonInclude]
        [STJS.JsonPropertyName("credit_balance_transaction")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Billing.CreditBalanceTransaction>))]
#endif
        internal ExpandableField<Billing.CreditBalanceTransaction> InternalCreditBalanceTransaction { get; set; }
        #endregion

        #region Expandable Discount

        /// <summary>
        /// (ID of the Discount)
        /// The discount that was applied to get this pretax credit amount.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Discount Discount
        {
            get => this.InternalDiscount?.ExpandedObject;
            set => this.InternalDiscount = SetExpandableFieldObject(value, this.InternalDiscount);
        }

        [JsonProperty("discount")]
        [JsonConverter(typeof(ExpandableFieldConverter<Discount>))]
#if NET6_0_OR_GREATER
        [STJS.JsonInclude]
        [STJS.JsonPropertyName("discount")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Discount>))]
#endif
        internal ExpandableField<Discount> InternalDiscount { get; set; }
        #endregion

        /// <summary>
        /// Type of the pretax credit amount referenced.
        /// One of: <c>credit_balance_transaction</c>, or <c>discount</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
