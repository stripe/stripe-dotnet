// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentAttemptRecordPaymentMethodDetailsPaynow : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsPaynow>
    {
        /// <summary>
        /// ID of the <a href="https://stripe.com/docs/api/terminal/locations">location</a> that
        /// this transaction's reader is assigned to.
        /// </summary>
        [JsonProperty("location")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("location")]
#endif
        public string Location { get; set; }

        /// <summary>
        /// ID of the <a href="https://stripe.com/docs/api/terminal/readers">reader</a> this
        /// transaction was made on.
        /// </summary>
        [JsonProperty("reader")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reader")]
#endif
        public string Reader { get; set; }

        /// <summary>
        /// Reference number associated with this PayNow payment.
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif
        public string Reference { get; set; }
    }
}
