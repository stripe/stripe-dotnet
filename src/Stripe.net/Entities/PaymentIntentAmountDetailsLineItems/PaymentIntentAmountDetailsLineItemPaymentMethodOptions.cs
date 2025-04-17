// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentAmountDetailsLineItemPaymentMethodOptions : StripeEntity<PaymentIntentAmountDetailsLineItemPaymentMethodOptions>
    {
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public PaymentIntentAmountDetailsLineItemPaymentMethodOptionsCard Card { get; set; }

        [JsonProperty("klarna")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("klarna")]
#endif
        public PaymentIntentAmountDetailsLineItemPaymentMethodOptionsKlarna Klarna { get; set; }

        [JsonProperty("paypal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypal")]
#endif
        public PaymentIntentAmountDetailsLineItemPaymentMethodOptionsPaypal Paypal { get; set; }
    }
}
