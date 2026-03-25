// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSessionComponentsAppViewportFeaturesOptions : INestedOptions, IHasSetTracking
    {
        private List<string> allowedApps;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The list of apps allowed to be enabled in the embedded component.
        /// </summary>
        [JsonProperty("allowed_apps")]
        [STJS.JsonPropertyName("allowed_apps")]
        public List<string> AllowedApps
        {
            get => this.allowedApps;
            set
            {
                this.allowedApps = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
