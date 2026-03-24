// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CadenceUpdateSettingsBillOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// The ID of the referenced settings object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// An optional field to specify the version of Settings to use. If not provided, this will
        /// always default to the <c>live_version</c> specified on the setting, any time the
        /// settings are used. Using a specific version here will prevent the settings from
        /// updating, and is discouraged for cadences. To clear a pinned version, set the version to
        /// null.
        /// </summary>
        [JsonProperty("version")]
        [STJS.JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
