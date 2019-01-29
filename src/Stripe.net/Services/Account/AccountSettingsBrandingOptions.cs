namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsBrandingOptions : INestedOptions
    {
        [JsonProperty("icon")]
        public string IconFileId { get; set; }

        [JsonProperty("logo")]
        public string LogoFileId { get; set; }

        [JsonProperty("primary_color")]
        public string PrimaryColor { get; set; }
    }
}
