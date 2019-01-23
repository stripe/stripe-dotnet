namespace Stripe
{
    using System;
    using System.Collections.Generic;
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
        public string IconId { get; set; }

        /// <summary>
        /// (Expanded) An icon for the account. Must be square and at least 128px x 128px.
        /// </summary>
        [JsonIgnore]
        public File Icon { get; set; }

        [JsonProperty("icon")]
        internal object InternalIcon
        {
            get
            {
                return this.Icon ?? (object)this.IconId;
            }

            set
            {
                StringOrObject<File>.Map(value, s => this.IconId = s, o => this.Icon = o);
            }
        }
        #endregion

        #region Expandable Logo

        /// <summary>
        /// (ID of a <see cref="File"/>) A logo for the account that will be used in Checkout
        /// instead of the icon and without the account’s name next to it if provided. Must be at
        /// least 128px x 128px.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string LogoId { get; set; }

        /// <summary>
        /// (Expanded)A logo for the account that will be used in Checkout instead of the icon and
        /// without the account’s name next to it if provided. Must be at least 128px x 128px.
        /// </summary>
        [JsonIgnore]
        public File Logo { get; set; }

        [JsonProperty("logo")]
        internal object InternalLogo
        {
            get
            {
                return this.Logo ?? (object)this.LogoId;
            }

            set
            {
                StringOrObject<File>.Map(value, s => this.LogoId = s, o => this.Logo = o);
            }
        }
        #endregion

        /// <summary>
        /// A CSS hex color value representing the primary branding color for this account.
        /// </summary>
        [JsonProperty("primary_color")]
        public string PrimaryColor { get; set; }
    }
}
