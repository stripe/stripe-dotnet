// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OffSessionPaymentPaymentsOrchestration : StripeEntity<OffSessionPaymentPaymentsOrchestration>
    {
        /// <summary>
        /// True when you want to enable payments orchestration for this off-session payment. False
        /// otherwise.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
