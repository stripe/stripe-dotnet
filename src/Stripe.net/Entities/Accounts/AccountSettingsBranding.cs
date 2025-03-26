// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class AccountSettingsBranding : StripeEntity<AccountSettingsBranding>
    {
        #region Expandable Icon

        /// <summary>
        /// (ID of the File)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) An icon
        /// for the account. Must be square and at least 128px x 128px.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string IconId
        {
            get => this.InternalIcon?.Id;
            set => this.InternalIcon = SetExpandableFieldId(value, this.InternalIcon);
        }

        /// <summary>
        /// (Expanded)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) An icon
        /// for the account. Must be square and at least 128px x 128px.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public File Icon
        {
            get => this.InternalIcon?.ExpandedObject;
            set => this.InternalIcon = SetExpandableFieldObject(value, this.InternalIcon);
        }

        [JsonProperty("icon")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("icon")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<File>))]
#endif
        internal ExpandableField<File> InternalIcon { get; set; }
        #endregion

        #region Expandable Logo

        /// <summary>
        /// (ID of the File)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) A logo
        /// for the account that will be used in Checkout instead of the icon and without the
        /// account's name next to it if provided. Must be at least 128px x 128px.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string LogoId
        {
            get => this.InternalLogo?.Id;
            set => this.InternalLogo = SetExpandableFieldId(value, this.InternalLogo);
        }

        /// <summary>
        /// (Expanded)
        /// (ID of a <a href="https://stripe.com/docs/guides/file-upload">file upload</a>) A logo
        /// for the account that will be used in Checkout instead of the icon and without the
        /// account's name next to it if provided. Must be at least 128px x 128px.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public File Logo
        {
            get => this.InternalLogo?.ExpandedObject;
            set => this.InternalLogo = SetExpandableFieldObject(value, this.InternalLogo);
        }

        [JsonProperty("logo")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("logo")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<File>))]
#endif
        internal ExpandableField<File> InternalLogo { get; set; }
        #endregion

        /// <summary>
        /// A CSS hex color value representing the primary branding color for this account.
        /// </summary>
        [JsonProperty("primary_color")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("primary_color")]
#endif
        public string PrimaryColor { get; set; }

        /// <summary>
        /// A CSS hex color value representing the secondary branding color for this account.
        /// </summary>
        [JsonProperty("secondary_color")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("secondary_color")]
#endif
        public string SecondaryColor { get; set; }
    }
}
