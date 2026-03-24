// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentRecordPaymentMethodDetailsLink : StripeEntity<PaymentRecordPaymentMethodDetailsLink>
    {
        /// <summary>
        /// Two-letter ISO code representing the funding source country beneath the Link payment.
        /// You could use this attribute to get a sense of international fees.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }
    }
}
