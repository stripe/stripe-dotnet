// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IssuedTokenReferralFeeDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The Customer to be invoiced for fees assessed.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The account with a Customer configuration to be invoiced for fees assessed.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        /// <summary>
        /// The percentage of the payment to charge as a referral fee, from 0 through 50 with at
        /// most two decimal places.
        /// </summary>
        [JsonProperty("referral_fee_percent")]
        [STJS.JsonPropertyName("referral_fee_percent")]
        public decimal? ReferralFeePercent { get; set; }
    }
}
