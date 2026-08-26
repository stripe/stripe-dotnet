// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountEvaluationCreateOptions : BaseOptions
    {
        /// <summary>
        /// Account activity to record alongside this evaluation.
        /// </summary>
        [JsonProperty("account_activity_details")]
        [STJS.JsonPropertyName("account_activity_details")]
        public AccountEvaluationCreateAccountActivityDetailsOptions AccountActivityDetails { get; set; }

        /// <summary>
        /// The account, customer, or inline account data to evaluate.
        /// </summary>
        [JsonProperty("account_details")]
        [STJS.JsonPropertyName("account_details")]
        public AccountEvaluationCreateAccountDetailsOptions AccountDetails { get; set; }

        /// <summary>
        /// List of signals to evaluate.
        /// One of: <c>user_account_sharing</c>, or <c>user_multi_accounting</c>.
        /// </summary>
        [JsonProperty("requested_signals")]
        [STJS.JsonPropertyName("requested_signals")]
        public List<string> RequestedSignals { get; set; }
    }
}
