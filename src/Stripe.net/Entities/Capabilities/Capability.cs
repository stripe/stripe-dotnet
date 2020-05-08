namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Capability : StripeEntity<Capability>, IHasId, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        #region Expandable Account

        [JsonIgnore]
        public string AccountId
        {
            get => this.InternalAccount?.Id;
            set => this.InternalAccount = SetExpandableFieldId(value, this.InternalAccount);
        }

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

        [JsonProperty("requested")]
        public bool Requested { get; set; }

        [JsonProperty("requested_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? RequestedAt { get; set; }

        [JsonProperty("requirements")]
        public CapabilityRequirements Requirements { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
