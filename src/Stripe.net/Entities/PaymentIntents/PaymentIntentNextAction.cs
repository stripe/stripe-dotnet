// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextAction : StripeEntity<PaymentIntentNextAction>
    {
        [JsonProperty("alipay_handle_redirect")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alipay_handle_redirect")]
#endif

        public PaymentIntentNextActionAlipayHandleRedirect AlipayHandleRedirect { get; set; }

        [JsonProperty("boleto_display_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("boleto_display_details")]
#endif

        public PaymentIntentNextActionBoletoDisplayDetails BoletoDisplayDetails { get; set; }

        [JsonProperty("card_await_notification")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_await_notification")]
#endif

        public PaymentIntentNextActionCardAwaitNotification CardAwaitNotification { get; set; }

        [JsonProperty("cashapp_handle_redirect_or_display_qr_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cashapp_handle_redirect_or_display_qr_code")]
#endif

        public PaymentIntentNextActionCashappHandleRedirectOrDisplayQrCode CashappHandleRedirectOrDisplayQrCode { get; set; }

        [JsonProperty("display_bank_transfer_instructions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_bank_transfer_instructions")]
#endif

        public PaymentIntentNextActionDisplayBankTransferInstructions DisplayBankTransferInstructions { get; set; }

        [JsonProperty("konbini_display_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("konbini_display_details")]
#endif

        public PaymentIntentNextActionKonbiniDisplayDetails KonbiniDisplayDetails { get; set; }

        [JsonProperty("multibanco_display_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("multibanco_display_details")]
#endif

        public PaymentIntentNextActionMultibancoDisplayDetails MultibancoDisplayDetails { get; set; }

        [JsonProperty("oxxo_display_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("oxxo_display_details")]
#endif

        public PaymentIntentNextActionOxxoDisplayDetails OxxoDisplayDetails { get; set; }

        [JsonProperty("paynow_display_qr_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paynow_display_qr_code")]
#endif

        public PaymentIntentNextActionPaynowDisplayQrCode PaynowDisplayQrCode { get; set; }

        [JsonProperty("pix_display_qr_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pix_display_qr_code")]
#endif

        public PaymentIntentNextActionPixDisplayQrCode PixDisplayQrCode { get; set; }

        [JsonProperty("promptpay_display_qr_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("promptpay_display_qr_code")]
#endif

        public PaymentIntentNextActionPromptpayDisplayQrCode PromptpayDisplayQrCode { get; set; }

        [JsonProperty("redirect_to_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("redirect_to_url")]
#endif

        public PaymentIntentNextActionRedirectToUrl RedirectToUrl { get; set; }

        [JsonProperty("swish_handle_redirect_or_display_qr_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("swish_handle_redirect_or_display_qr_code")]
#endif

        public PaymentIntentNextActionSwishHandleRedirectOrDisplayQrCode SwishHandleRedirectOrDisplayQrCode { get; set; }

        /// <summary>
        /// Type of the next action to perform, one of <c>redirect_to_url</c>,
        /// <c>use_stripe_sdk</c>, <c>alipay_handle_redirect</c>, <c>oxxo_display_details</c>, or
        /// <c>verify_with_microdeposits</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }

        /// <summary>
        /// When confirming a PaymentIntent with Stripe.js, Stripe.js depends on the contents of
        /// this dictionary to invoke authentication flows. The shape of the contents is subject to
        /// change and is only intended to be used by Stripe.js.
        /// </summary>
        [JsonProperty("use_stripe_sdk")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("use_stripe_sdk")]
#endif

        public PaymentIntentNextActionUseStripeSdk UseStripeSdk { get; set; }

        [JsonProperty("verify_with_microdeposits")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verify_with_microdeposits")]
#endif

        public PaymentIntentNextActionVerifyWithMicrodeposits VerifyWithMicrodeposits { get; set; }

        [JsonProperty("wechat_pay_display_qr_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wechat_pay_display_qr_code")]
#endif

        public PaymentIntentNextActionWechatPayDisplayQrCode WechatPayDisplayQrCode { get; set; }

        [JsonProperty("wechat_pay_redirect_to_android_app")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wechat_pay_redirect_to_android_app")]
#endif

        public PaymentIntentNextActionWechatPayRedirectToAndroidApp WechatPayRedirectToAndroidApp { get; set; }

        [JsonProperty("wechat_pay_redirect_to_ios_app")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wechat_pay_redirect_to_ios_app")]
#endif

        public PaymentIntentNextActionWechatPayRedirectToIosApp WechatPayRedirectToIosApp { get; set; }
    }
}
