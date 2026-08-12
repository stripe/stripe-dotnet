// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationPendingRequestHoldAmountDetails : StripeEntity<AuthorizationPendingRequestHoldAmountDetails>
    {
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public AuthorizationPendingRequestHoldAmountDetailsNetwork Network { get; set; }

        /// <summary>
        /// The reserve amount held for this authorization. Present for certain MCCs that may have
        /// overcaptures.
        /// </summary>
        [JsonProperty("reserve")]
        [STJS.JsonPropertyName("reserve")]
        public AuthorizationPendingRequestHoldAmountDetailsReserve Reserve { get; set; }
    }
}
