// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountEvaluationSignalsMultiAccounting : StripeEntity<AccountEvaluationSignalsMultiAccounting>
    {
        /// <summary>
        /// Score for this signal (float between 0.0-100.0).
        /// </summary>
        [JsonProperty("score")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("score")]
#endif
        public decimal Score { get; set; }
    }
}
