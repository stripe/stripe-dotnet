// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// An <a href="https://stripe.com/docs/api#create_account_token">account token</a>, used to
        /// securely provide details to the account.
        /// </summary>
        [JsonProperty("account_token")]
        public string AccountToken { get; set; }

        /// <summary>
        /// Business information about the account.
        /// </summary>
        [JsonProperty("business_profile")]
        public AccountBusinessProfileOptions BusinessProfile { get; set; }

        /// <summary>
        /// The business type. Once you create an <a
        /// href="https://stripe.com/docs/api/account_links">Account Link</a> or <a
        /// href="https://stripe.com/docs/api/account_sessions">Account Session</a>, this property
        /// can only be updated for Custom accounts.
        /// One of: <c>company</c>, <c>government_entity</c>, <c>individual</c>, or
        /// <c>non_profit</c>.
        /// </summary>
        [JsonProperty("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// Each key of the dictionary represents a capability, and each capability maps to its
        /// settings (e.g. whether it has been requested or not). Each capability will be inactive
        /// until you have provided its specific requirements and Stripe has verified them. An
        /// account may have some of its requested capabilities be active and some be inactive.
        /// </summary>
        [JsonProperty("capabilities")]
        public AccountCapabilitiesOptions Capabilities { get; set; }

        /// <summary>
        /// Information about the company or business. This field is available for any
        /// <c>business_type</c>. Once you create an <a
        /// href="https://stripe.com/docs/api/account_links">Account Link</a> or <a
        /// href="https://stripe.com/docs/api/account_sessions">Account Session</a>, this property
        /// can only be updated for Custom accounts.
        /// </summary>
        [JsonProperty("company")]
        public AccountCompanyOptions Company { get; set; }

        /// <summary>
        /// Three-letter ISO currency code representing the default currency for the account. This
        /// must be a currency that <a href="https://stripe.com/docs/payouts">Stripe supports in the
        /// account's country</a>.
        /// </summary>
        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        /// <summary>
        /// Documents that may be submitted to satisfy various informational requests.
        /// </summary>
        [JsonProperty("documents")]
        public AccountDocumentsOptions Documents { get; set; }

        /// <summary>
        /// The email address of the account holder. This is only to make the account easier to
        /// identify to you. Stripe only emails Custom accounts with your consent.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// A card or bank account to attach to the account for receiving <a
        /// href="https://stripe.com/docs/connect/bank-debit-card-payouts">payouts</a> (you won’t be
        /// able to use it for top-ups). You can provide either a token, like the ones returned by
        /// <a href="https://stripe.com/docs/js">Stripe.js</a>, or a dictionary, as documented in
        /// the <c>external_account</c> parameter for <a
        /// href="https://stripe.com/docs/api#account_create_bank_account">bank account</a>
        /// creation. <br/><br/>By default, providing an external account sets it as the new default
        /// external account for its currency, and deletes the old default if one exists. To add
        /// additional external accounts without replacing the existing default for the currency,
        /// use the <a href="https://stripe.com/docs/api#account_create_bank_account">bank
        /// account</a> or <a href="https://stripe.com/docs/api#account_create_card">card
        /// creation</a> APIs. After you create an <a
        /// href="https://stripe.com/docs/api/account_links">Account Link</a> or <a
        /// href="https://stripe.com/docs/api/account_sessions">Account Session</a>, this property
        /// can only be updated for Custom accounts.
        /// </summary>
        [JsonProperty("external_account")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, AccountBankAccountOptions, AccountCardOptions> ExternalAccount { get; set; }

        /// <summary>
        /// Information about the person represented by the account. This field is null unless
        /// <c>business_type</c> is set to <c>individual</c>. Once you create an <a
        /// href="https://stripe.com/docs/api/account_links">Account Link</a> or <a
        /// href="https://stripe.com/docs/api/account_sessions">Account Session</a>, this property
        /// can only be updated for Custom accounts.
        /// </summary>
        [JsonProperty("individual")]
        public AccountIndividualOptions Individual { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Options for customizing how the account functions within Stripe.
        /// </summary>
        [JsonProperty("settings")]
        public AccountSettingsOptions Settings { get; set; }

        /// <summary>
        /// Details on the account's acceptance of the <a
        /// href="https://stripe.com/docs/connect/updating-accounts#tos-acceptance">Stripe Services
        /// Agreement</a> This property can only be updated for Custom accounts.
        /// </summary>
        [JsonProperty("tos_acceptance")]
        public AccountTosAcceptanceOptions TosAcceptance { get; set; }
    }
}
