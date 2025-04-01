// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentRecordPaymentMethodDetailsRevolutPayFunding : StripeEntity<PaymentRecordPaymentMethodDetailsRevolutPayFunding>
    {
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public PaymentRecordPaymentMethodDetailsRevolutPayFundingCard Card { get; set; }

        /// <summary>
        /// funding type of the underlying payment method.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
