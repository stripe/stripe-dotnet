// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentAttemptRecordPaymentMethodDetailsAlmaInstallments : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsAlmaInstallments>
    {
        /// <summary>
        /// The number of installments.
        /// </summary>
        [JsonProperty("count")]
        [STJS.JsonPropertyName("count")]
        public long Count { get; set; }
    }
}
