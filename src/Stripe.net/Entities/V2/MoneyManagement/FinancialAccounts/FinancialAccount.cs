// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// A FinancialAccount represents a balance and can be used as the source or destination for
    /// the money management (<c>/v2/money_management</c>) APIs.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccount : StripeEntity<FinancialAccount>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// If this is a <c>accrued_fees</c> FinancialAccount, this hash include details specific to
        /// <c>accrued_fees</c> FinancialAccount.
        /// </summary>
        [JsonProperty("accrued_fees")]
        [STJS.JsonPropertyName("accrued_fees")]
        public FinancialAccountAccruedFees AccruedFees { get; set; }

        /// <summary>
        /// Multi-currency balance of this FinancialAccount, split by availability state. Each
        /// balance is represented as a hash where the key is the three-letter ISO currency code, in
        /// lowercase, and the value is the amount for that currency.
        /// </summary>
        [JsonProperty("balance")]
        [STJS.JsonPropertyName("balance")]
        public FinancialAccountBalance Balance { get; set; }

        /// <summary>
        /// Open Enum. Two-letter country code that represents the country where the LegalEntity
        /// associated with the FinancialAccount is based in.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// A descriptive name for the FinancialAccount, up to 50 characters long. This name will be
        /// used in the Stripe Dashboard and embedded components.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// If this is a managed FinancialAccount, <c>managed_by</c> indicates the product that
        /// created and manages this FinancialAccount. For managed FinancialAccounts, creation of
        /// money management resources can only be orchestrated by the managing product.
        /// </summary>
        [JsonProperty("managed_by")]
        [STJS.JsonPropertyName("managed_by")]
        public FinancialAccountManagedBy ManagedBy { get; set; }

        /// <summary>
        /// Metadata associated with the FinancialAccount.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// If this is a <c>other</c> FinancialAccount, this hash indicates what the actual type is.
        /// Upgrade your API version to see it reflected in <c>type</c>.
        /// </summary>
        [JsonProperty("other")]
        [STJS.JsonPropertyName("other")]
        public FinancialAccountOther Other { get; set; }

        /// <summary>
        /// If this is a <c>payments</c> FinancialAccount, this hash include details specific to
        /// <c>payments</c> FinancialAccount.
        /// </summary>
        [JsonProperty("payments")]
        [STJS.JsonPropertyName("payments")]
        public FinancialAccountPayments Payments { get; set; }

        /// <summary>
        /// Closed Enum. An enum representing the status of the FinancialAccount. This indicates
        /// whether or not the FinancialAccount can be used for any money movement flows.
        /// One of: <c>closed</c>, <c>open</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Additional details related to the status of the FinancialAccount.
        /// </summary>
        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public FinancialAccountStatusDetails StatusDetails { get; set; }

        /// <summary>
        /// If this is a <c>storage</c> FinancialAccount, this hash includes details specific to
        /// <c>storage</c> FinancialAccounts.
        /// </summary>
        [JsonProperty("storage")]
        [STJS.JsonPropertyName("storage")]
        public FinancialAccountStorage Storage { get; set; }

        /// <summary>
        /// Type of the FinancialAccount. An additional hash is included on the FinancialAccount
        /// with a name matching this value. It contains additional information specific to the
        /// FinancialAccount type.
        /// One of: <c>accrued_fees</c>, <c>other</c>, <c>payments</c>, or <c>storage</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
