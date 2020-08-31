namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// If this is a <c>alipay</c> PaymentMethod, this sub-hash contains details about the
        /// Alipay payment method options.
        /// </summary>
        [JsonProperty("alipay")]
        public PaymentIntentPaymentMethodOptionsAlipayOptions Alipay { get; set; }

        /// <summary>
        /// If this is a <c>bancontact</c> PaymentMethod, this sub-hash contains details about the
        /// Bancontact payment method options.
        /// </summary>
        [JsonProperty("bancontact")]
        public PaymentIntentPaymentMethodOptionsBancontactOptions Bancontact { get; set; }

        /// <summary>
        /// Configuration for any card payments attempted on this PaymentIntent.
        /// </summary>
        [JsonProperty("card")]
        public PaymentIntentPaymentMethodOptionsCardOptions Card { get; set; }
    }
}
