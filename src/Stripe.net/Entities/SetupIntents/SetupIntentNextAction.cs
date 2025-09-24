// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupIntentNextAction : StripeEntity<SetupIntentNextAction>
    {
        [JsonProperty("cashapp_handle_redirect_or_display_qr_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cashapp_handle_redirect_or_display_qr_code")]
#endif
        public SetupIntentNextActionCashappHandleRedirectOrDisplayQrCode CashappHandleRedirectOrDisplayQrCode { get; set; }

        [JsonProperty("redirect_to_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("redirect_to_url")]
#endif
        public SetupIntentNextActionRedirectToUrl RedirectToUrl { get; set; }

        /// <summary>
        /// Type of the next action to perform. Refer to the other child attributes under
        /// <c>next_action</c> for available values. Examples include: <c>redirect_to_url</c>,
        /// <c>use_stripe_sdk</c>, <c>alipay_handle_redirect</c>, <c>oxxo_display_details</c>, or
        /// <c>verify_with_microdeposits</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// When confirming a SetupIntent with Stripe.js, Stripe.js depends on the contents of this
        /// dictionary to invoke authentication flows. The shape of the contents is subject to
        /// change and is only intended to be used by Stripe.js.
        /// </summary>
        [JsonProperty("use_stripe_sdk")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("use_stripe_sdk")]
#endif
        public Dictionary<string, object> UseStripeSdk { get; set; }

        [JsonProperty("verify_with_microdeposits")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verify_with_microdeposits")]
#endif
        public SetupIntentNextActionVerifyWithMicrodeposits VerifyWithMicrodeposits { get; set; }
    }
}
