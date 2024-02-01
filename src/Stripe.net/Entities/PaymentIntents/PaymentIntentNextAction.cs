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

        [JsonProperty("card_await_notification")]
        public PaymentIntentNextActionCardAwaitNotification CardAwaitNotification { get; set; }

        [JsonProperty("cashapp_handle_redirect_or_display_qr_code")]
        public PaymentIntentNextActionCashappHandleRedirectOrDisplayQrCode CashappHandleRedirectOrDisplayQrCode { get; set; }

        [JsonProperty("display_bank_transfer_instructions")]
        public PaymentIntentNextActionDisplayBankTransferInstructions DisplayBankTransferInstructions { get; set; }

        [JsonProperty("konbini_display_details")]
        public PaymentIntentNextActionKonbiniDisplayDetails KonbiniDisplayDetails { get; set; }

        [JsonProperty("oxxo_display_details")]
        public PaymentIntentNextActionOxxoDisplayDetails OxxoDisplayDetails { get; set; }

        [JsonProperty("paynow_display_qr_code")]
        public PaymentIntentNextActionPaynowDisplayQrCode PaynowDisplayQrCode { get; set; }

        [JsonProperty("pix_display_qr_code")]
        public PaymentIntentNextActionPixDisplayQrCode PixDisplayQrCode { get; set; }

        [JsonProperty("promptpay_display_qr_code")]
        public PaymentIntentNextActionPromptpayDisplayQrCode PromptpayDisplayQrCode { get; set; }

        [JsonProperty("redirect_to_url")]
        public PaymentIntentNextActionRedirectToUrl RedirectToUrl { get; set; }

        [JsonProperty("swish_handle_redirect_or_display_qr_code")]
        public PaymentIntentNextActionSwishHandleRedirectOrDisplayQrCode SwishHandleRedirectOrDisplayQrCode { get; set; }

        /// <summary>
        /// Type of the next action to perform, one of <c>redirect_to_url</c>,
        /// <c>use_stripe_sdk</c>, <c>alipay_handle_redirect</c>, <c>oxxo_display_details</c>, or
        /// <c>verify_with_microdeposits</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// When confirming a PaymentIntent with Stripe.js, Stripe.js depends on the contents of
        /// this dictionary to invoke authentication flows. The shape of the contents is subject to
        /// change and is only intended to be used by Stripe.js.
        /// </summary>
        [JsonProperty("use_stripe_sdk")]
        public PaymentIntentNextActionUseStripeSdk UseStripeSdk { get; set; }

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
