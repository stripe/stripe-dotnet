// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountEvaluationAccountActivityDetails : StripeEntity<AccountEvaluationAccountActivityDetails>
    {
        /// <summary>
        /// The ID of the account activity created or associated with the evaluation.
        /// </summary>
        [JsonProperty("account_activity")]
        [STJS.JsonPropertyName("account_activity")]
        public string AccountActivity { get; set; }
    }
}
