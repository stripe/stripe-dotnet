// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentAttemptRecordPaymentMethodDetailsKonbiniStore : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsKonbiniStore>
    {
        /// <summary>
        /// The name of the convenience store chain where the payment was completed.
        /// One of: <c>familymart</c>, <c>lawson</c>, <c>ministop</c>, or <c>seicomart</c>.
        /// </summary>
        [JsonProperty("chain")]
        [STJS.JsonPropertyName("chain")]
        public string Chain { get; set; }
    }
}
