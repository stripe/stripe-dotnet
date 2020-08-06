namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionSchedulePhaseTransferDataOptions : INestedOptions
    {
        [JsonProperty("amount_percent")]
        public decimal? AmountPercent { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
}
