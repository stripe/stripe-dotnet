// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GrantedTokenReferralFeeDetailsRate : StripeEntity<GrantedTokenReferralFeeDetailsRate>
    {
        /// <summary>
        /// The percentage of the payment amount which will be calculated as a fee.
        /// </summary>
        [JsonProperty("percentage")]
        [STJS.JsonPropertyName("percentage")]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// The type of fee rate.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
