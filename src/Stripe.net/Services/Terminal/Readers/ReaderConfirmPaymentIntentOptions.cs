// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReaderConfirmPaymentIntentOptions : BaseOptions
    {
        /// <summary>
        /// Configuration overrides for this confirmation, such as surcharge settings and return
        /// URL.
        /// </summary>
        [JsonProperty("confirm_config")]
        [STJS.JsonPropertyName("confirm_config")]
        public ReaderConfirmConfigOptions ConfirmConfig { get; set; }

        /// <summary>
        /// The ID of the PaymentIntent to confirm.
        /// </summary>
        [JsonProperty("payment_intent")]
        [STJS.JsonPropertyName("payment_intent")]
        public string PaymentIntent { get; set; }
    }
}
