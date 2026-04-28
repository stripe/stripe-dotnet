// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentNextAction : StripeEntity<PaymentIntentNextAction>
    {
        [JsonProperty("alipay_handle_redirect")]
        [STJS.JsonPropertyName("alipay_handle_redirect")]
        public PaymentIntentNextActionAlipayHandleRedirect AlipayHandleRedirect { get; set; }

        [JsonProperty("boleto_display_details")]
        [STJS.JsonPropertyName("boleto_display_details")]
        public PaymentIntentNextActionBoletoDisplayDetails BoletoDisplayDetails { get; set; }

        [JsonProperty("card_await_notification")]
        [STJS.JsonPropertyName("card_await_notification")]
        public PaymentIntentNextActionCardAwaitNotification CardAwaitNotification { get; set; }

        [JsonProperty("cashapp_handle_redirect_or_display_qr_code")]
        [STJS.JsonPropertyName("cashapp_handle_redirect_or_display_qr_code")]
        public PaymentIntentNextActionCashappHandleRedirectOrDisplayQrCode CashappHandleRedirectOrDisplayQrCode { get; set; }

        [JsonProperty("crypto_display_details")]
        [STJS.JsonPropertyName("crypto_display_details")]
        public PaymentIntentNextActionCryptoDisplayDetails CryptoDisplayDetails { get; set; }

        [JsonProperty("display_bank_transfer_instructions")]
        [STJS.JsonPropertyName("display_bank_transfer_instructions")]
        public PaymentIntentNextActionDisplayBankTransferInstructions DisplayBankTransferInstructions { get; set; }

        [JsonProperty("klarna_display_qr_code")]
        [STJS.JsonPropertyName("klarna_display_qr_code")]
        public PaymentIntentNextActionKlarnaDisplayQrCode KlarnaDisplayQrCode { get; set; }

        [JsonProperty("konbini_display_details")]
        [STJS.JsonPropertyName("konbini_display_details")]
        public PaymentIntentNextActionKonbiniDisplayDetails KonbiniDisplayDetails { get; set; }

        [JsonProperty("multibanco_display_details")]
        [STJS.JsonPropertyName("multibanco_display_details")]
        public PaymentIntentNextActionMultibancoDisplayDetails MultibancoDisplayDetails { get; set; }

        [JsonProperty("oxxo_display_details")]
        [STJS.JsonPropertyName("oxxo_display_details")]
        public PaymentIntentNextActionOxxoDisplayDetails OxxoDisplayDetails { get; set; }

        [JsonProperty("paynow_display_qr_code")]
        [STJS.JsonPropertyName("paynow_display_qr_code")]
        public PaymentIntentNextActionPaynowDisplayQrCode PaynowDisplayQrCode { get; set; }

        [JsonProperty("pix_display_qr_code")]
        [STJS.JsonPropertyName("pix_display_qr_code")]
        public PaymentIntentNextActionPixDisplayQrCode PixDisplayQrCode { get; set; }

        [JsonProperty("promptpay_display_qr_code")]
        [STJS.JsonPropertyName("promptpay_display_qr_code")]
        public PaymentIntentNextActionPromptpayDisplayQrCode PromptpayDisplayQrCode { get; set; }

        [JsonProperty("redirect_to_url")]
        [STJS.JsonPropertyName("redirect_to_url")]
        public PaymentIntentNextActionRedirectToUrl RedirectToUrl { get; set; }

        [JsonProperty("swish_handle_redirect_or_display_qr_code")]
        [STJS.JsonPropertyName("swish_handle_redirect_or_display_qr_code")]
        public PaymentIntentNextActionSwishHandleRedirectOrDisplayQrCode SwishHandleRedirectOrDisplayQrCode { get; set; }

        /// <summary>
        /// Type of the next action to perform. Refer to the other child attributes under
        /// <c>next_action</c> for available values. Examples include: <c>redirect_to_url</c>,
        /// <c>use_stripe_sdk</c>, <c>alipay_handle_redirect</c>, <c>oxxo_display_details</c>, or
        /// <c>verify_with_microdeposits</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonProperty("upi_handle_redirect_or_display_qr_code")]
        [STJS.JsonPropertyName("upi_handle_redirect_or_display_qr_code")]
        public PaymentIntentNextActionUpiHandleRedirectOrDisplayQrCode UpiHandleRedirectOrDisplayQrCode { get; set; }

        /// <summary>
        /// When confirming a PaymentIntent with Stripe.js, Stripe.js depends on the contents of
        /// this dictionary to invoke authentication flows. The shape of the contents is subject to
        /// change and is only intended to be used by Stripe.js.
        /// </summary>
        [JsonProperty("use_stripe_sdk")]
        [STJS.JsonPropertyName("use_stripe_sdk")]
        public Dictionary<string, object> UseStripeSdk { get; set; }

        [JsonProperty("verify_with_microdeposits")]
        [STJS.JsonPropertyName("verify_with_microdeposits")]
        public PaymentIntentNextActionVerifyWithMicrodeposits VerifyWithMicrodeposits { get; set; }

        [JsonProperty("wechat_pay_display_qr_code")]
        [STJS.JsonPropertyName("wechat_pay_display_qr_code")]
        public PaymentIntentNextActionWechatPayDisplayQrCode WechatPayDisplayQrCode { get; set; }

        [JsonProperty("wechat_pay_redirect_to_android_app")]
        [STJS.JsonPropertyName("wechat_pay_redirect_to_android_app")]
        public PaymentIntentNextActionWechatPayRedirectToAndroidApp WechatPayRedirectToAndroidApp { get; set; }

        [JsonProperty("wechat_pay_redirect_to_ios_app")]
        [STJS.JsonPropertyName("wechat_pay_redirect_to_ios_app")]
        public PaymentIntentNextActionWechatPayRedirectToIosApp WechatPayRedirectToIosApp { get; set; }
    }
}
