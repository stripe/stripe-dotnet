// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSessionComponentsAppInstallFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// The list of apps allowed to be enabled in the embedded component.
        /// </summary>
        [JsonProperty("allowed_apps")]
        [STJS.JsonPropertyName("allowed_apps")]
        public List<string> AllowedApps { get; set; }
    }
}
