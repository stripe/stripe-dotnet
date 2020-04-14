namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsBrandingOptions : INestedOptions
    {
        /// <summary>
        /// ID of the file used as an icon for the account.
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// ID of the file used as a logo for the account in Checkout instead of the icon and
        /// without the account’s name next to it if provided.
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// A CSS hex color value representing the primary branding color for this account.
        /// </summary>
        [JsonProperty("primary_color")]
        public string PrimaryColor { get; set; }

        /// <summary>
        /// A CSS hex color value representing the secondary branding color for this account.
        /// </summary>
        [JsonProperty("secondary_color")]
        public string SecondaryColor { get; set; }
    }
}
