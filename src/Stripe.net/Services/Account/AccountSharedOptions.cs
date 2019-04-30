namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public abstract class AccountSharedOptions : BaseOptions
    {
        [JsonProperty("account_token")]
        public string AccountToken { get; set; }

        [JsonProperty("business_profile")]
        public AccountBusinessProfileOptions BusinessProfile { get; set; }

        [JsonProperty("business_type")]
        public string BusinessType { get; set; }

        [JsonProperty("company")]
        public AccountCompanyOptions Company { get; set; }

        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// <para>
        /// A card or bank account to attach to the account. You can provide either a token, like
        /// the ones returned by <a href="https://stripe.com/docs/stripe.js">Stripe.js</a>, or a
        /// <see cref="AccountBankAccountOptions"/> or <see cref="AccountCardOptions"/> instance.
        /// </para>
        /// <para>
        /// By default, providing an external account sets it as the new default external account
        /// for its currency, and deletes the old default if one exists. To add additional external
        /// accounts without replacing the existing default for the currency, use the bank account
        /// or card creation API.
        /// </para>
        /// </summary>
        [JsonProperty("external_account")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, AccountBankAccountOptions, AccountCardOptions> ExternalAccount { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("requested_capabilities")]
        public List<string> RequestedCapabilities { get; set; }

        [JsonProperty("settings")]
        public AccountSettingsOptions Settings { get; set; }

        [JsonProperty("tos_acceptance")]
        public AccountTosAcceptanceOptions TosAcceptance { get; set; }
    }
}
