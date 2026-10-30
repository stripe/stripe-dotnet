// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FundingIntentSettlementTiming : StripeEntity<FundingIntentSettlementTiming>
    {
        /// <summary>
        /// The number of days to delay the availability of funds after processing completes.
        /// </summary>
        [JsonProperty("delay_days_override")]
        [STJS.JsonPropertyName("delay_days_override")]
        public long? DelayDaysOverride { get; set; }
    }
}
