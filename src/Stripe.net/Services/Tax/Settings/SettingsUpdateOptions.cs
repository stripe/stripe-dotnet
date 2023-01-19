// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SettingsUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Default configuration to be used on Stripe Tax calculations.
        /// </summary>
        [JsonProperty("defaults")]
        public SettingsDefaultsOptions Defaults { get; set; }

        /// <summary>
        /// The places where your business is located.
        /// </summary>
        [JsonProperty("locations")]
        public List<SettingsLocationOptions> Locations { get; set; }
    }
}
