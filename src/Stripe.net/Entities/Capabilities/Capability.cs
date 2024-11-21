// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// This is an object representing a capability for a Stripe account.
    ///
    /// Related guide: <a href="https://stripe.com/docs/connect/account-capabilities">Account
    /// capabilities</a>.
    /// </summary>
    public class Capability : StripeEntity<Capability>, IHasId, IHasObject
    {
        /// <summary>
        /// The identifier for the capability.
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

        #region Expandable Account

        /// <summary>
        /// (ID of the Account)
        /// The account for which the capability enables functionality.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public string AccountId
        {
            get => this.InternalAccount?.Id;
            set => this.InternalAccount = SetExpandableFieldId(value, this.InternalAccount);
        }

        /// <summary>
        /// (Expanded)
        /// The account for which the capability enables functionality.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public Account Account
        {
            get => this.InternalAccount?.ExpandedObject;
            set => this.InternalAccount = SetExpandableFieldObject(value, this.InternalAccount);
        }

        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
        [STJS.JsonInclude]
#endif

        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Account>))]
#endif

        internal ExpandableField<Account> InternalAccount { get; set; }
        #endregion

        [JsonProperty("future_requirements")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("future_requirements")]
#endif

        public CapabilityFutureRequirements FutureRequirements { get; set; }

        /// <summary>
        /// Whether the capability has been requested.
        /// </summary>
        [JsonProperty("requested")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requested")]
#endif

        public bool Requested { get; set; }

        /// <summary>
        /// Time at which the capability was requested. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("requested_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requested_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? RequestedAt { get; set; }

        [JsonProperty("requirements")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requirements")]
#endif

        public CapabilityRequirements Requirements { get; set; }

        /// <summary>
        /// The status of the capability.
        /// One of: <c>active</c>, <c>disabled</c>, <c>inactive</c>, <c>pending</c>, or
        /// <c>unrequested</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif

        public string Status { get; set; }
    }
}
