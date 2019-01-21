namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountSettingsBranding : StripeEntity<AccountSettingsBranding>
    {
        #region Expandable Icon

        /// <summary>
        /// (ID of a <see cref="File"/>) An icon for the account. Must be square and at least 128px
        /// x 128px.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string IconId => this.InternalIcon.Id;

        /// <summary>
        /// (Expanded) An icon for the account. Must be square and at least 128px x 128px.
        /// </summary>
        [JsonIgnore]
        public File Icon => this.InternalIcon.ExpandedObject;

        [JsonProperty("icon")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalIcon { get; set; }
        #endregion

        #region Expandable Logo

        /// <summary>
        /// (ID of a <see cref="File"/>) A logo for the account that will be used in Checkout
        /// instead of the icon and without the account’s name next to it if provided. Must be at
        /// least 128px x 128px.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string LogoId => this.InternalLogo.Id;

        /// <summary>
        /// (Expanded)A logo for the account that will be used in Checkout instead of the icon and
        /// without the account’s name next to it if provided. Must be at least 128px x 128px.
        /// </summary>
        [JsonIgnore]
        public File Logo => this.InternalLogo.ExpandedObject;

        [JsonProperty("logo")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalLogo { get; set; }
        #endregion

        /// <summary>
        /// A CSS hex color value representing the primary branding color for this account.
        /// </summary>
        [JsonProperty("primary_color")]
        public string PrimaryColor { get; set; }
    }
}
