// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class OrderPaymentSettingsTransferData : StripeEntity<OrderPaymentSettingsTransferData>
    {
        /// <summary>
        /// The amount that will be transferred automatically when the order is paid. If no amount
        /// is set, the full amount is transferred. There cannot be any line items with recurring
        /// prices when using this field.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        #region Expandable Destination

        /// <summary>
        /// (ID of the Account)
        /// ID of the Connected account receiving the transfer.
        /// </summary>
        [JsonIgnore]
        public string DestinationId
        {
            get => this.InternalDestination?.Id;
            set => this.InternalDestination = SetExpandableFieldId(value, this.InternalDestination);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the Connected account receiving the transfer.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
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
