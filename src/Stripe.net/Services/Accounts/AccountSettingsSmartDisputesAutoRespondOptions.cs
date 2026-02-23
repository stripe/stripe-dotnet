// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSettingsSmartDisputesAutoRespondOptions : INestedOptions
    {
        /// <summary>
        /// The preference setting for auto-respond. Can be 'on', 'off', or 'inherit'.
        /// One of: <c>inherit</c>, <c>off</c>, or <c>on</c>.
        /// </summary>
        [JsonProperty("preference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("preference")]
#endif
        public string Preference { get; set; }
    }
}
