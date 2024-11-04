// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentRecordReportPaymentAttemptFailedOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// When the reported payment failed. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("failed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? FailedAt { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
