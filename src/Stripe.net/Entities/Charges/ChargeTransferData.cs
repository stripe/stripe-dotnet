namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargeTransferData : StripeEntity<ChargeTransferData>
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        #region Expandable Destination (Account)
        [JsonIgnore]
        public string DestinationId => this.InternalDestination.Id;

        [JsonIgnore]
        public Account Destination => this.InternalDestination.ExpandedObject;

        [JsonProperty("destination")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalDestination { get; set; }
        #endregion
    }
}
