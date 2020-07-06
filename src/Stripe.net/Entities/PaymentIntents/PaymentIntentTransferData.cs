namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentTransferData : StripeEntity<PaymentIntentTransferData>
    {
        /// <summary>
        /// The amount transferred to the destination account, if specified. By default, the entire
        /// charge amount is transferred to the destination account.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        #region Expandable Destination

        /// <summary>
        /// ID of the account (if any) the payment will be attributed to for tax reporting, and
        /// where funds from the payment will be transferred to upon payment success.
        /// </summary>
        [JsonIgnore]
        public string DestinationId
        {
            get => this.InternalDestination?.Id;
            set => this.InternalDestination = SetExpandableFieldId(value, this.InternalDestination);
        }

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
