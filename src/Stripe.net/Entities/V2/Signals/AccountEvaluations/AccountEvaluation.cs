// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Account Evaluation resource for the Signals API.
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
        /// Account activity recorded alongside this evaluation, when applicable.
        /// </summary>
        [JsonProperty("account_activity_details")]
        [STJS.JsonPropertyName("account_activity_details")]
        public AccountEvaluationAccountActivityDetails AccountActivityDetails { get; set; }

        /// <summary>
        /// The account, customer, or inline account data being evaluated.
        /// </summary>
        [JsonProperty("account_details")]
        [STJS.JsonPropertyName("account_details")]
        public AccountEvaluationAccountDetails AccountDetails { get; set; }

        /// <summary>
        /// Timestamp at which the evaluation was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Signal results that are available for the evaluation.
        /// </summary>
        [JsonProperty("evaluated_signals")]
        [STJS.JsonPropertyName("evaluated_signals")]
        public AccountEvaluationEvaluatedSignals EvaluatedSignals { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// List of signals still pending evaluation.
        /// One of: <c>fraudulent_website</c>, <c>user_account_sharing</c>, or
        /// <c>user_multi_accounting</c>.
        /// </summary>
        [JsonProperty("pending_signals")]
        [STJS.JsonPropertyName("pending_signals")]
        public List<string> PendingSignals { get; set; }

        /// <summary>
        /// List of signals requested for evaluation.
        /// One of: <c>fraudulent_website</c>, <c>user_account_sharing</c>, or
        /// <c>user_multi_accounting</c>.
        /// </summary>
        [JsonProperty("requested_signals")]
        [STJS.JsonPropertyName("requested_signals")]
        public List<string> RequestedSignals { get; set; }
    }
}
