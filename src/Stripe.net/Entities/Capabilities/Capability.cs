namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Capability : StripeEntity<Capability>, IHasId, IHasObject
    {
        /// <summary>
        /// The identifier for the capability.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        #region Expandable Account

        /// <summary>
        /// (ID of the Account)
        /// The account for which the capability enables functionality.
        /// </summary>
        [JsonIgnore]
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
        public Account Account
        {
            get => this.InternalAccount?.ExpandedObject;
            set => this.InternalAccount = SetExpandableFieldObject(value, this.InternalAccount);
        }

        [JsonProperty("account")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalAccount { get; set; }
        #endregion

        /// <summary>
        /// Whether the capability has been requested.
        /// </summary>
        [JsonProperty("requested")]
        public bool Requested { get; set; }

        /// <summary>
        /// Time at which the capability was requested. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("requested_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? RequestedAt { get; set; }

        [JsonProperty("requirements")]
        public CapabilityRequirements Requirements { get; set; }

        /// <summary>
        /// The status of the capability. Can be <c>active</c>, <c>inactive</c>, <c>pending</c>, or
        /// <c>unrequested</c>.
        /// One of: <c>active</c>, <c>disabled</c>, <c>inactive</c>, <c>pending</c>, or
        /// <c>unrequested</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
