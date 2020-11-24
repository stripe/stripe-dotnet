// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsSepaDebit : StripeEntity<PaymentIntentPaymentMethodOptionsSepaDebit>
    {
        [JsonProperty("mandate_options")]
        public PaymentIntentPaymentMethodOptionsSepaDebitMandateOptions MandateOptions { get; set; }
    }
}
