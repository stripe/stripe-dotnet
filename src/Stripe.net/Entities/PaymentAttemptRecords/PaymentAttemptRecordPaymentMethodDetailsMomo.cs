// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentAttemptRecordPaymentMethodDetailsMomo : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsMomo>
    {
        /// <summary>
        /// Uniquely identifies this particular MoMo account. You can use this attribute to check
        /// whether two MoMo accounts are the same.
        /// </summary>
        [JsonProperty("fingerprint")]
        [STJS.JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// ID of the multi-use Mandate created by, or used to make, this MoMo payment.
        /// </summary>
        [JsonProperty("mandate")]
        [STJS.JsonPropertyName("mandate")]
        public string Mandate { get; set; }
    }
}
