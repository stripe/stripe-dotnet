// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentRecordRefundedOptions : INestedOptions
    {
        /// <summary>
        /// When the reported refund completed. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("refunded_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refunded_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? RefundedAt { get; set; }
    }
}
