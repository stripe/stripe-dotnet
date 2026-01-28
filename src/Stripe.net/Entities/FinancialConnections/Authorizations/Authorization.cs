// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// An Authorization represents the set of credentials used to connect a group of Financial
    /// Connections Accounts.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class Authorization : StripeEntity<Authorization>, IHasId, IHasObject
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

        /// <summary>
        /// The account holder that this authorization belongs to.
        /// </summary>
        [JsonProperty("account_holder")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_holder")]
#endif
        public AuthorizationAccountHolder AccountHolder { get; set; }

        #region Expandable Institution

        /// <summary>
        /// (ID of the Institution)
        /// The ID of the Financial Connections Institution this account belongs to. Note that this
        /// relationship may sometimes change in rare circumstances (e.g. institution mergers).
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string InstitutionId
        {
            get => this.InternalInstitution?.Id;
            set => this.InternalInstitution = SetExpandableFieldId(value, this.InternalInstitution);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the Financial Connections Institution this account belongs to. Note that this
        /// relationship may sometimes change in rare circumstances (e.g. institution mergers).
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Institution Institution
        {
            get => this.InternalInstitution?.ExpandedObject;
            set => this.InternalInstitution = SetExpandableFieldObject(value, this.InternalInstitution);
        }

        [JsonProperty("institution")]
        [JsonConverter(typeof(ExpandableFieldConverter<Institution>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("institution")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Institution>))]
#endif
        internal ExpandableField<Institution> InternalInstitution { get; set; }
        #endregion

        /// <summary>
        /// The name of the institution that this authorization belongs to.
        /// </summary>
        [JsonProperty("institution_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("institution_name")]
#endif
        public string InstitutionName { get; set; }

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
        /// The status of the connection to the Authorization.
        /// One of: <c>active</c>, <c>disconnected</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        [JsonProperty("status_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status_details")]
#endif
        public AuthorizationStatusDetails StatusDetails { get; set; }
    }
}
