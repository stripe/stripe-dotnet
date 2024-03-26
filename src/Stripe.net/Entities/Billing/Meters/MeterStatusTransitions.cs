// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class MeterStatusTransitions : StripeEntity<MeterStatusTransitions>
    {
        /// <summary>
        /// The time the meter was deactivated, if any. Measured in seconds since Unix epoch.
        /// </summary>
        [JsonProperty("deactivated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? DeactivatedAt { get; set; }
    }
}
