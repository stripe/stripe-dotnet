namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsBrandingOptions : INestedOptions
    {
        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("primary_color")]
        public string PrimaryColor { get; set; }

        [JsonProperty("secondary_color")]
        public string SecondaryColor { get; set; }
    }
}
