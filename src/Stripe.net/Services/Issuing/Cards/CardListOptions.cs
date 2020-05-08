namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardListOptions : ListOptionsWithCreated
    {
        [JsonProperty("cardholder")]
        public string Cardholder { get; set; }

        [JsonProperty("exp_month")]
        public long? ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public long? ExpYear { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
