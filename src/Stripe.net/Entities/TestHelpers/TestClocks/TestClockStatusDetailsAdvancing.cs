// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TestClockStatusDetailsAdvancing : StripeEntity<TestClockStatusDetailsAdvancing>
    {
        /// <summary>
        /// The <c>frozen_time</c> that the Test Clock is advancing towards.
        /// </summary>
        [JsonProperty("target_frozen_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("target_frozen_time")]
#endif

        public DateTime TargetFrozenTime { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
