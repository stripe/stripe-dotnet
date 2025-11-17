// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountEvaluationLoginInitiatedClientDeviceMetadataDetailsOptions : INestedOptions
    {
        /// <summary>
        /// ID for the Radar Session associated with the account evaluation.
        /// </summary>
        [JsonProperty("radar_session")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("radar_session")]
#endif
        public string RadarSession { get; set; }
    }
}
