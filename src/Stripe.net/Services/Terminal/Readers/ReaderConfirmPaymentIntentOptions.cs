// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderConfirmPaymentIntentOptions : BaseOptions
    {
        /// <summary>
        /// Configuration overrides for this confirmation, such as surcharge settings and return
        /// URL.
        /// </summary>
        [JsonProperty("confirm_config")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("confirm_config")]
#endif
        public ReaderConfirmConfigOptions ConfirmConfig { get; set; }

        /// <summary>
        /// The ID of the PaymentIntent to confirm.
        /// </summary>
        [JsonProperty("payment_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent")]
#endif
        public string PaymentIntent { get; set; }
    }
}
