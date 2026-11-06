// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentMethodOptionsCardPresentPaymentDetailsMoneyServices : StripeEntity<PaymentIntentPaymentMethodOptionsCardPresentPaymentDetailsMoneyServices>
    {
        [JsonProperty("account_funding")]
        [STJS.JsonPropertyName("account_funding")]
        public PaymentIntentPaymentMethodOptionsCardPresentPaymentDetailsMoneyServicesAccountFunding AccountFunding { get; set; }
    }
}
