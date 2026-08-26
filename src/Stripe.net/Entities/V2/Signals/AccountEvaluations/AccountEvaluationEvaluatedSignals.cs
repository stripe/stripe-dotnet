// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountEvaluationEvaluatedSignals : StripeEntity<AccountEvaluationEvaluatedSignals>
    {
        /// <summary>
        /// User account-sharing result for the evaluation, when available.
        /// </summary>
        [JsonProperty("user_account_sharing")]
        [STJS.JsonPropertyName("user_account_sharing")]
        public AccountEvaluationEvaluatedSignalsUserAccountSharing UserAccountSharing { get; set; }

        /// <summary>
        /// User multi-accounting result for the evaluation, when available.
        /// </summary>
        [JsonProperty("user_multi_accounting")]
        [STJS.JsonPropertyName("user_multi_accounting")]
        public AccountEvaluationEvaluatedSignalsUserMultiAccounting UserMultiAccounting { get; set; }
    }
}
