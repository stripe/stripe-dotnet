// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class TestClockCreateOptions : BaseOptions
    {
        /// <summary>
        /// The initial frozen time for this test clock.
        /// </summary>
        [JsonProperty("frozen_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? FrozenTime { get; set; }

        /// <summary>
        /// The name for this test clock.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
