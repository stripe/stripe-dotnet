namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class Requirements : StripeEntity
    {
        [JsonProperty("currently_due")]
        public List<string> CurrentlyDue { get; set; }

        [JsonProperty("eventually_due")]
        public List<string> EventuallyDue { get; set; }

        [JsonProperty("past_due")]
        public List<string> PastDue { get; set; }
    }
}
