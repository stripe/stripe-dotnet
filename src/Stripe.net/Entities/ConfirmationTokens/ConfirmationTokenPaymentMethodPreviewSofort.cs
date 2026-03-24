// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConfirmationTokenPaymentMethodPreviewSofort : StripeEntity<ConfirmationTokenPaymentMethodPreviewSofort>
    {
        /// <summary>
        /// Two-letter ISO code representing the country the bank account is located in.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }
    }
}
