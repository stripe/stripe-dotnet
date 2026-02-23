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
    /// An Account v2 object represents a company, individual, or other entity that interacts
    /// with a platform on Stripe. It contains both identifying information and properties that
    /// control its behavior and functionality. An Account can have one or more configurations
    /// that enable sets of related features, such as allowing it to act as a merchant or
    /// customer. The Accounts v2 API supports both the Global Payouts preview feature and the
    /// Connect-Billing integration preview feature. However, a particular Account can only
    /// access one of them. The Connect-Billing integration preview feature allows an Account v2
    /// to pay subscription fees to a platform. An Account v1 required a separate Customer
    /// object to pay subscription fees.
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
        /// The configurations that have been applied to this account.
        /// One of: <c>customer</c>, <c>merchant</c>, or <c>recipient</c>.
        /// </summary>
        [JsonProperty("applied_configurations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applied_configurations")]
#endif
        public List<string> AppliedConfigurations { get; set; }

        /// <summary>
        /// Indicates whether the account has been closed.
        /// </summary>
        [JsonProperty("closed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("closed")]
#endif
        public bool? Closed { get; set; }

        /// <summary>
        /// An Account represents a company, individual, or other entity that a user interacts with.
        /// Accounts store identity information and one or more configurations that enable
        /// product-specific capabilities. You can assign configurations at creation or add them
        /// later.
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
        /// The default contact phone for the Account.
        /// </summary>
        [JsonProperty("contact_phone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("contact_phone")]
#endif
        public string ContactPhone { get; set; }

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
        /// Default values for settings shared across Account configurations.
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
        /// Information about the future requirements for the Account that will eventually come into
        /// effect, including what information needs to be collected, and by when.
        /// </summary>
        [JsonProperty("future_requirements")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("future_requirements")]
#endif
        public AccountFutureRequirements FutureRequirements { get; set; }

        /// <summary>
        /// Information about the company, individual, and business represented by the Account.
        /// </summary>
        [JsonProperty("identity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("identity")]
#endif
        public AccountIdentity Identity { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

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
        /// Information about the active requirements for the Account, including what information
        /// needs to be collected, and by when.
        /// </summary>
        [JsonProperty("requirements")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requirements")]
#endif
        public AccountRequirements Requirements { get; set; }
    }
}
