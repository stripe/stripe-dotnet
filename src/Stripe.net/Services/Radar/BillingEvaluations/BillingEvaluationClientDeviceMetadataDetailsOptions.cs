// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class BillingEvaluationClientDeviceMetadataDetailsOptions : INestedOptions
    {
        /// <summary>
        /// ID for the Radar Session to associate with the billing evaluation. A <a
        /// href="https://docs.stripe.com/radar/radar-session">Radar Session</a> is a snapshot of
        /// the browser metadata and device details that help Radar make more accurate predictions
        /// about the customer behind the upcoming payment.
        /// </summary>
        [JsonProperty("radar_session")]
        [STJS.JsonPropertyName("radar_session")]
        public string RadarSession { get; set; }
    }
}
