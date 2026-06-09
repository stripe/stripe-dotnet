// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentMethodOptionsCardPresentCaptureDelay : StripeEntity<PaymentIntentPaymentMethodOptionsCardPresentCaptureDelay>
    {
        /// <summary>
        /// The number of days to delay the capture of the funds.
        ///
        /// You can only set this if <c>capture_method</c> is <c>automatic_delayed</c> and
        /// <c>capture_by</c> is <c>target_delay</c>.
        /// </summary>
        [JsonProperty("days")]
        [STJS.JsonPropertyName("days")]
        public long Days { get; set; }

        /// <summary>
        /// The number of hours to delay the capture of the funds.
        ///
        /// You can only set this if <c>capture_method</c> is <c>automatic_delayed</c> and
        /// <c>capture_by</c> is <c>target_delay</c>.
        /// </summary>
        [JsonProperty("hours")]
        [STJS.JsonPropertyName("hours")]
        public long Hours { get; set; }
    }
}
