// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class SettingsUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Default configuration to be used on Stripe Tax calculations.
        /// </summary>
        [JsonProperty("defaults")]
        public SettingsDefaultsOptions Defaults { get; set; }

        /// <summary>
        /// The place where your business is located.
        /// </summary>
        [JsonProperty("head_office")]
        public SettingsHeadOfficeOptions HeadOffice { get; set; }
    }
}
