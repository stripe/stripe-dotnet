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
        /// Business information about the account.
        /// </summary>
        [JsonProperty("business_profile")]
        public AccountBusinessProfile BusinessProfile { get; set; }

        /// <summary>
        /// The business type.
        /// One of: <c>company</c>, <c>government_entity</c>, <c>individual</c>, or
        /// <c>non_profit</c>.
        /// </summary>
        [JsonProperty("business_type")]
        public string BusinessType { get; set; }

        [JsonProperty("capabilities")]
        public AccountCapabilities Capabilities { get; set; }

        /// <summary>
        /// Whether the account can create live charges.
        /// </summary>
        [JsonProperty("charges_enabled")]
        public bool ChargesEnabled { get; set; }

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
        /// This is an object representing a person associated with a Stripe account.
        ///
        /// Related guide: <a
        /// href="https://stripe.com/docs/connect/identity-verification-api#person-information">Handling
        /// Identity Verification with the API</a>.
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
        /// Whether Stripe can send payouts to this account.
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
        /// The Stripe account type. Can be <c>standard</c>, <c>express</c>, or <c>custom</c>.
        /// One of: <c>custom</c>, <c>express</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
