// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentRecordRefundedOptions : INestedOptions
    {
        /// <summary>
        /// When the reported refund completed. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("refunded_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("refunded_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? RefundedAt { get; set; }
    }
}
