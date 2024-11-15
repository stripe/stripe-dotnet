// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TestClockAdvanceOptions : BaseOptions
    {
        /// <summary>
        /// The time to advance the test clock. Must be after the test clock's current frozen time.
        /// Cannot be more than two intervals in the future from the shortest subscription in this
        /// test clock. If there are no subscriptions in this test clock, it cannot be more than two
        /// years in the future.
        /// </summary>
        [JsonProperty("frozen_time")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("frozen_time")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? FrozenTime { get; set; }
    }
}
