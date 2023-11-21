// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// Customers with certain payments enabled have a cash balance, representing funds that
    /// were paid by the customer to a merchant, but have not yet been allocated to a payment.
    /// Cash Balance Transactions represent when funds are moved into or out of this balance.
    /// This includes funding by the customer, allocation to payments, and refunds to the
    /// customer.
    /// </summary>
    public class CustomerCashBalanceTransaction : StripeEntity<CustomerCashBalanceTransaction>, IHasId, IHasObject, IBalanceTransactionSource
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("adjusted_for_overdraft")]
        public CustomerCashBalanceTransactionAdjustedForOverdraft AdjustedForOverdraft { get; set; }

        [JsonProperty("applied_to_payment")]
        public CustomerCashBalanceTransactionAppliedToPayment AppliedToPayment { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The customer whose available cash balance changed as a result of this transaction.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// The customer whose available cash balance changed as a result of this transaction.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        /// <summary>
        /// The total available cash balance for the specified currency after this transaction was
        /// applied. Represented in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("ending_balance")]
        public long EndingBalance { get; set; }

        [JsonProperty("funded")]
        public CustomerCashBalanceTransactionFunded Funded { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The amount by which the cash balance changed, represented in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>. A
        /// positive value represents funds being added to the cash balance, a negative value
        /// represents funds being removed from the cash balance.
        /// </summary>
        [JsonProperty("net_amount")]
        public long NetAmount { get; set; }

        [JsonProperty("refunded_from_payment")]
        public CustomerCashBalanceTransactionRefundedFromPayment RefundedFromPayment { get; set; }

        [JsonProperty("transferred_to_balance")]
        public CustomerCashBalanceTransactionTransferredToBalance TransferredToBalance { get; set; }

        /// <summary>
        /// The type of the cash balance transaction. New types may be added in future. See <a
        /// href="https://stripe.com/docs/payments/customer-balance#types">Customer Balance</a> to
        /// learn more about these types.
        /// One of: <c>adjusted_for_overdraft</c>, <c>applied_to_payment</c>, <c>funded</c>,
        /// <c>funding_reversed</c>, <c>refunded_from_payment</c>, <c>return_canceled</c>,
        /// <c>return_initiated</c>, <c>transferred_to_balance</c>, or
        /// <c>unapplied_from_payment</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("unapplied_from_payment")]
        public CustomerCashBalanceTransactionUnappliedFromPayment UnappliedFromPayment { get; set; }
    }
}
