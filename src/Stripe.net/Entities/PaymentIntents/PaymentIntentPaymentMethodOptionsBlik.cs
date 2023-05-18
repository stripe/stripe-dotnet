// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsBlik : StripeEntity<PaymentIntentPaymentMethodOptionsBlik>
    {
        [JsonProperty("mandate_options")]
        public PaymentIntentPaymentMethodOptionsBlikMandateOptions MandateOptions { get; set; }
    }
}
