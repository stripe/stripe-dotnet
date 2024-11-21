// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// An Issuing <c>Cardholder</c> object represents an individual or business entity who is
    /// <a href="https://stripe.com/docs/issuing">issued</a> cards.
    ///
    /// Related guide: <a href="https://stripe.com/docs/issuing/cards#create-cardholder">How to
    /// create a cardholder</a>.
    /// </summary>
    public class Cardholder : StripeEntity<Cardholder>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif

        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif

        public string Object { get; set; }

        [JsonProperty("billing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing")]
#endif

        public CardholderBilling Billing { get; set; }

        /// <summary>
        /// Additional information about a <c>company</c> cardholder.
        /// </summary>
        [JsonProperty("company")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("company")]
#endif

        public CardholderCompany Company { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The cardholder's email address.
        /// </summary>
        [JsonProperty("email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email")]
#endif

        public string Email { get; set; }

        /// <summary>
        /// Additional information about an <c>individual</c> cardholder.
        /// </summary>
        [JsonProperty("individual")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("individual")]
#endif

        public CardholderIndividual Individual { get; set; }

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
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif

        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The cardholder's name. This will be printed on cards issued to them.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif

        public string Name { get; set; }

        /// <summary>
        /// The cardholder's phone number. This is required for all cardholders who will be creating
        /// EU cards. See the <a
        /// href="https://stripe.com/docs/issuing/3d-secure#when-is-3d-secure-applied">3D Secure
        /// documentation</a> for more details.
        /// </summary>
        [JsonProperty("phone_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone_number")]
#endif

        public string PhoneNumber { get; set; }

        /// <summary>
        /// The cardholder’s preferred locales (languages), ordered by preference. Locales can be
        /// <c>de</c>, <c>en</c>, <c>es</c>, <c>fr</c>, or <c>it</c>. This changes the language of
        /// the <a href="https://stripe.com/docs/issuing/3d-secure">3D Secure flow</a> and one-time
        /// password messages sent to the cardholder.
        /// One of: <c>de</c>, <c>en</c>, <c>es</c>, <c>fr</c>, or <c>it</c>.
        /// </summary>
        [JsonProperty("preferred_locales")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("preferred_locales")]
#endif

        public List<string> PreferredLocales { get; set; }

        [JsonProperty("requirements")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requirements")]
#endif

        public CardholderRequirements Requirements { get; set; }

        /// <summary>
        /// Rules that control spending across this cardholder's cards. Refer to our <a
        /// href="https://stripe.com/docs/issuing/controls/spending-controls">documentation</a> for
        /// more details.
        /// </summary>
        [JsonProperty("spending_controls")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("spending_controls")]
#endif

        public CardholderSpendingControls SpendingControls { get; set; }

        /// <summary>
        /// Specifies whether to permit authorizations on this cardholder's cards.
        /// One of: <c>active</c>, <c>blocked</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif

        public string Status { get; set; }

        /// <summary>
        /// One of <c>individual</c> or <c>company</c>. See <a
        /// href="https://stripe.com/docs/issuing/other/choose-cardholder">Choose a cardholder
        /// type</a> for more details.
        /// One of: <c>company</c>, or <c>individual</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }
    }
}
