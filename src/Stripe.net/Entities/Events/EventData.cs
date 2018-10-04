namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class EventData : StripeEntity
    {
        [JsonProperty("object")]
        public IHasObject Object { get; set; }

        [JsonProperty("previous_attributes")]
        public dynamic PreviousAttributes { get; set; }
    }
}
