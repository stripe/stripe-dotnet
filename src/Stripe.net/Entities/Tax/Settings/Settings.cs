// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// You can use Tax <c>Settings</c> to manage configurations used by Stripe Tax
    /// calculations.
    ///
    /// Related guide: <a href="https://docs.stripe.com/tax/settings-api">Using the Settings
    /// API</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Settings : StripeEntity<Settings>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonProperty("defaults")]
        [STJS.JsonPropertyName("defaults")]
        public SettingsDefaults Defaults { get; set; }

        /// <summary>
        /// The place where your business is located.
        /// </summary>
        [JsonProperty("head_office")]
        [STJS.JsonPropertyName("head_office")]
        public SettingsHeadOffice HeadOffice { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The status of the Tax <c>Settings</c>.
        /// One of: <c>active</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public SettingsStatusDetails StatusDetails { get; set; }
    }
}
