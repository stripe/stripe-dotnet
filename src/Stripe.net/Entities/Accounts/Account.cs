// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// This is an object representing a Stripe account. You can retrieve it to see properties
    /// on the account like its current requirements or if the account is enabled to make live
    /// charges or receive payouts.
    ///
    /// For accounts where <a
    /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">controller.requirement_collection</a>
    /// is <c>application</c>, which includes Custom accounts, the properties below are always
    /// returned.
    ///
    /// For accounts where <a
    /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">controller.requirement_collection</a>
    /// is <c>stripe</c>, which includes Standard and Express accounts, some properties are only
    /// returned until you create an <a href="https://stripe.com/api/account_links">Account
    /// Link</a> or <a href="https://stripe.com/api/account_sessions">Account Session</a> to
    /// start Connect Onboarding. Learn about the <a
    /// href="https://stripe.com/connect/accounts">differences between accounts</a>.
    /// </summary>
    public class Account : StripeEntity<Account>, IHasId, IHasMetadata, IHasObject, IPaymentSource
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Business information about the account.
        /// </summary>
        [JsonProperty("business_profile")]
        public AccountBusinessProfile BusinessProfile { get; set; }

        /// <summary>
        /// The business type. After you create an <a
        /// href="https://stripe.com/api/account_links">Account Link</a> or <a
        /// href="https://stripe.com/api/account_sessions">Account Session</a>, this property is
        /// only returned for accounts where <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">controller.requirement_collection</a>
        /// is <c>application</c>, which includes Custom accounts.
        /// One of: <c>company</c>, <c>government_entity</c>, <c>individual</c>, or
        /// <c>non_profit</c>.
        /// </summary>
        [JsonProperty("business_type")]
        public string BusinessType { get; set; }

        [JsonProperty("capabilities")]
        public AccountCapabilities Capabilities { get; set; }

        /// <summary>
        /// Whether the account can process charges.
        /// </summary>
        [JsonProperty("charges_enabled")]
        public bool ChargesEnabled { get; set; }

        [JsonProperty("company")]
        public AccountCompany Company { get; set; }

        [JsonProperty("controller")]
        public AccountController Controller { get; set; }

        /// <summary>
        /// The account's country.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Time at which the account was connected. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter ISO currency code representing the default currency for the account. This
        /// must be a currency that <a href="https://stripe.com/docs/payouts">Stripe supports in the
        /// account's country</a>.
        /// </summary>
        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Whether account details have been submitted. Accounts with Stripe Dashboard access,
        /// which includes Standard accounts, cannot receive payouts before this is true. Accounts
        /// where this is false should be directed to <a
        /// href="https://stripe.com/connect/onboarding">an onboarding flow</a> to finish submitting
        /// account details.
        /// </summary>
        [JsonProperty("details_submitted")]
        public bool DetailsSubmitted { get; set; }

        /// <summary>
        /// An email address associated with the account. It's not used for authentication and
        /// Stripe doesn't market to this field without explicit approval from the platform.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// External accounts (bank accounts and debit cards) currently attached to this account.
        /// External accounts are only returned for requests where <c>controller[is_controller]</c>
        /// is true.
        /// </summary>
        [JsonProperty("external_accounts")]
        public StripeList<IExternalAccount> ExternalAccounts { get; set; }

        [JsonProperty("future_requirements")]
        public AccountFutureRequirements FutureRequirements { get; set; }

        /// <summary>
        /// The groups associated with the account.
        /// </summary>
        [JsonProperty("groups")]
        public AccountGroups Groups { get; set; }

        /// <summary>
        /// This is an object representing a person associated with a Stripe account.
        ///
        /// A platform cannot access a person for an account where <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">account.controller.requirement_collection</a>
        /// is <c>stripe</c>, which includes Standard and Express accounts, after creating an
        /// Account Link or Account Session to start Connect onboarding.
        ///
        /// See the <a href="https://stripe.com/connect/standard-accounts">Standard onboarding</a>
        /// or <a href="https://stripe.com/connect/express-accounts">Express onboarding</a>
        /// documentation for information about prefilling information and account onboarding steps.
        /// Learn more about <a
        /// href="https://stripe.com/connect/handling-api-verification#person-information">handling
        /// identity verification with the API</a>.
        /// </summary>
        [JsonProperty("individual")]
        public Person Individual { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Whether the funds in this account can be paid out.
        /// </summary>
        [JsonProperty("payouts_enabled")]
        public bool PayoutsEnabled { get; set; }

        [JsonProperty("requirements")]
        public AccountRequirements Requirements { get; set; }

        /// <summary>
        /// Options for customizing how the account functions within Stripe.
        /// </summary>
        [JsonProperty("settings")]
        public AccountSettings Settings { get; set; }

        [JsonProperty("tos_acceptance")]
        public AccountTosAcceptance TosAcceptance { get; set; }

        /// <summary>
        /// The Stripe account type. Can be <c>standard</c>, <c>express</c>, <c>custom</c>, or
        /// <c>none</c>.
        /// One of: <c>custom</c>, <c>express</c>, <c>none</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
