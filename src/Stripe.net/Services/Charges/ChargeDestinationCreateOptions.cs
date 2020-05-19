namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargeDestinationCreateOptions : ChargeDestinationOptions
    {
        [JsonProperty("account")]
        public string Account { get; set; }
    }
}
