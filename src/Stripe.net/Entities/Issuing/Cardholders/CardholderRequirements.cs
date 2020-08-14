namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardholderRequirements : StripeEntity<CardholderRequirements>
    {
        [JsonProperty("disabled_reason")]
        public string DisabledReason { get; set; }

        [JsonProperty("past_due")]
        public List<string> PastDue { get; set; }
    }
}
