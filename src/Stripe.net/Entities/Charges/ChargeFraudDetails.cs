namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargeFraudDetails : StripeEntity<ChargeFraudDetails>
    {
        [JsonProperty("stripe_report")]
        public string StripeReport { get; set; }

        [JsonProperty("user_report")]
        public string UserReport { get; set; }
    }
}
