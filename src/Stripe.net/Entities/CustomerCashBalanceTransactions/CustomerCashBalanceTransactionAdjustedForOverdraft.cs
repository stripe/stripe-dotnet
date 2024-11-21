// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerCashBalanceTransactionAdjustedForOverdraft : StripeEntity<CustomerCashBalanceTransactionAdjustedForOverdraft>
    {
        #region Expandable BalanceTransaction

        /// <summary>
        /// (ID of the BalanceTransaction)
        /// The <a href="https://stripe.com/docs/api/balance_transactions/object">Balance
        /// Transaction</a> that corresponds to funds taken out of your Stripe balance.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public string BalanceTransactionId
        {
            get => this.InternalBalanceTransaction?.Id;
            set => this.InternalBalanceTransaction = SetExpandableFieldId(value, this.InternalBalanceTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// The <a href="https://stripe.com/docs/api/balance_transactions/object">Balance
        /// Transaction</a> that corresponds to funds taken out of your Stripe balance.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public BalanceTransaction BalanceTransaction
        {
            get => this.InternalBalanceTransaction?.ExpandedObject;
            set => this.InternalBalanceTransaction = SetExpandableFieldObject(value, this.InternalBalanceTransaction);
        }

        [JsonProperty("balance_transaction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("balance_transaction")]
        [STJS.JsonInclude]
#endif

        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<BalanceTransaction>))]
#endif

        internal ExpandableField<BalanceTransaction> InternalBalanceTransaction { get; set; }
        #endregion

        #region Expandable LinkedTransaction

        /// <summary>
        /// (ID of the CustomerCashBalanceTransaction)
        /// The <a href="https://stripe.com/docs/api/cash_balance_transactions/object">Cash Balance
        /// Transaction</a> that brought the customer balance negative, triggering the clawback of
        /// funds.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public string LinkedTransactionId
        {
            get => this.InternalLinkedTransaction?.Id;
            set => this.InternalLinkedTransaction = SetExpandableFieldId(value, this.InternalLinkedTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// The <a href="https://stripe.com/docs/api/cash_balance_transactions/object">Cash Balance
        /// Transaction</a> that brought the customer balance negative, triggering the clawback of
        /// funds.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public CustomerCashBalanceTransaction LinkedTransaction
        {
            get => this.InternalLinkedTransaction?.ExpandedObject;
            set => this.InternalLinkedTransaction = SetExpandableFieldObject(value, this.InternalLinkedTransaction);
        }

        [JsonProperty("linked_transaction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("linked_transaction")]
        [STJS.JsonInclude]
#endif

        [JsonConverter(typeof(ExpandableFieldConverter<CustomerCashBalanceTransaction>))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<CustomerCashBalanceTransaction>))]
#endif

        internal ExpandableField<CustomerCashBalanceTransaction> InternalLinkedTransaction { get; set; }
        #endregion
    }
}
