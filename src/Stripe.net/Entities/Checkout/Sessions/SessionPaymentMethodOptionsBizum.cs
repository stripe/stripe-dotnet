// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionPaymentMethodOptionsBizum : StripeEntity<SessionPaymentMethodOptionsBizum>
    {
        [JsonProperty("mandate_options")]
        [STJS.JsonPropertyName("mandate_options")]
        public SessionPaymentMethodOptionsBizumMandateOptions MandateOptions { get; set; }
    }
}
