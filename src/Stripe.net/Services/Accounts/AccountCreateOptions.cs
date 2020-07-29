namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// An <a href="https://stripe.com/docs/api/tokens/create_account">account token</a>,
        /// used to securely provide details to the account.
        /// </summary>
        [JsonProperty("account_token")]
        public string AccountToken { get; set; }

        /// <summary>
        /// Non-essential business information about the account.
        /// </summary>
        [JsonProperty("business_profile")]
        public AccountBusinessProfileOptions BusinessProfile { get; set; }

        /// <summary>
        /// The business type. One of <c>individual</c> or <c>company</c>.
        /// </summary>
        [JsonProperty("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// Each key of the dictionary represents a capability,
        /// and each capability maps to its settings (e.g. whether
        /// it has been requested or not). Each capability will be
        /// inactive until you have provided its specific
        /// requirements and Stripe has verified them. An account
        /// may have some of its requested capabilities be active
        /// and some be inactive.
        /// </summary>
        [JsonProperty("capabilities")]
        public AccountCapabilitiesOptions Capabilities { get; set; }

        /// <summary>
        /// Information about the company or business. This field is null
        /// unless <see cref="BusinessType"/> is set to <c>company</c>.
        /// </summary>
        [JsonProperty("company")]
        public AccountCompanyOptions Company { get; set; }

        /// <summary>
        /// The country in which the account holder resides, or in which the
        /// business is legally established. This should be an ISO 3166-1
        /// alpha-2 country code. For example, if you are in the United States
        /// and the business for which you're creating an account is legally
        /// represented in Canada, you would use CA as the country for the
        /// account being created.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Three-letter ISO currency code representing the default currency
        /// for the account. This must be a currency that Stripe supports in
        /// the account's country.
        /// </summary>
        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        /// <summary>
        /// The email address of the account holder. For Custom accounts, this
        /// is only to make the account easier to identify to you: Stripe will
        /// never directly email your users.
        /// </summary>
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

        /// <summary>
        /// Information about the person represented by the account. This field
        /// is null unless <see cref="BusinessType"/> is set to <c>individual</c>.
        /// </summary>
        [JsonProperty("individual")]
        public PersonCreateOptions Individual { get; set; }

        /// <summary>
        /// A set of key-value pairs that you can attach to an object.
        /// This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [Obsolete("Use Capabilities instead.")]
        [JsonProperty("requested_capabilities")]
        public List<string> RequestedCapabilities { get; set; }

        /// <summary>
        /// Options for customizing how the account functions within Stripe.
        /// </summary>
        [JsonProperty("settings")]
        public AccountSettingsOptions Settings { get; set; }

        /// <summary>
        /// Details on the account's acceptance of the
        /// <a href="https://stripe.com/docs/connect/updating-accounts#tos-acceptance">Stripe Services Agreement</a>.
        /// </summary>
        [JsonProperty("tos_acceptance")]
        public AccountTosAcceptanceOptions TosAcceptance { get; set; }

        /// <summary>
        /// One of <see cref="AccountType"/>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
