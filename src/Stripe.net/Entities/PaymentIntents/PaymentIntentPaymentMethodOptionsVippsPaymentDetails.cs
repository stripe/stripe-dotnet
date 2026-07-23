// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentMethodOptionsVippsPaymentDetails : StripeEntity<PaymentIntentPaymentMethodOptionsVippsPaymentDetails>
    {
        [JsonProperty("money_services")]
        [STJS.JsonPropertyName("money_services")]
        public PaymentIntentPaymentMethodOptionsVippsPaymentDetailsMoneyServices MoneyServices { get; set; }
    }
}
