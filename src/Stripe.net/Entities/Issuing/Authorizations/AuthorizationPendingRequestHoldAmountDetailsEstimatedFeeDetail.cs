// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationPendingRequestHoldAmountDetailsEstimatedFeeDetail : StripeEntity<AuthorizationPendingRequestHoldAmountDetailsEstimatedFeeDetail>
    {
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public AuthorizationPendingRequestHoldAmountDetailsEstimatedFeeDetailAmount Amount { get; set; }

        [JsonProperty("charged_by")]
        [STJS.JsonPropertyName("charged_by")]
        public AuthorizationPendingRequestHoldAmountDetailsEstimatedFeeDetailChargedBy ChargedBy { get; set; }

        /// <summary>
        /// The category of this fee.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
