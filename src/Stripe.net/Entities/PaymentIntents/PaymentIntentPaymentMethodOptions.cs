namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptions : StripeEntity<PaymentIntentPaymentMethodOptions>
    {
        [JsonProperty("alipay")]
        public PaymentIntentPaymentMethodOptionsAlipay Alipay { get; set; }

        [JsonProperty("bancontact")]
        public PaymentIntentPaymentMethodOptionsBancontact Bancontact { get; set; }

        [JsonProperty("card")]
        public PaymentIntentPaymentMethodOptionsCard Card { get; set; }
    }
}
