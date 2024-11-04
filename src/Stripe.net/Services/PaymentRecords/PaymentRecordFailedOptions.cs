// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentRecordFailedOptions : INestedOptions
    {
        /// <summary>
        /// When the reported payment failed. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("failed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? FailedAt { get; set; }
    }
}
