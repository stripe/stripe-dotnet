namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptions : StripeEntity<PaymentIntentPaymentMethodOptions>
    {
        [JsonProperty("alipay")]
        public PaymentIntentPaymentMethodOptionsAlipay Alipay { get; set; }

        /// <summary>
        /// Configuration specific to Bancontact for this PaymentIntent.
        /// </summary>
        [JsonProperty("bancontact")]
        public PaymentIntentPaymentMethodOptionsBancontact Bancontact { get; set; }

        /// <summary>
        /// If the PaymentIntent's supported payment method types include <c>card</c>, this hash
        /// contains the configurations that will be applied to each payment attempt of that type.
        /// </summary>
        [JsonProperty("card")]
        public PaymentIntentPaymentMethodOptionsCard Card { get; set; }
    }
}
