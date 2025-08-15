// File generated from our OpenAPI spec
namespace Stripe.V2
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
        /// Closed Enum. A list of the configurations which have been applied to the Account to
        /// allow Accounts to be filtered by the products they have been configured for. Currently
        /// can only contain <c>recipient</c>, which will be present if a recipient configuration is
        /// set.
        /// One of: <c>recipient</c>, or <c>storer</c>.
        /// </summary>
        [JsonProperty("applied_configurations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applied_configurations")]
#endif
        public List<string> AppliedConfigurations { get; set; }

        /// <summary>
        /// Configuration to enable this Account to be used as a recipient of an OutboundPayment via
        /// the OutboundPayments API, or via the dashboard.
        /// </summary>
        [JsonProperty("configuration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("configuration")]
#endif
        public AccountConfiguration Configuration { get; set; }

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
        /// The default contact email address for the Account. This field is optional, but must be
        /// supplied before the recipient configuration can be populated.
        /// </summary>
        [JsonProperty("email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email")]
#endif
        public string Email { get; set; }

        /// <summary>
        /// The default set of verification information for the Account. Currently, this only
        /// includes a single Legal Entity which must be set as the default.
        /// </summary>
        [JsonProperty("legal_entity_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("legal_entity_data")]
#endif
        public AccountLegalEntityData LegalEntityData { get; set; }

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
        /// A descriptive name for the Account. This name will be surfaced in the Account directory
        /// in the dashboard.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// A list of outstanding tasks users must complete before Stripe allows the Account’s
        /// Features to be activated.
        /// </summary>
        [JsonProperty("requirements")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requirements")]
#endif
        public List<AccountRequirement> Requirements { get; set; }
    }
}
