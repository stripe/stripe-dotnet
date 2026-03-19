// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CreditBalanceSummaryBalanceAvailableBalance : StripeEntity<CreditBalanceSummaryBalanceAvailableBalance>
    {
        /// <summary>
        /// The monetary amount.
        /// </summary>
        [JsonProperty("monetary")]
        [STJS.JsonPropertyName("monetary")]
        public CreditBalanceSummaryBalanceAvailableBalanceMonetary Monetary { get; set; }

        /// <summary>
        /// The type of this amount. We currently only support <c>monetary</c> billing credits.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
