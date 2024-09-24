namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// A pushed thin event.  Use this the Id with the <see cref="Stripe.V2.Core.EventService"/>
    /// exposed via <see cref="StripeClient"/> to fetch the full event.
    /// </summary>
    public class ThinEvent
    {
        [JsonProperty("id")]
        public string Id { get; internal set; }

        [JsonProperty("type")]
        public string Type { get; internal set; }

        [JsonProperty("created")]
        public DateTime Created { get; internal set; }

#nullable enable
        [JsonProperty("context")]
        public string? Context { get; internal set; }

        [JsonProperty("related_object")]
        public ThinEventRelatedObject? RelatedObject { get; internal set; }
    }
}
