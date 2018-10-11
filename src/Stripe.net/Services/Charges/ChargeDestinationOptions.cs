namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargeDestinationOptions : INestedOptions
    {
        /// <summary>
        /// The amount to transfer to the destination account.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }
    }
}
