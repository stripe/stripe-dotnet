// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// You can use Tax <c>Settings</c> to manage configurations used by Stripe Tax
    /// calculations.
    ///
    /// Related guide: <a href="https://stripe.com/docs/tax/connect/settings">Account
    /// settings</a>.
    /// </summary>
    public class Settings : StripeEntity<Settings>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("defaults")]
        public SettingsDefaults Defaults { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The places where your business is located.
        /// </summary>
        [JsonProperty("locations")]
        public List<SettingsLocation> Locations { get; set; }
    }
}
