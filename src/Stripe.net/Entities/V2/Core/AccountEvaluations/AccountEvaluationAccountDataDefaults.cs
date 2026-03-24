// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountEvaluationAccountDataDefaults : StripeEntity<AccountEvaluationAccountDataDefaults>
    {
        /// <summary>
        /// Account profile data.
        /// </summary>
        [JsonProperty("profile")]
        [STJS.JsonPropertyName("profile")]
        public AccountEvaluationAccountDataDefaultsProfile Profile { get; set; }
    }
}
