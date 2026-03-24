// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReaderActionConfirmPaymentIntentConfirmConfig : StripeEntity<ReaderActionConfirmPaymentIntentConfirmConfig>
    {
        /// <summary>
        /// If the customer doesn't abandon authenticating the payment, they're redirected to this
        /// URL after completion.
        /// </summary>
        [JsonProperty("return_url")]
        [STJS.JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }
    }
}
