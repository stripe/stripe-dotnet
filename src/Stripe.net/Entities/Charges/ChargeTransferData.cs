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
        public string DestinationId { get; set; }

        [JsonIgnore]
        public Account Destination { get; set; }

        [JsonProperty("destination")]
        internal object InternalDestination
        {
            get
            {
                return this.Destination ?? (object)this.DestinationId;
            }

            set
            {
                StringOrObject<Account>.Map(value, s => this.DestinationId = s, o => this.Destination = o);
            }
        }
        #endregion
    }
}
