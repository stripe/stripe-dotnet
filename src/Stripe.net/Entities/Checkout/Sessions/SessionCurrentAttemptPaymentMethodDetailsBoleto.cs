// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionCurrentAttemptPaymentMethodDetailsBoleto : StripeEntity<SessionCurrentAttemptPaymentMethodDetailsBoleto>
    {
        /// <summary>
        /// Uniquely identifies this particular boleto payment method. You can use this attribute to
        /// check whether two boleto payment methods are the same.
        /// </summary>
        [JsonProperty("fingerprint")]
        [STJS.JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }
    }
}
