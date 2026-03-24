// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSettingsDashboard : StripeEntity<AccountSettingsDashboard>
    {
        /// <summary>
        /// The display name for this account. This is used on the Stripe Dashboard to differentiate
        /// between accounts.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The timezone used in the Stripe Dashboard for this account. A list of possible time zone
        /// values is maintained at the <a href="http://www.iana.org/time-zones">IANA Time Zone
        /// Database</a>.
        /// </summary>
        [JsonProperty("timezone")]
        [STJS.JsonPropertyName("timezone")]
        public string Timezone { get; set; }
    }
}
