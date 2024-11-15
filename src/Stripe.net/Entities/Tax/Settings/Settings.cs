// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// You can use Tax <c>Settings</c> to manage configurations used by Stripe Tax
    /// calculations.
    ///
    /// Related guide: <a href="https://stripe.com/docs/tax/settings-api">Using the Settings
    /// API</a>.
    /// </summary>
    public class Settings : StripeEntity<Settings>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif

        public string Object { get; set; }

        [JsonProperty("defaults")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("defaults")]
#endif

        public SettingsDefaults Defaults { get; set; }

        /// <summary>
        /// The place where your business is located.
        /// </summary>
        [JsonProperty("head_office")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("head_office")]
#endif

        public SettingsHeadOffice HeadOffice { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif

        public bool Livemode { get; set; }

        /// <summary>
        /// The status of the Tax <c>Settings</c>.
        /// One of: <c>active</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif

        public string Status { get; set; }

        [JsonProperty("status_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status_details")]
#endif

        public SettingsStatusDetails StatusDetails { get; set; }
    }
}
