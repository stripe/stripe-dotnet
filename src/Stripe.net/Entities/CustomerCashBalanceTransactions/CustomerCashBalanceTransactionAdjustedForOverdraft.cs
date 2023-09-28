// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CustomerCashBalanceTransactionAdjustedForOverdraft : StripeEntity<CustomerCashBalanceTransactionAdjustedForOverdraft>
    {
        #region Expandable BalanceTransaction

        /// <summary>
        /// (ID of the BalanceTransaction)
        /// The <a href="https://stripe.com/docs/api/balance_transactions/object">Balance
        /// Transaction</a> that corresponds to funds taken out of your Stripe balance.
        /// </summary>
        [JsonIgnore]
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
        public BalanceTransaction BalanceTransaction
        {
            get => this.InternalBalanceTransaction?.ExpandedObject;
            set => this.InternalBalanceTransaction = SetExpandableFieldObject(value, this.InternalBalanceTransaction);
        }

        [JsonProperty("balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
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
        public CustomerCashBalanceTransaction LinkedTransaction
        {
            get => this.InternalLinkedTransaction?.ExpandedObject;
            set => this.InternalLinkedTransaction = SetExpandableFieldObject(value, this.InternalLinkedTransaction);
        }

        [JsonProperty("linked_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<CustomerCashBalanceTransaction>))]
        internal ExpandableField<CustomerCashBalanceTransaction> InternalLinkedTransaction { get; set; }
        #endregion
    }
}
