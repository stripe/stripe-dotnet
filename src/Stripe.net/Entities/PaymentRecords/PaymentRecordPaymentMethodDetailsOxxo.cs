// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentRecordPaymentMethodDetailsOxxo : StripeEntity<PaymentRecordPaymentMethodDetailsOxxo>
    {
        /// <summary>
        /// OXXO reference number.
        /// </summary>
        [JsonProperty("number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("number")]
#endif
        public string Number { get; set; }
    }
}
