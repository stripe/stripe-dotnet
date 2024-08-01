// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class AccountSessionComponentsAppViewportFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// List of apps allowed to be enabled for this account session.
        /// </summary>
        [JsonProperty("allowed_apps")]
        public List<string> AllowedApps { get; set; }
    }
}
