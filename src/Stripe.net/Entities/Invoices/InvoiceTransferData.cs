namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceTransferData : StripeEntity<InvoiceTransferData>
    {
        #region Expandable Destination (Account)
        [JsonIgnore]
        public string DestinationId
        {
            get => this.InternalDestination.Id;
            set => this.InternalDestination.Id = value;
        }

        [JsonIgnore]
        public Account Destination
        {
            get => this.InternalDestination.ExpandedObject;
            set => this.InternalDestination.ExpandedObject = value;
        }

        [JsonProperty("destination")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalDestination { get; set; }
        #endregion
    }
}
