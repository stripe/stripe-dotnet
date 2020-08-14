namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class EventData : StripeEntity<EventData>
    {
        [JsonProperty("object")]
        [JsonConverter(typeof(StripeObjectConverter))]
        public IHasObject Object { get; set; }

        [JsonProperty("previous_attributes")]
        public dynamic PreviousAttributes { get; set; }

        [JsonIgnore]
        public dynamic RawObject { get; set; }
    }
}
