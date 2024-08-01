// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSessionComponentsAppViewportOptions : INestedOptions
    {
        /// <summary>
        /// Whether the embedded component is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The list of features enabled in the embedded component.
        /// </summary>
        [JsonProperty("features")]
        public AccountSessionComponentsAppViewportFeaturesOptions Features { get; set; }
    }
}
