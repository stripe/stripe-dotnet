// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// Account Evaluation resource.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountEvaluation : StripeEntity<AccountEvaluation>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the account evaluation.
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
        /// The account ID if this evaluation is for an existing account.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Account data if this evaluation is for an account without an existing Stripe entity.
        /// </summary>
        [JsonProperty("account_data")]
        [STJS.JsonPropertyName("account_data")]
        public AccountEvaluationAccountData AccountData { get; set; }

        /// <summary>
        /// Timestamp at which the evaluation was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// List of signals that were triggered for evaluation.
        /// </summary>
        [JsonProperty("evaluations_triggered")]
        [STJS.JsonPropertyName("evaluations_triggered")]
        public List<string> EvaluationsTriggered { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }
    }
}
