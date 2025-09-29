// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a test clock fails to advance its frozen time.
    /// </summary>
    public class V1TestHelpersTestClockInternalFailureEvent : V2.Core.Event
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.Core.EventRelatedObject RelatedObject { get; set; }

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
    }
}
