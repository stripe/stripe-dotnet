// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentMethodOptionsCardPaymentDetailsMoneyServices : StripeEntity<PaymentIntentPaymentMethodOptionsCardPaymentDetailsMoneyServices>
    {
        [JsonProperty("account_funding")]
        [STJS.JsonPropertyName("account_funding")]
        public PaymentIntentPaymentMethodOptionsCardPaymentDetailsMoneyServicesAccountFunding AccountFunding { get; set; }
    }
}
