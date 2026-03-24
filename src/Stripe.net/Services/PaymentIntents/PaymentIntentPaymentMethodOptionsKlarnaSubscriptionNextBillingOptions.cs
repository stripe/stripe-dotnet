// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsKlarnaSubscriptionNextBillingOptions : INestedOptions
    {
        /// <summary>
        /// The amount of the next charge for the subscription.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The date of the next charge for the subscription in YYYY-MM-DD format.
        /// </summary>
        [JsonProperty("date")]
        [STJS.JsonPropertyName("date")]
        public string Date { get; set; }
    }
}
