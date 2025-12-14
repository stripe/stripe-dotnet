// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// These bank accounts are payment methods on <c>Customer</c> objects.
    ///
    /// On the other hand <a href="https://stripe.com/api#external_accounts">External
    /// Accounts</a> are transfer destinations on <c>Account</c> objects for connected accounts.
    /// They can be bank accounts or debit cards as well, and are documented in the links above.
    ///
    /// Related guide: <a href="https://stripe.com/payments/bank-debits-transfers">Bank debits
    /// and transfers</a>.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class BankAccount : StripeEntity<BankAccount>, IHasId, IHasMetadata, IHasObject, IExternalAccount, IPaymentSource
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

        #region Expandable Account

        /// <summary>
        /// (ID of the Account)
        /// The account this bank account belongs to. Only applicable on Accounts (not customers or
        /// recipients) This property is only available when returned as an <a
        /// href="https://stripe.com/api/external_account_bank_accounts/object">External Account</a>
        /// where <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-is_controller">controller.is_controller</a>
        /// is <c>true</c>.
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
        /// The account this bank account belongs to. Only applicable on Accounts (not customers or
        /// recipients) This property is only available when returned as an <a
        /// href="https://stripe.com/api/external_account_bank_accounts/object">External Account</a>
        /// where <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-is_controller">controller.is_controller</a>
        /// is <c>true</c>.
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
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Account>))]
#endif
        internal ExpandableField<Account> InternalAccount { get; set; }
        #endregion

        /// <summary>
        /// The name of the person or business that owns the bank account.
        /// </summary>
        [JsonProperty("account_holder_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_holder_name")]
#endif
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The type of entity that holds the account. This can be either <c>individual</c> or
        /// <c>company</c>.
        /// </summary>
        [JsonProperty("account_holder_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_holder_type")]
#endif
        public string AccountHolderType { get; set; }

        /// <summary>
        /// The bank account type. This can only be <c>checking</c> or <c>savings</c> in most
        /// countries. In Japan, this can only be <c>futsu</c> or <c>toza</c>.
        /// </summary>
        [JsonProperty("account_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_type")]
#endif
        public string AccountType { get; set; }

        /// <summary>
        /// A set of available payout methods for this bank account. Only values from this set
        /// should be passed as the <c>method</c> when creating a payout.
        /// One of: <c>instant</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("available_payout_methods")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("available_payout_methods")]
#endif
        public List<string> AvailablePayoutMethods { get; set; }

        /// <summary>
        /// Name of the bank associated with the routing number (e.g., <c>WELLS FARGO</c>).
        /// </summary>
        [JsonProperty("bank_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_name")]
#endif
        public string BankName { get; set; }

        /// <summary>
        /// Two-letter ISO code representing the country the bank account is located in.
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        /// <summary>
        /// Three-letter <a href="https://stripe.com/docs/payouts">ISO code for the currency</a>
        /// paid out to the bank account.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The ID of the customer that the bank account is associated with.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the customer that the bank account is associated with.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Customer>))]
#endif
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        /// <summary>
        /// Whether this bank account is the default external account for its currency.
        /// </summary>
        [JsonProperty("default_for_currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_for_currency")]
#endif
        public bool? DefaultForCurrency { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deleted")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
#endif
        public bool? Deleted { get; set; }

        /// <summary>
        /// Uniquely identifies this particular bank account. You can use this attribute to check
        /// whether two bank accounts are the same.
        /// </summary>
        [JsonProperty("fingerprint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fingerprint")]
#endif
        public string Fingerprint { get; set; }

        /// <summary>
        /// Information about the <a
        /// href="https://docs.stripe.com/connect/custom-accounts/future-requirements">upcoming new
        /// requirements for the bank account</a>, including what information needs to be collected,
        /// and by when.
        /// </summary>
        [JsonProperty("future_requirements")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("future_requirements")]
#endif
        public BankAccountFutureRequirements FutureRequirements { get; set; }

        /// <summary>
        /// The last four digits of the bank account number.
        /// </summary>
        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif
        public string Last4 { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Information about the requirements for the bank account, including what information
        /// needs to be collected.
        /// </summary>
        [JsonProperty("requirements")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requirements")]
#endif
        public BankAccountRequirements Requirements { get; set; }

        /// <summary>
        /// The routing transit number for the bank account.
        /// </summary>
        [JsonProperty("routing_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("routing_number")]
#endif
        public string RoutingNumber { get; set; }

        /// <summary>
        /// For bank accounts, possible values are <c>new</c>, <c>validated</c>, <c>verified</c>,
        /// <c>verification_failed</c>, <c>tokenized_account_number_deactivated</c> or
        /// <c>errored</c>. A bank account that hasn't had any activity or validation performed is
        /// <c>new</c>. If Stripe can determine that the bank account exists, its status will be
        /// <c>validated</c>. Note that there often isn’t enough information to know (e.g., for
        /// smaller credit unions), and the validation is not always run. If customer bank account
        /// verification has succeeded, the bank account status will be <c>verified</c>. If the
        /// verification failed for any reason, such as microdeposit failure, the status will be
        /// <c>verification_failed</c>. If the status is
        /// <c>tokenized_account_number_deactivated</c>, the account utilizes a tokenized account
        /// number which has been deactivated due to expiration or revocation. This account will
        /// need to be reverified to continue using it for money movement. If a payout sent to this
        /// bank account fails, we'll set the status to <c>errored</c> and will not continue to send
        /// <a href="https://stripe.com/docs/payouts#payout-schedule">scheduled payouts</a> until
        /// the bank details are updated.
        ///
        /// For external accounts, possible values are <c>new</c>, <c>errored</c>,
        /// <c>verification_failed</c>, and <c>tokenized_account_number_deactivated</c>. If a payout
        /// fails, the status is set to <c>errored</c> and scheduled payouts are stopped until
        /// account details are updated. In the US and India, if we can't <a
        /// href="https://support.stripe.com/questions/bank-account-ownership-verification">verify
        /// the owner of the bank account</a>, we'll set the status to <c>verification_failed</c>.
        /// Other validations aren't run against external accounts because they're only used for
        /// payouts. This means the other statuses don't apply.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
