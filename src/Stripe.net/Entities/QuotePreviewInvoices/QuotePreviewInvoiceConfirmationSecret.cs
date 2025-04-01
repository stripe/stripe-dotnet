// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuotePreviewInvoiceConfirmationSecret : StripeEntity<QuotePreviewInvoiceConfirmationSecret>
    {
        /// <summary>
        /// The client_secret of the payment that Stripe creates for the invoice after finalization.
        /// </summary>
        [JsonProperty("client_secret")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("client_secret")]
#endif
        public string ClientSecret { get; set; }

        /// <summary>
        /// The type of client_secret. Currently this is always payment_intent, referencing the
        /// default payment_intent that Stripe creates during invoice finalization.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
