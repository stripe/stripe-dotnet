// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CadenceUpdateSettingsBillOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// The ID of the referenced settings object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// An optional field to specify the version of Settings to use. If not provided, this will
        /// always default to the <c>live_version</c> specified on the setting, any time the
        /// settings are used. Using a specific version here will prevent the settings from
        /// updating, and is discouraged for cadences. To clear a pinned version, set the version to
        /// null.
        /// </summary>
        [JsonProperty("version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("version")]
#endif
        public string Version { get; set; }
    }
}
