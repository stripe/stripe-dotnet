// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderActionConfirmPaymentIntentConfirmConfig : StripeEntity<ReaderActionConfirmPaymentIntentConfirmConfig>
    {
        /// <summary>
        /// If the customer doesn't abandon authenticating the payment, they're redirected to this
        /// URL after completion.
        /// </summary>
        [JsonProperty("return_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("return_url")]
#endif
        public string ReturnUrl { get; set; }
    }
}
