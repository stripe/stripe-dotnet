namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountSettingsBranding : StripeEntity<AccountSettingsBranding>
    {
        #region Expandable Icon

        [JsonIgnore]
        public string IconId
        {
            get => this.InternalIcon?.Id;
            set => this.InternalIcon = SetExpandableFieldId(value, this.InternalIcon);
        }

        [JsonIgnore]
        public File Icon
        {
            get => this.InternalIcon?.ExpandedObject;
            set => this.InternalIcon = SetExpandableFieldObject(value, this.InternalIcon);
        }

        [JsonProperty("icon")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalIcon { get; set; }
        #endregion

        #region Expandable Logo

        [JsonIgnore]
        public string LogoId
        {
            get => this.InternalLogo?.Id;
            set => this.InternalLogo = SetExpandableFieldId(value, this.InternalLogo);
        }

        [JsonIgnore]
        public File Logo
        {
            get => this.InternalLogo?.ExpandedObject;
            set => this.InternalLogo = SetExpandableFieldObject(value, this.InternalLogo);
        }

        [JsonProperty("logo")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalLogo { get; set; }
        #endregion

        [JsonProperty("primary_color")]
        public string PrimaryColor { get; set; }

        [JsonProperty("secondary_color")]
        public string SecondaryColor { get; set; }
    }
}
