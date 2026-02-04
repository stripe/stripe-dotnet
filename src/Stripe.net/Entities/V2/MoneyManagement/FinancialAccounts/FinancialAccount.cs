// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A FinancialAccount represents a balance and can be used as the source or destination for
    /// the money management (<c>/v2/money_management</c>) APIs.
    /// </summary>
    public class FinancialAccount : StripeEntity<FinancialAccount>, IHasId, IHasMetadata, IHasObject
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
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// If this is a <c>accrued_fees</c> FinancialAccount, this hash include details specific to
        /// <c>accrued_fees</c> FinancialAccount.
        /// </summary>
        [JsonProperty("accrued_fees")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("accrued_fees")]
#endif
        public FinancialAccountAccruedFees AccruedFees { get; set; }

        /// <summary>
        /// Multi-currency balance of this FinancialAccount, split by availability state. Each
        /// balance is represented as a hash where the key is the three-letter ISO currency code, in
        /// lowercase, and the value is the amount for that currency.
        /// </summary>
        [JsonProperty("balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("balance")]
#endif
        public FinancialAccountBalance Balance { get; set; }

        /// <summary>
        /// Open Enum. Two-letter country code that represents the country where the LegalEntity
        /// associated with the FinancialAccount is based in.
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        /// <summary>
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// A descriptive name for the FinancialAccount, up to 50 characters long. This name will be
        /// used in the Stripe Dashboard and embedded components.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

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
        /// If this is a managed FinancialAccount, <c>managed_by</c> indicates the product that
        /// created and manages this FinancialAccount. For managed FinancialAccounts, creation of
        /// money management resources can only be orchestrated by the managing product.
        /// </summary>
        [JsonProperty("managed_by")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("managed_by")]
#endif
        public FinancialAccountManagedBy ManagedBy { get; set; }

        /// <summary>
        /// Metadata associated with the FinancialAccount.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// If this is a <c>other</c> FinancialAccount, this hash indicates what the actual type is.
        /// Upgrade your API version to see it reflected in <c>type</c>.
        /// </summary>
        [JsonProperty("other")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("other")]
#endif
        public FinancialAccountOther Other { get; set; }

        /// <summary>
        /// If this is a <c>payments</c> FinancialAccount, this hash include details specific to
        /// <c>payments</c> FinancialAccount.
        /// </summary>
        [JsonProperty("payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payments")]
#endif
        public FinancialAccountPayments Payments { get; set; }

        /// <summary>
        /// Closed Enum. An enum representing the status of the FinancialAccount. This indicates
        /// whether or not the FinancialAccount can be used for any money movement flows.
        /// One of: <c>closed</c>, <c>open</c>, or <c>pending</c>.
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
        public FinancialAccountStatusDetails StatusDetails { get; set; }

        /// <summary>
        /// If this is a <c>storage</c> FinancialAccount, this hash includes details specific to
        /// <c>storage</c> FinancialAccounts.
        /// </summary>
        [JsonProperty("storage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("storage")]
#endif
        public FinancialAccountStorage Storage { get; set; }

        /// <summary>
        /// Type of the FinancialAccount. An additional hash is included on the FinancialAccount
        /// with a name matching this value. It contains additional information specific to the
        /// FinancialAccount type.
        /// One of: <c>accrued_fees</c>, <c>other</c>, <c>payments</c>, or <c>storage</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
