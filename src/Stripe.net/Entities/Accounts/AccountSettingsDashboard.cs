// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSettingsDashboard : StripeEntity<AccountSettingsDashboard>
    {
        /// <summary>
        /// The display name for this account. This is used on the Stripe Dashboard to differentiate
        /// between accounts.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

        /// <summary>
        /// The timezone used in the Stripe Dashboard for this account. A list of possible time zone
        /// values is maintained at the <a href="http://www.iana.org/time-zones">IANA Time Zone
        /// Database</a>.
        /// </summary>
        [JsonProperty("timezone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("timezone")]
#endif
        public string Timezone { get; set; }
    }
}
