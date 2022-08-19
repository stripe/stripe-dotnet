// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CustomerCashBalanceTransactionRefundedFromPayment : StripeEntity<CustomerCashBalanceTransactionRefundedFromPayment>
    {
        #region Expandable Refund

        /// <summary>
        /// (ID of the Refund)
        /// The <a href="https://stripe.com/docs/api/refunds/object">Refund</a> that moved these
        /// funds into the customer's cash balance.
        /// </summary>
        [JsonIgnore]
        public string RefundId
        {
            get => this.InternalRefund?.Id;
            set => this.InternalRefund = SetExpandableFieldId(value, this.InternalRefund);
        }

        /// <summary>
        /// (Expanded)
        /// The <a href="https://stripe.com/docs/api/refunds/object">Refund</a> that moved these
        /// funds into the customer's cash balance.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Refund Refund
        {
            get => this.InternalRefund?.ExpandedObject;
            set => this.InternalRefund = SetExpandableFieldObject(value, this.InternalRefund);
        }

        [JsonProperty("refund")]
        [JsonConverter(typeof(ExpandableFieldConverter<Refund>))]
        internal ExpandableField<Refund> InternalRefund { get; set; }
        #endregion
    }
}
