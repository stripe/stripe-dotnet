// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A Financial Connections Account represents an account that exists outside of Stripe, to
    /// which you have been granted some degree of access.
    /// </summary>
    public class Account : StripeEntity<Account>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// The account holder that this account belongs to.
        /// </summary>
        [JsonProperty("account_holder")]
        public AccountAccountHolder AccountHolder { get; set; }

        /// <summary>
        /// The most recent information about the account's balance.
        /// </summary>
        [JsonProperty("balance")]
        public AccountBalance Balance { get; set; }

        /// <summary>
        /// The state of the most recent attempt to refresh the account balance.
        /// </summary>
        [JsonProperty("balance_refresh")]
        public AccountBalanceRefresh BalanceRefresh { get; set; }

        /// <summary>
        /// The type of the account. Account category is further divided in <c>subcategory</c>.
        /// One of: <c>cash</c>, <c>credit</c>, <c>investment</c>, or <c>other</c>.
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// A human-readable name that has been assigned to this account, either by the account
        /// holder or by the institution.
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The name of the institution that holds this account.
        /// </summary>
        [JsonProperty("institution_name")]
        public string InstitutionName { get; set; }

        /// <summary>
        /// The last 4 digits of the account number. If present, this will be 4 numeric characters.
        /// </summary>
        [JsonProperty("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        #region Expandable Ownership

        /// <summary>
        /// (ID of the AccountOwnership)
        /// The most recent information about the account's owners.
        /// </summary>
        [JsonIgnore]
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
        public AccountOwnership Ownership
        {
            get => this.InternalOwnership?.ExpandedObject;
            set => this.InternalOwnership = SetExpandableFieldObject(value, this.InternalOwnership);
        }

        [JsonProperty("ownership")]
        [JsonConverter(typeof(ExpandableFieldConverter<AccountOwnership>))]
        internal ExpandableField<AccountOwnership> InternalOwnership { get; set; }
        #endregion

        /// <summary>
        /// The state of the most recent attempt to refresh the account owners.
        /// </summary>
        [JsonProperty("ownership_refresh")]
        public AccountOwnershipRefresh OwnershipRefresh { get; set; }

        /// <summary>
        /// The list of permissions granted by this account.
        /// One of: <c>balances</c>, <c>ownership</c>, <c>payment_method</c>, or
        /// <c>transactions</c>.
        /// </summary>
        [JsonProperty("permissions")]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// The status of the link to the account.
        /// One of: <c>active</c>, <c>disconnected</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

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
        public string Subcategory { get; set; }

        /// <summary>
        /// The <a
        /// href="https://stripe.com/docs/api/payment_methods/object#payment_method_object-type">PaymentMethod
        /// type</a>(s) that can be created from this account.
        /// One of: <c>link</c>, or <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("supported_payment_method_types")]
        public List<string> SupportedPaymentMethodTypes { get; set; }
    }
}
