// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TestClockStatusDetailsAdvancing : StripeEntity<TestClockStatusDetailsAdvancing>
    {
        /// <summary>
        /// The <c>frozen_time</c> that the Test Clock is advancing towards.
        /// </summary>
        [JsonProperty("target_frozen_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime TargetFrozenTime { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
