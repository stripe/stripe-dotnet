namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TopupListOptions : ListOptionsWithCreated
    {
        [JsonProperty("amount")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Amount { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
