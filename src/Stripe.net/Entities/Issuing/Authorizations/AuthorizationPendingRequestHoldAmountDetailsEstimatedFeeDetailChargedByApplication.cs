// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationPendingRequestHoldAmountDetailsEstimatedFeeDetailChargedByApplication : StripeEntity<AuthorizationPendingRequestHoldAmountDetailsEstimatedFeeDetailChargedByApplication>
    {
        /// <summary>
        /// Human-readable product name.
        /// </summary>
        [JsonProperty("feature_name")]
        [STJS.JsonPropertyName("feature_name")]
        public string FeatureName { get; set; }
    }
}
