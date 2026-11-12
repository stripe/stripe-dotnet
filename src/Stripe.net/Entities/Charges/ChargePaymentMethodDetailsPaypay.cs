// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ChargePaymentMethodDetailsPaypay : StripeEntity<ChargePaymentMethodDetailsPaypay>
    {
        /// <summary>
        /// Uniquely identifies this particular PayPay account. You can use this attribute to check
        /// whether two PayPay accounts are the same.
        /// </summary>
        [JsonProperty("fingerprint")]
        [STJS.JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }
    }
}
