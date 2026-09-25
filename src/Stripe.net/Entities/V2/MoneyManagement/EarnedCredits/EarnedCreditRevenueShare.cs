// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EarnedCreditRevenueShare : StripeEntity<EarnedCreditRevenueShare>
    {
        /// <summary>
        /// The type of revenue share that caused the EarnedCredit.
        /// One of: <c>administrative_facilitation_fee</c>, or <c>savings_referral</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
