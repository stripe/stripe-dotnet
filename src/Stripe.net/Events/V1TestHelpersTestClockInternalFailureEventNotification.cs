// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a test clock fails to advance its frozen time.
    /// </summary>
    public class V1TestHelpersTestClockInternalFailureEventNotification : V2.EventNotification
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.EventNotificationRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>
        public Task<TestHelpers.TestClock> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<TestHelpers.TestClock>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public TestHelpers.TestClock FetchRelatedObject()
        {
            return this.FetchRelatedObject<TestHelpers.TestClock>(this.RelatedObject);
        }

        public V1TestHelpersTestClockInternalFailureEvent FetchEvent()
        {
            return this.FetchEvent<V1TestHelpersTestClockInternalFailureEvent>();
        }

        public Task<V1TestHelpersTestClockInternalFailureEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1TestHelpersTestClockInternalFailureEvent>();
        }
    }
}
