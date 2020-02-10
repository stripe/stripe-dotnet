namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargeDestinationOptions : INestedOptions
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }
    }
}
