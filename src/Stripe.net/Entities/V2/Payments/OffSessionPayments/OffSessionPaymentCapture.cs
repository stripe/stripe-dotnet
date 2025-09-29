// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OffSessionPaymentCapture : StripeEntity<OffSessionPaymentCapture>
    {
        /// <summary>
        /// The timestamp when this payment is no longer eligible to be captured.
        /// </summary>
        [JsonProperty("capture_before")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capture_before")]
#endif
        public DateTime? CaptureBefore { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The method to use to capture the payment.
        /// One of: <c>automatic</c>, or <c>manual</c>.
        /// </summary>
        [JsonProperty("capture_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capture_method")]
#endif
        public string CaptureMethod { get; set; }
    }
}
