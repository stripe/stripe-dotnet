// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SettingsUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Default configuration to be used on Stripe Tax calculations.
        /// </summary>
        [JsonProperty("defaults")]
        [STJS.JsonPropertyName("defaults")]
        public SettingsDefaultsOptions Defaults { get; set; }

        /// <summary>
        /// The place where your business is located.
        /// </summary>
        [JsonProperty("head_office")]
        [STJS.JsonPropertyName("head_office")]
        public SettingsHeadOfficeOptions HeadOffice { get; set; }
    }
}
