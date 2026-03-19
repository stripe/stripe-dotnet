// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SetupIntentNextAction : StripeEntity<SetupIntentNextAction>
    {
        [JsonProperty("cashapp_handle_redirect_or_display_qr_code")]
        [STJS.JsonPropertyName("cashapp_handle_redirect_or_display_qr_code")]
        public SetupIntentNextActionCashappHandleRedirectOrDisplayQrCode CashappHandleRedirectOrDisplayQrCode { get; set; }

        [JsonProperty("pix_display_qr_code")]
        [STJS.JsonPropertyName("pix_display_qr_code")]
        public SetupIntentNextActionPixDisplayQrCode PixDisplayQrCode { get; set; }

        [JsonProperty("redirect_to_url")]
        [STJS.JsonPropertyName("redirect_to_url")]
        public SetupIntentNextActionRedirectToUrl RedirectToUrl { get; set; }

        /// <summary>
        /// Type of the next action to perform. Refer to the other child attributes under
        /// <c>next_action</c> for available values. Examples include: <c>redirect_to_url</c>,
        /// <c>use_stripe_sdk</c>, <c>alipay_handle_redirect</c>, <c>oxxo_display_details</c>, or
        /// <c>verify_with_microdeposits</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// When confirming a SetupIntent with Stripe.js, Stripe.js depends on the contents of this
        /// dictionary to invoke authentication flows. The shape of the contents is subject to
        /// change and is only intended to be used by Stripe.js.
        /// </summary>
        [JsonProperty("use_stripe_sdk")]
        [STJS.JsonPropertyName("use_stripe_sdk")]
        public Dictionary<string, object> UseStripeSdk { get; set; }

        [JsonProperty("verify_with_microdeposits")]
        [STJS.JsonPropertyName("verify_with_microdeposits")]
        public SetupIntentNextActionVerifyWithMicrodeposits VerifyWithMicrodeposits { get; set; }
    }
}
