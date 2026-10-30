// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractTermAdHocProductServicePeriod : StripeEntity<ContractTermAdHocProductServicePeriod>
    {
        /// <summary>
        /// The exclusive end of the service period.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractTermAdHocProductServicePeriodEndsAt EndsAt { get; set; }

        /// <summary>
        /// The inclusive start of the service period.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public ContractTermAdHocProductServicePeriodStartsAt StartsAt { get; set; }
    }
}
