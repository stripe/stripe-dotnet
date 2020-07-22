namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

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
        /// Optional information related to the business.
        /// </summary>
        [JsonProperty("business_profile")]
        public AccountBusinessProfile BusinessProfile { get; set; }

        /// <summary>
        /// The business type. Can be <c>company</c> or <c>individual</c>.
        /// </summary>
        [JsonProperty("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// A hash containing the set of capabilities that was requested for this account and their
        /// associated states.
        /// </summary>
        [JsonProperty("capabilities")]
        public AccountCapabilities Capabilities { get; set; }

        /// <summary>
        /// Whether the account can create live charges.
        /// </summary>
        [JsonProperty("charges_enabled")]
        public bool ChargesEnabled { get; set; }

        /// <summary>
        /// Information about the company or business. This field is null unless
        /// <c>business_type</c> is set to <c>company</c>.
        /// </summary>
        [JsonProperty("company")]
        public AccountCompany Company { get; set; }

        /// <summary>
        /// The account's country.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// Three-letter ISO currency code representing the default currency for the account. This
        /// must be a currency that Stripe supports in the account's country.
        /// </summary>
        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Whether account details have been submitted. Standard accounts cannot receive payouts
        /// before this is true.
        /// </summary>
        [JsonProperty("details_submitted")]
        public bool DetailsSubmitted { get; set; }

        /// <summary>
        /// The primary user's email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// External accounts (bank accounts and debit cards) currently attached to this account.
        /// </summary>
        [JsonProperty("external_accounts")]
        public StripeList<IExternalAccount> ExternalAccounts { get; set; }

        /// <summary>
        /// Information about the person represented by the account. This field is null unless
        /// <c>business_type</c> is set to <c>individual</c>.
        /// </summary>
        [JsonProperty("individual")]
        public Person Individual { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Whether Stripe can send payouts to this account.
        /// </summary>
        [JsonProperty("payouts_enabled")]
        public bool PayoutsEnabled { get; set; }

        /// <summary>
        /// Information about the requirements for the account, including what information needs to
        /// be collected, and by when.
        /// </summary>
        [JsonProperty("requirements")]
        public AccountRequirements Requirements { get; set; }

        /// <summary>
        /// Account options for customizing how the account functions within Stripe.
        /// </summary>
        [JsonProperty("settings")]
        public AccountSettings Settings { get; set; }

        /// <summary>
        /// Details on the acceptance of the Stripe Services Agreement.
        /// </summary>
        [JsonProperty("tos_acceptance")]
        public AccountTosAcceptance TosAcceptance { get; set; }

        /// <summary>
        /// The Stripe account type. Can be <c>standard</c>, <c>express</c>, or
        /// <c>custom</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
