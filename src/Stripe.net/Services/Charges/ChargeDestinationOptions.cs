namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargeDestinationOptions : INestedOptions
    {
        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("amount")]
        public long? Amount { get; set; }
    }
}
