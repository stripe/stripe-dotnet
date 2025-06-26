// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSessionComponentsAppInstallFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// The list of apps allowed to be enabled in the embedded component.
        /// </summary>
        [JsonProperty("allowed_apps")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("allowed_apps")]
#endif
        public List<string> AllowedApps { get; set; }
    }
}
