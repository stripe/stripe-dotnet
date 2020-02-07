namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsDashboardOptions : INestedOptions
    {
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }
}
