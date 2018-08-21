namespace Stripe
{
    using Newtonsoft.Json;

    public class EventData : StripeEntity
    {
        [JsonProperty("object")]
        public dynamic Object { get; set; }

        [JsonProperty("previous_attributes")]
        public dynamic PreviousAttributes { get; set; }
    }
}
