// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodCardGeneratedFromPaymentMethodDetails : StripeEntity<PaymentMethodCardGeneratedFromPaymentMethodDetails>
    {
        [JsonProperty("card_present")]
        public PaymentMethodCardGeneratedFromPaymentMethodDetailsCardPresent CardPresent { get; set; }

        /// <summary>
        /// The type of payment method transaction-specific details from the transaction that
        /// generated this <c>card</c> payment method. Always <c>card_present</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
