// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationPendingRequestHoldAmountDetails : StripeEntity<AuthorizationPendingRequestHoldAmountDetails>
    {
        /// <summary>
        /// Advisory estimate of total fees for this authorization request.
        /// </summary>
        [JsonProperty("estimated_fee")]
        [STJS.JsonPropertyName("estimated_fee")]
        public AuthorizationPendingRequestHoldAmountDetailsEstimatedFee EstimatedFee { get; set; }

        /// <summary>
        /// Per-fee-type breakdown of the estimated fees for this authorization request.
        /// </summary>
        [JsonProperty("estimated_fee_details")]
        [STJS.JsonPropertyName("estimated_fee_details")]
        public List<AuthorizationPendingRequestHoldAmountDetailsEstimatedFeeDetail> EstimatedFeeDetails { get; set; }

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
