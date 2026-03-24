// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// An Authorization represents the set of credentials used to connect a group of Financial
    /// Connections Accounts.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Authorization : StripeEntity<Authorization>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The account holder that this authorization belongs to.
        /// </summary>
        [JsonProperty("account_holder")]
        [STJS.JsonPropertyName("account_holder")]
        public AuthorizationAccountHolder AccountHolder { get; set; }

        #region Expandable Institution

        /// <summary>
        /// (ID of the Institution)
        /// The ID of the Financial Connections Institution this account belongs to. Note that this
        /// relationship may sometimes change in rare circumstances (e.g. institution mergers).
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
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
        [STJS.JsonIgnore]
        public Institution Institution
        {
            get => this.InternalInstitution?.ExpandedObject;
            set => this.InternalInstitution = SetExpandableFieldObject(value, this.InternalInstitution);
        }

        [JsonProperty("institution")]
        [JsonConverter(typeof(ExpandableFieldConverter<Institution>))]
        [STJS.JsonPropertyName("institution")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Institution>))]
        internal ExpandableField<Institution> InternalInstitution { get; set; }
        #endregion

        /// <summary>
        /// The name of the institution that this authorization belongs to.
        /// </summary>
        [JsonProperty("institution_name")]
        [STJS.JsonPropertyName("institution_name")]
        public string InstitutionName { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The status of the connection to the Authorization.
        /// One of: <c>active</c>, <c>disconnected</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public AuthorizationStatusDetails StatusDetails { get; set; }
    }
}
