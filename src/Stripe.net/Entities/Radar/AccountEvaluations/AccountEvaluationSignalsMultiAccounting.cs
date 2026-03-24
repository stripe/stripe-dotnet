// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountEvaluationSignalsMultiAccounting : StripeEntity<AccountEvaluationSignalsMultiAccounting>
    {
        /// <summary>
        /// Score for this signal (float between 0.0-100.0).
        /// </summary>
        [JsonProperty("score")]
        [STJS.JsonPropertyName("score")]
        public decimal Score { get; set; }
    }
}
