// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentLinkTransferData : StripeEntity<PaymentLinkTransferData>
    {
        /// <summary>
        /// The amount in cents (or local equivalent) that will be transferred to the destination
        /// account. By default, the entire amount is transferred to the destination.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        #region Expandable Destination

        /// <summary>
        /// (ID of the Account)
        /// The connected account receiving the transfer.
        /// </summary>
        [JsonIgnore]
        public string DestinationId
        {
            get => this.InternalDestination?.Id;
            set => this.InternalDestination = SetExpandableFieldId(value, this.InternalDestination);
        }

        /// <summary>
        /// (Expanded)
        /// The connected account receiving the transfer.
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
