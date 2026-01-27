// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A Financial Connections Account represents an account that exists outside of Stripe, to
    /// which you have been granted some degree of access.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class Account : StripeEntity<Account>, IHasId, IHasObject
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
        /// The account holder that this account belongs to.
        /// </summary>
        [JsonProperty("account_holder")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_holder")]
#endif
        public AccountAccountHolder AccountHolder { get; set; }

        /// <summary>
        /// Details about the account numbers.
        /// </summary>
        [JsonProperty("account_numbers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_numbers")]
#endif
        public List<AccountAccountNumber> AccountNumbers { get; set; }

        /// <summary>
        /// The ID of the Financial Connections Authorization this account belongs to.
        /// </summary>
        [JsonProperty("authorization")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("authorization")]
#endif
        public string Authorization { get; set; }

        /// <summary>
        /// The most recent information about the account's balance.
        /// </summary>
        [JsonProperty("balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("balance")]
#endif
        public AccountBalance Balance { get; set; }

        /// <summary>
        /// The state of the most recent attempt to refresh the account balance.
        /// </summary>
        [JsonProperty("balance_refresh")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("balance_refresh")]
#endif
        public AccountBalanceRefresh BalanceRefresh { get; set; }

        /// <summary>
        /// The type of the account. Account category is further divided in <c>subcategory</c>.
        /// One of: <c>cash</c>, <c>credit</c>, <c>investment</c>, or <c>other</c>.
        /// </summary>
        [JsonProperty("category")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("category")]
#endif
        public string Category { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// A human-readable name that has been assigned to this account, either by the account
        /// holder or by the institution.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

        /// <summary>
        /// The state of the most recent attempt to refresh the account's inferred balance history.
        /// </summary>
        [JsonProperty("inferred_balances_refresh")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("inferred_balances_refresh")]
#endif
        public AccountInferredBalancesRefresh InferredBalancesRefresh { get; set; }

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
        /// The name of the institution that holds this account.
        /// </summary>
        [JsonProperty("institution_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("institution_name")]
#endif
        public string InstitutionName { get; set; }

        /// <summary>
        /// The last 4 digits of the account number. If present, this will be 4 numeric characters.
        /// </summary>
        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif
        public string Last4 { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        #region Expandable Ownership

        /// <summary>
        /// (ID of the AccountOwnership)
        /// The most recent information about the account's owners.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string OwnershipId
        {
            get => this.InternalOwnership?.Id;
            set => this.InternalOwnership = SetExpandableFieldId(value, this.InternalOwnership);
        }

        /// <summary>
        /// (Expanded)
        /// The most recent information about the account's owners.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AccountOwnership Ownership
        {
            get => this.InternalOwnership?.ExpandedObject;
            set => this.InternalOwnership = SetExpandableFieldObject(value, this.InternalOwnership);
        }

        [JsonProperty("ownership")]
        [JsonConverter(typeof(ExpandableFieldConverter<AccountOwnership>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ownership")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<AccountOwnership>))]
#endif
        internal ExpandableField<AccountOwnership> InternalOwnership { get; set; }
        #endregion

        /// <summary>
        /// The state of the most recent attempt to refresh the account owners.
        /// </summary>
        [JsonProperty("ownership_refresh")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ownership_refresh")]
#endif
        public AccountOwnershipRefresh OwnershipRefresh { get; set; }

        /// <summary>
        /// The list of permissions granted by this account.
        /// One of: <c>balances</c>, <c>ownership</c>, <c>payment_method</c>, or
        /// <c>transactions</c>.
        /// </summary>
        [JsonProperty("permissions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("permissions")]
#endif
        public List<string> Permissions { get; set; }

        /// <summary>
        /// The status of the link to the account.
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
        public AccountStatusDetails StatusDetails { get; set; }

        /// <summary>
        /// If <c>category</c> is <c>cash</c>, one of:.
        ///
        /// - <c>checking</c> - <c>savings</c> - <c>other</c>.
        ///
        /// If <c>category</c> is <c>credit</c>, one of:.
        ///
        /// - <c>mortgage</c> - <c>line_of_credit</c> - <c>credit_card</c> - <c>other</c>.
        ///
        /// If <c>category</c> is <c>investment</c> or <c>other</c>, this will be <c>other</c>.
        /// One of: <c>checking</c>, <c>credit_card</c>, <c>line_of_credit</c>, <c>mortgage</c>,
        /// <c>other</c>, or <c>savings</c>.
        /// </summary>
        [JsonProperty("subcategory")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subcategory")]
#endif
        public string Subcategory { get; set; }

        /// <summary>
        /// The list of data refresh subscriptions requested on this account.
        /// One of: <c>balance</c>, <c>inferred_balances</c>, or <c>transactions</c>.
        /// </summary>
        [JsonProperty("subscriptions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscriptions")]
#endif
        public List<string> Subscriptions { get; set; }

        /// <summary>
        /// The <a
        /// href="https://docs.stripe.com/api/payment_methods/object#payment_method_object-type">PaymentMethod
        /// type</a>(s) that can be created from this account.
        /// One of: <c>link</c>, or <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("supported_payment_method_types")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("supported_payment_method_types")]
#endif
        public List<string> SupportedPaymentMethodTypes { get; set; }

        /// <summary>
        /// The state of the most recent attempt to refresh the account transactions.
        /// </summary>
        [JsonProperty("transaction_refresh")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction_refresh")]
#endif
        public AccountTransactionRefresh TransactionRefresh { get; set; }
    }
}
