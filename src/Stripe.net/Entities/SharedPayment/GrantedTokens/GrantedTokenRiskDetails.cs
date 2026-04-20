// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GrantedTokenRiskDetails : StripeEntity<GrantedTokenRiskDetails>
    {
        /// <summary>
        /// Risk insights for this token, including scores and recommended actions for each risk
        /// type.
        /// </summary>
        [JsonProperty("insights")]
        [STJS.JsonPropertyName("insights")]
        public GrantedTokenRiskDetailsInsights Insights { get; set; }
    }
}
