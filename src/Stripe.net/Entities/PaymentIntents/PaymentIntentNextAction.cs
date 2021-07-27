// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentNextAction : StripeEntity<PaymentIntentNextAction>
    {
        [JsonProperty("alipay_handle_redirect")]
        public PaymentIntentNextActionAlipayHandleRedirect AlipayHandleRedirect { get; set; }

        [JsonProperty("boleto_display_details")]
        public PaymentIntentNextActionBoletoDisplayDetails BoletoDisplayDetails { get; set; }

        [JsonProperty("oxxo_display_details")]
        public PaymentIntentNextActionOxxoDisplayDetails OxxoDisplayDetails { get; set; }

        [JsonProperty("redirect_to_url")]
        public PaymentIntentNextActionRedirectToUrl RedirectToUrl { get; set; }

        /// <summary>
        /// Type of the next action to perform, one of <c>redirect_to_url</c>,
        /// <c>use_stripe_sdk</c>, <c>alipay_handle_redirect</c>, or <c>oxxo_display_details</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("verify_with_microdeposits")]
        public PaymentIntentNextActionVerifyWithMicrodeposits VerifyWithMicrodeposits { get; set; }

        [JsonProperty("wechat_pay_display_qr_code")]
        public PaymentIntentNextActionWechatPayDisplayQrCode WechatPayDisplayQrCode { get; set; }

        [JsonProperty("wechat_pay_redirect_to_android_app")]
        public PaymentIntentNextActionWechatPayRedirectToAndroidApp WechatPayRedirectToAndroidApp { get; set; }

        [JsonProperty("wechat_pay_redirect_to_ios_app")]
        public PaymentIntentNextActionWechatPayRedirectToIosApp WechatPayRedirectToIosApp { get; set; }
    }
}
