// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IssuedTokenReferralFeeDetails : StripeEntity<IssuedTokenReferralFeeDetails>
    {
        /// <summary>
        /// The Customer to be invoiced for fees assessed.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The account to be invoiced for fees assessed.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        /// <summary>
        /// The percentage of the payment charged as a referral fee.
        /// </summary>
        [JsonProperty("referral_fee_percent")]
        [STJS.JsonPropertyName("referral_fee_percent")]
        public decimal ReferralFeePercent { get; set; }
    }
}
