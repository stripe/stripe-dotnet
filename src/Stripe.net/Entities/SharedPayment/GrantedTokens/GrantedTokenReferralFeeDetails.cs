// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GrantedTokenReferralFeeDetails : StripeEntity<GrantedTokenReferralFeeDetails>
    {
        [JsonProperty("rate")]
        [STJS.JsonPropertyName("rate")]
        public GrantedTokenReferralFeeDetailsRate Rate { get; set; }
    }
}
