namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsBrandingOptions : INestedOptions
    {
        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) An icon
        /// for the account. Must be square and at least 128px x 128px.
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) A logo
        /// for the account that will be used in Checkout instead of the icon and without the
        /// account's name next to it if provided. Must be at least 128px x 128px.
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
