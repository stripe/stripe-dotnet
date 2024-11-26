// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SettingsUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Default configuration to be used on Stripe Tax calculations.
        /// </summary>
        [JsonProperty("defaults")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("defaults")]
#endif
        public SettingsDefaultsOptions Defaults { get; set; }

        /// <summary>
        /// The place where your business is located.
        /// </summary>
        [JsonProperty("head_office")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("head_office")]
#endif
        public SettingsHeadOfficeOptions HeadOffice { get; set; }
    }
}
