namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class EventData : StripeEntity
    {
        [JsonProperty("object")]
        [JsonConverter(typeof(StripeObjectConverter))]
        public IHasObject Object { get; set; }

        [JsonProperty("previous_attributes")]
        public dynamic PreviousAttributes { get; set; }
    }
}
