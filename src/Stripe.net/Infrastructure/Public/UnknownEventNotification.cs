namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Represents an EventNotification that is valid, but that the SDK doesn't have types for. May have a RelatedObject and can be used to fetch the corresponding full event.
    /// </summary>
    public class UnknownEventNotification : EventNotification
    {
#nullable enable
        /// <summary>
        /// [Optional] Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif
        public EventNotificationRelatedObject? RelatedObject { get; internal set; }

        public new V2.Event FetchEvent()
        {
            return base.FetchEvent();
        }

        public new Task<V2.Event> FetchEventAsync(CancellationToken cancellationToken = default)
        {
            return base.FetchEventAsync(cancellationToken);
        }

        // TODO: fetchRelatedObject
    }
}
