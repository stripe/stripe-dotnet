// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentAttemptRecordPaymentMethodDetailsPaypay : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsPaypay>
    {
        /// <summary>
        /// ID of the multi-use Mandate created by, or used to make, this PayPay payment.
        /// </summary>
        [JsonProperty("mandate")]
        [STJS.JsonPropertyName("mandate")]
        public string Mandate { get; set; }
    }
}
