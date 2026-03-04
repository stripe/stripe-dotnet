// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditBalanceSummaryBalanceBalanceUpdateDetails : StripeEntity<CreditBalanceSummaryBalanceBalanceUpdateDetails>
    {
        /// <summary>
        /// The details of the most recent meter event included in the balance update.
        /// </summary>
        [JsonProperty("latest_meter_event")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("latest_meter_event")]
#endif
        public CreditBalanceSummaryBalanceBalanceUpdateDetailsLatestMeterEvent LatestMeterEvent { get; set; }
    }
}
