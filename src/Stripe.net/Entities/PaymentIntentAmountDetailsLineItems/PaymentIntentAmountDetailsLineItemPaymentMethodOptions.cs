// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentAmountDetailsLineItemPaymentMethodOptions : StripeEntity<PaymentIntentAmountDetailsLineItemPaymentMethodOptions>
    {
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public PaymentIntentAmountDetailsLineItemPaymentMethodOptionsCard Card { get; set; }

        [JsonProperty("card_present")]
        [STJS.JsonPropertyName("card_present")]
        public PaymentIntentAmountDetailsLineItemPaymentMethodOptionsCardPresent CardPresent { get; set; }

        [JsonProperty("klarna")]
        [STJS.JsonPropertyName("klarna")]
        public PaymentIntentAmountDetailsLineItemPaymentMethodOptionsKlarna Klarna { get; set; }

        [JsonProperty("paypal")]
        [STJS.JsonPropertyName("paypal")]
        public PaymentIntentAmountDetailsLineItemPaymentMethodOptionsPaypal Paypal { get; set; }
    }
}
