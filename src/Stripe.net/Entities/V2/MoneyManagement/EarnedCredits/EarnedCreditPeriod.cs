// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EarnedCreditPeriod : StripeEntity<EarnedCreditPeriod>
    {
        /// <summary>
        /// The end date of the period during which the credit was earned, inclusive.
        /// </summary>
        [JsonProperty("end_date")]
        [STJS.JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// The start date of the period during which the credit was earned, inclusive.
        /// </summary>
        [JsonProperty("start_date")]
        [STJS.JsonPropertyName("start_date")]
        public string StartDate { get; set; }
    }
}
