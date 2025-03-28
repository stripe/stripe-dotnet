// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentRecordPaymentMethodDetailsCardChecks : StripeEntity<PaymentRecordPaymentMethodDetailsCardChecks>
    {
        /// <summary>
        /// One of: <c>fail</c>, <c>pass</c>, <c>unavailable</c>, or <c>unchecked</c>.
        /// </summary>
        [JsonProperty("address_line1_check")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_line1_check")]
#endif
        public string AddressLine1Check { get; set; }

        /// <summary>
        /// One of: <c>fail</c>, <c>pass</c>, <c>unavailable</c>, or <c>unchecked</c>.
        /// </summary>
        [JsonProperty("address_postal_code_check")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_postal_code_check")]
#endif
        public string AddressPostalCodeCheck { get; set; }

        /// <summary>
        /// One of: <c>fail</c>, <c>pass</c>, <c>unavailable</c>, or <c>unchecked</c>.
        /// </summary>
        [JsonProperty("cvc_check")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cvc_check")]
#endif
        public string CvcCheck { get; set; }
    }
}
