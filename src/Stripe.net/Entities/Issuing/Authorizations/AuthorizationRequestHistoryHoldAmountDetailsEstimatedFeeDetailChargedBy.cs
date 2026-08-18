// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationRequestHistoryHoldAmountDetailsEstimatedFeeDetailChargedBy : StripeEntity<AuthorizationRequestHistoryHoldAmountDetailsEstimatedFeeDetailChargedBy>
    {
        /// <summary>
        /// Details for a fee charged by a Connect application.
        /// </summary>
        [JsonProperty("application")]
        [STJS.JsonPropertyName("application")]
        public AuthorizationRequestHistoryHoldAmountDetailsEstimatedFeeDetailChargedByApplication Application { get; set; }

        /// <summary>
        /// The type of entity that charged this fee.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
