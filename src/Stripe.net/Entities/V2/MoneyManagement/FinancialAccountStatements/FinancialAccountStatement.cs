// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Financial Account Statement represents a monthly statement for a Financial Account.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountStatement : StripeEntity<FinancialAccountStatement>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the statement.
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
        /// Time at which the statement was created, in ISO 8601 format (UTC).
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Available balance at the end of the statement period.
        /// </summary>
        [JsonProperty("ending_balance")]
        [STJS.JsonPropertyName("ending_balance")]
        public Dictionary<string, V2.Amount> EndingBalance { get; set; }

        /// <summary>
        /// Currency-specific files and file metadata. Null by default, populated by specifying
        /// include=files_by_currency in the Retrieve endpoint.
        /// </summary>
        [JsonProperty("files_by_currency")]
        [STJS.JsonPropertyName("files_by_currency")]
        public Dictionary<string, FinancialAccountStatementFilesByCurrency> FilesByCurrency { get; set; }

        /// <summary>
        /// The Financial Account this statement belongs to.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// True if the object exists in live mode, false if in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The time period covered by this statement.
        /// </summary>
        [JsonProperty("period")]
        [STJS.JsonPropertyName("period")]
        public FinancialAccountStatementPeriod Period { get; set; }

        /// <summary>
        /// The ID of the statement that replaced this one. Only present on statements that have
        /// been restated.
        /// </summary>
        [JsonProperty("restated_by")]
        [STJS.JsonPropertyName("restated_by")]
        public string RestatedBy { get; set; }

        /// <summary>
        /// The ID of the statement this one replaces. Only present on restatements.
        /// </summary>
        [JsonProperty("restated_statement")]
        [STJS.JsonPropertyName("restated_statement")]
        public string RestatedStatement { get; set; }

        /// <summary>
        /// Available balance at the start of the statement period.
        /// </summary>
        [JsonProperty("starting_balance")]
        [STJS.JsonPropertyName("starting_balance")]
        public Dictionary<string, V2.Amount> StartingBalance { get; set; }

        /// <summary>
        /// The status of the statement. A statement is "active" by default. When a statement is
        /// replaced by a restatement, its status becomes "restated".
        /// One of: <c>active</c>, or <c>restated</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
