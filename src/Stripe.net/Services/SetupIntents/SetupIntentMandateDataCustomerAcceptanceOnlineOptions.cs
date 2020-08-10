namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentMandateDataCustomerAcceptanceOnlineOptions : INestedOptions
    {
        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }
    }
}
