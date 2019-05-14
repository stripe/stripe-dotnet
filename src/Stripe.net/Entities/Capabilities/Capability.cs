namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Capability : StripeEntity, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object’s type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        #region Expandable Account

        /// <summary>
        /// ID of the account the capability is associated with.
        /// </summary>
        [JsonIgnore]
        public string AccountId { get; set; }

        [JsonIgnore]
        public Account Account { get; set; }

        [JsonProperty("account")]
        internal object InternalAccount
        {
            get
            {
                return this.Account ?? (object)this.AccountId;
            }

            set
            {
                StringOrObject<Account>.Map(value, s => this.AccountId = s, o => this.Account = o);
            }
        }
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
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime RequestedAt { get; set; }

        /// <summary>
        /// Information about the requirements for this capability, including what information
        /// needs to be collected, and by when.
        /// </summary>
        [JsonProperty("requirements")]
        public CapabilityRequirements Requirements { get; set; }

        /// <summary>
        /// The status of the capability. Can be <c>active</c>, <c>inactive</c>, <c>pending</c>, or
        /// <c>unrequested</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
