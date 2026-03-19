// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountAccountHolder : StripeEntity<AccountAccountHolder>
    {
        #region Expandable Account

        /// <summary>
        /// (ID of the Account)
        /// The ID of the Stripe account that this account belongs to. Only available when
        /// <c>account_holder.type</c> is <c>account</c>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string AccountId
        {
            get => this.InternalAccount?.Id;
            set => this.InternalAccount = SetExpandableFieldId(value, this.InternalAccount);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the Stripe account that this account belongs to. Only available when
        /// <c>account_holder.type</c> is <c>account</c>.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Account Account
        {
            get => this.InternalAccount?.ExpandedObject;
            set => this.InternalAccount = SetExpandableFieldObject(value, this.InternalAccount);
        }

        [JsonProperty("account")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        [STJS.JsonPropertyName("account")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalAccount { get; set; }
        #endregion

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The ID for an Account representing a customer that this account belongs to. Only
        /// available when <c>account_holder.type</c> is <c>customer</c>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// The ID for an Account representing a customer that this account belongs to. Only
        /// available when <c>account_holder.type</c> is <c>customer</c>.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        [STJS.JsonPropertyName("customer")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        /// <summary>
        /// Type of account holder that this account belongs to.
        /// One of: <c>account</c>, or <c>customer</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
