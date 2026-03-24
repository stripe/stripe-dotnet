// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OffSessionPaymentCapture : StripeEntity<OffSessionPaymentCapture>
    {
        /// <summary>
        /// The timestamp when this payment is no longer eligible to be captured.
        /// </summary>
        [JsonProperty("capture_before")]
        [STJS.JsonPropertyName("capture_before")]
        public DateTime? CaptureBefore { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The method to use to capture the payment.
        /// One of: <c>automatic</c>, or <c>manual</c>.
        /// </summary>
        [JsonProperty("capture_method")]
        [STJS.JsonPropertyName("capture_method")]
        public string CaptureMethod { get; set; }
    }
}
