// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentAttemptRecordPaymentMethodDetailsCardChecks : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsCardChecks>
    {
        /// <summary>
        /// If you provide a value for <c>address.line1</c>, the check result is one of <c>pass</c>,
        /// <c>fail</c>, <c>unavailable</c>, or <c>unchecked</c>.
        /// One of: <c>fail</c>, <c>pass</c>, <c>unavailable</c>, or <c>unchecked</c>.
        /// </summary>
        [JsonProperty("address_line1_check")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_line1_check")]
#endif
        public string AddressLine1Check { get; set; }

        /// <summary>
        /// If you provide a address postal code, the check result is one of <c>pass</c>,
        /// <c>fail</c>, <c>unavailable</c>, or <c>unchecked</c>.
        /// One of: <c>fail</c>, <c>pass</c>, <c>unavailable</c>, or <c>unchecked</c>.
        /// </summary>
        [JsonProperty("address_postal_code_check")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_postal_code_check")]
#endif
        public string AddressPostalCodeCheck { get; set; }

        /// <summary>
        /// If you provide a CVC, the check results is one of <c>pass</c>, <c>fail</c>,
        /// <c>unavailable</c>, or <c>unchecked</c>.
        /// One of: <c>fail</c>, <c>pass</c>, <c>unavailable</c>, or <c>unchecked</c>.
        /// </summary>
        [JsonProperty("cvc_check")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cvc_check")]
#endif
        public string CvcCheck { get; set; }
    }
}
