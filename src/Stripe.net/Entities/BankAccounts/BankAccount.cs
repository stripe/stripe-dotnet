namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class BankAccount : StripeEntity<BankAccount>, IHasId, IHasMetadata, IHasObject, IExternalAccount, IPaymentSource
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

        [JsonProperty("account_holder_name")]
        public string AccountHolderName { get; set; }

        [JsonProperty("account_holder_type")]
        public string AccountHolderType { get; set; }

        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Customer

        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        [JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        [JsonProperty("default_for_currency")]
        public bool? DefaultForCurrency { get; set; }

        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("routing_number")]
        public string RoutingNumber { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
