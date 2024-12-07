namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class EventData : StripeEntity<EventData>
    {
        /// <summary>
        /// Object containing the API resource relevant to the event. For example, an
        /// <c>invoice.created</c> event will have a full invoice object (<see cref="Invoice"/>) as
        /// the value of the object key.
        /// </summary>
        [JsonProperty("object")]
        [JsonConverter(typeof(StripeObjectConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public IHasObject Object { get; set; }

        /// <summary>
        /// Object containing the names of the attributes that have changed, and their previous
        /// values (sent along only with *.updated events).
        /// </summary>
        [JsonProperty("previous_attributes")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("previous_attributes")]
#endif
        public dynamic PreviousAttributes { get; set; }

        /// <summary>
        /// This contains the same data as <see cref="EventData.Object"/>, but untyped. This is
        /// occasionally useful, e.g. when working with an API resource for which the Stripe.net
        /// library does not have a concrete type.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public dynamic RawObject { get; set; }
    }
}
