// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentMethodOptionsVippsPaymentDetailsMoneyServices : StripeEntity<PaymentIntentPaymentMethodOptionsVippsPaymentDetailsMoneyServices>
    {
        [JsonProperty("account_funding")]
        [STJS.JsonPropertyName("account_funding")]
        public PaymentIntentPaymentMethodOptionsVippsPaymentDetailsMoneyServicesAccountFunding AccountFunding { get; set; }
    }
}
