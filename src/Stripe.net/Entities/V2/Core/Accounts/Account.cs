// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A V2 Account is a representation of a company or individual that a Stripe user does
    /// business with. Accounts contain the contact details, Legal Entity information, and
    /// configuration required to enable the Account for use across Stripe products.
    /// </summary>
    public class Account : StripeEntity<Account>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the Account.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Filter only accounts that have all of the configurations specified. If omitted, returns
        /// all accounts regardless of which configurations they have.
        /// One of: <c>customer</c>, <c>merchant</c>, or <c>recipient</c>.
        /// </summary>
        [JsonProperty("applied_configurations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applied_configurations")]
#endif
        public List<string> AppliedConfigurations { get; set; }

        /// <summary>
        /// An Account Configuration which allows the Account to take on a key persona across Stripe
        /// products.
        /// </summary>
        [JsonProperty("configuration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("configuration")]
#endif
        public AccountConfiguration Configuration { get; set; }

        /// <summary>
        /// The default contact email address for the Account. Required when configuring the account
        /// as a merchant or recipient.
        /// </summary>
        [JsonProperty("contact_email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("contact_email")]
#endif
        public string ContactEmail { get; set; }

        /// <summary>
        /// Time at which the object was created. Represented as a RFC 3339 date &amp; time UTC
        /// value in millisecond precision, for example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// A value indicating the Stripe dashboard this Account has access to. This will depend on
        /// which configurations are enabled for this account.
        /// One of: <c>express</c>, <c>full</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("dashboard")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dashboard")]
#endif
        public string Dashboard { get; set; }

        /// <summary>
        /// Default values to be used on Account Configurations.
        /// </summary>
        [JsonProperty("defaults")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("defaults")]
#endif
        public AccountDefaults Defaults { get; set; }

        /// <summary>
        /// A descriptive name for the Account. This name will be surfaced in the Stripe Dashboard
        /// and on any invoices sent to the Account.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

        /// <summary>
        /// Information about the company, individual, and business represented by the Account.
        /// </summary>
        [JsonProperty("identity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("identity")]
#endif
        public AccountIdentity Identity { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Information about the requirements for the Account, including what information needs to
        /// be collected, and by when.
        /// </summary>
        [JsonProperty("requirements")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requirements")]
#endif
        public AccountRequirements Requirements { get; set; }
    }
}
