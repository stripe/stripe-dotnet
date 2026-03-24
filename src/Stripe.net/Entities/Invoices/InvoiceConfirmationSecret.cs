// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceConfirmationSecret : StripeEntity<InvoiceConfirmationSecret>
    {
        /// <summary>
        /// The client_secret of the payment that Stripe creates for the invoice after finalization.
        /// </summary>
        [JsonProperty("client_secret")]
        [STJS.JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// The type of client_secret. Currently this is always payment_intent, referencing the
        /// default payment_intent that Stripe creates during invoice finalization.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
