// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentRecordPaymentMethodDetailsUpi : StripeEntity<PaymentRecordPaymentMethodDetailsUpi>
    {
        /// <summary>
        /// Customer's unique Virtual Payment Address.
        /// </summary>
        [JsonProperty("vpa")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("vpa")]
#endif
        public string Vpa { get; set; }
    }
}
