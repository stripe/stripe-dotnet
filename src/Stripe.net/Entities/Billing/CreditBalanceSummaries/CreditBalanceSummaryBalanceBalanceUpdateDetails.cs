// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CreditBalanceSummaryBalanceBalanceUpdateDetails : StripeEntity<CreditBalanceSummaryBalanceBalanceUpdateDetails>
    {
        /// <summary>
        /// The details of the most recent meter event included in the balance update.
        /// </summary>
        [JsonProperty("latest_meter_event")]
        [STJS.JsonPropertyName("latest_meter_event")]
        public CreditBalanceSummaryBalanceBalanceUpdateDetailsLatestMeterEvent LatestMeterEvent { get; set; }
    }
}
