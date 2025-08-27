// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentRecordPaymentMethodDetailsAlmaInstallments : StripeEntity<PaymentRecordPaymentMethodDetailsAlmaInstallments>
    {
        /// <summary>
        /// The number of installments.
        /// </summary>
        [JsonProperty("count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("count")]
#endif
        public long Count { get; set; }
    }
}
