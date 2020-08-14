namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargeFraudDetailsOptions : INestedOptions
    {
        [JsonProperty("user_report")]
        public string UserReport { get; set; }
    }
}
