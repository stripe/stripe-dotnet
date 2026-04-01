// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsCardPresentPaymentDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Money services details for payment method specific funding fields.
        /// </summary>
        [JsonProperty("money_services")]
        [STJS.JsonPropertyName("money_services")]
        public PaymentIntentPaymentMethodOptionsCardPresentPaymentDetailsMoneyServicesOptions MoneyServices { get; set; }
    }
}
