namespace Stripe.V2
{
    using System;
    using System.Diagnostics.CodeAnalysis;
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

        public V2.Event FetchEvent()
        {
            return this.FetchEvent<V2.Event>();
        }

        public Task<V2.Event> FetchEventAsync(CancellationToken cancellationToken = default)
        {
            return this.FetchEventAsync<V2.Event>(cancellationToken);
        }

        [return: MaybeNull]
        public T FetchRelatedObject<T>()
            where T : IStripeEntity
        {
            if (this.RelatedObject == null)
            {
                return default;
            }

            return this.FetchRelatedObject<T>(this.RelatedObject);
        }

        [return: MaybeNull]
        public Task<T> FetchRelatedObjectAsync<T>()
            where T : IStripeEntity
        {
            if (this.RelatedObject == null)
            {
                return default;
            }

            return this.FetchRelatedObjectAsync<T>(this.RelatedObject);
        }
    }
}
