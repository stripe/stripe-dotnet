// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentEvaluationClientDeviceMetadataDetailsOptions : INestedOptions
    {
        /// <summary>
        /// ID for the Radar Session to associate with the payment evaluation. A <a
        /// href="https://docs.stripe.com/radar/radar-session">Radar Session</a> is a snapshot of
        /// the browser metadata and device details that help Radar make more accurate predictions
        /// on your payments.
        /// </summary>
        [JsonProperty("radar_session")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("radar_session")]
#endif
        public string RadarSession { get; set; }
    }
}
