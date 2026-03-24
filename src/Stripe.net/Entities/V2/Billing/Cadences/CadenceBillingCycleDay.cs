// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CadenceBillingCycleDay : StripeEntity<CadenceBillingCycleDay>
    {
        /// <summary>
        /// The time at which the billing cycle ends.
        /// </summary>
        [JsonProperty("time")]
        [STJS.JsonPropertyName("time")]
        public CadenceBillingCycleDayTime Time { get; set; }
    }
}
