namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceTransferData : StripeEntity<InvoiceTransferData>
    {
        /// <summary>
        /// The amount that will be transferred automatically when the invoice is paid. If no amount
        /// is set, the full amount is transferred.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        #region Expandable Destination (Account)

        /// <summary>
        /// The ID of the account where funds from the payment will be transferred to upon payment
        /// success.
        /// </summary>
        [JsonIgnore]
        public string DestinationId
        {
            get => this.InternalDestination?.Id;
            set => this.InternalDestination = SetExpandableFieldId(value, this.InternalDestination);
        }

        /// <summary>
        /// (Expanded) The account where funds from the payment will be transferred to upon payment
        /// success.
        /// </summary>
        [JsonIgnore]
        public Account Destination
        {
            get => this.InternalDestination?.ExpandedObject;
            set => this.InternalDestination = SetExpandableFieldObject(value, this.InternalDestination);
        }

        [JsonProperty("destination")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalDestination { get; set; }
        #endregion
    }
}
