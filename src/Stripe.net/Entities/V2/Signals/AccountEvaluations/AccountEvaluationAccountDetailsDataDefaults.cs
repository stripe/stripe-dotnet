// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountEvaluationAccountDetailsDataDefaults : StripeEntity<AccountEvaluationAccountDetailsDataDefaults>
    {
        /// <summary>
        /// Account profile data.
        /// </summary>
        [JsonProperty("profile")]
        [STJS.JsonPropertyName("profile")]
        public AccountEvaluationAccountDetailsDataDefaultsProfile Profile { get; set; }
    }
}
