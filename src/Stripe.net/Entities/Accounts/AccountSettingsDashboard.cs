namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsDashboard : StripeEntity<AccountSettingsDashboard>
    {
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }
}
