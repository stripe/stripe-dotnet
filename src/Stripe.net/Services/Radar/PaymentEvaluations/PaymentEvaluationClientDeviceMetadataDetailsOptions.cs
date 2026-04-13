// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentEvaluationClientDeviceMetadataDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Direct client device attributes such as IP address and user agent. Use this as an
        /// alternative to radar_session when a Radar Session isn't available.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]
        public PaymentEvaluationClientDeviceMetadataDetailsDataOptions Data { get; set; }

        /// <summary>
        /// ID for the Radar Session to associate with the payment evaluation. A <a
        /// href="https://docs.stripe.com/radar/radar-session">Radar Session</a> is a snapshot of
        /// the browser metadata and device details that help Radar make more accurate predictions
        /// on your payments.
        /// </summary>
        [JsonProperty("radar_session")]
        [STJS.JsonPropertyName("radar_session")]
        public string RadarSession { get; set; }
    }
}
