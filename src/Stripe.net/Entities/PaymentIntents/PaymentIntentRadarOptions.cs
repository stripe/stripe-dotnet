// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentRadarOptions : StripeEntity<PaymentIntentRadarOptions>
    {
        /// <summary>
        /// The value you provided for whether this transaction starts a free trial. This field is
        /// omitted if you haven't explicitly set it.
        /// </summary>
        [JsonProperty("is_free_trial_transaction")]
        [STJS.JsonPropertyName("is_free_trial_transaction")]
        public bool IsFreeTrialTransaction { get; set; }
    }
}
