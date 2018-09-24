namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentTransferData : StripeEntity
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        #region Expandable Destination (Account)
        public string DestinationId { get; set; }

        [JsonIgnore]
        public StripeAccount Destination { get; set; }

        [JsonProperty("destination")]
        internal object InternalDestination
        {
            set
            {
                StringOrObject<StripeAccount>.Map(value, s => this.DestinationId = s, o => this.Destination = o);
            }
        }
        #endregion
    }
}
