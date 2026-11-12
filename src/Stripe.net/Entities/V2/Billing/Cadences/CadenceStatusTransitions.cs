// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CadenceStatusTransitions : StripeEntity<CadenceStatusTransitions>
    {
        /// <summary>
        /// When the billing cadence status transitioned to activated.
        /// </summary>
        [JsonProperty("activated_at")]
        [STJS.JsonPropertyName("activated_at")]
        public string ActivatedAt { get; set; }

        /// <summary>
        /// When the billing cadence status transitioned to canceled.
        /// </summary>
        [JsonProperty("canceled_at")]
        [STJS.JsonPropertyName("canceled_at")]
        public string CanceledAt { get; set; }
    }
}
