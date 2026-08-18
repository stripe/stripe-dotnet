// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationRequestHistoryHoldAmountDetailsEstimatedFeeDetail : StripeEntity<AuthorizationRequestHistoryHoldAmountDetailsEstimatedFeeDetail>
    {
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public AuthorizationRequestHistoryHoldAmountDetailsEstimatedFeeDetailAmount Amount { get; set; }

        [JsonProperty("charged_by")]
        [STJS.JsonPropertyName("charged_by")]
        public AuthorizationRequestHistoryHoldAmountDetailsEstimatedFeeDetailChargedBy ChargedBy { get; set; }

        /// <summary>
        /// The category of this fee.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
