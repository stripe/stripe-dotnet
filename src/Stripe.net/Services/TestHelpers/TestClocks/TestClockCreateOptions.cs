// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TestClockCreateOptions : BaseOptions
    {
        /// <summary>
        /// The initial frozen time for this test clock.
        /// </summary>
        [JsonProperty("frozen_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("frozen_time")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? FrozenTime { get; set; }

        /// <summary>
        /// The name for this test clock.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
