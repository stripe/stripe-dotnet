// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentRecordGuaranteedOptions : INestedOptions
    {
        /// <summary>
        /// When the reported payment was guaranteed. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("guaranteed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? GuaranteedAt { get; set; }
    }
}
