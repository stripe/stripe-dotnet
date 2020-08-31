namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsDashboard : StripeEntity<AccountSettingsDashboard>
    {
        /// <summary>
        /// The display name for this account. This is used on the Stripe Dashboard to differentiate
        /// between accounts.
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The timezone used in the Stripe Dashboard for this account. A list of possible time zone
        /// values is maintained at the <a href="http://www.iana.org/time-zones">IANA Time Zone
        /// Database</a>.
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }
}
