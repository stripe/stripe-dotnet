namespace Stripe
{
    using Newtonsoft.Json;

    public class Requirements : StripeEntity
    {
        [JsonProperty("currently_due")]
        public string[] CurrentlyDue { get; set; }

        [JsonProperty("eventually_due")]
        public string[] EventuallyDue { get; set; }

        [JsonProperty("past_due")]
        public string[] PastDue { get; set; }
    }
}
