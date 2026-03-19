// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentAttemptRecordPaymentMethodDetailsRevolutPayFunding : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsRevolutPayFunding>
    {
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public PaymentAttemptRecordPaymentMethodDetailsRevolutPayFundingCard Card { get; set; }

        /// <summary>
        /// funding type of the underlying payment method.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
