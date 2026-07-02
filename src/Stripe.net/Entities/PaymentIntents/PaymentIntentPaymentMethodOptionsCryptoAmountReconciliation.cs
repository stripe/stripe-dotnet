// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentMethodOptionsCryptoAmountReconciliation : StripeEntity<PaymentIntentPaymentMethodOptionsCryptoAmountReconciliation>
    {
        /// <summary>
        /// Controls how crypto funding amounts are reconciled for the PaymentIntent.
        /// One of: <c>accept_partial_funding</c>, or <c>exact</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
