// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentMethodDetailsCardChecks : StripeEntity<ChargePaymentMethodDetailsCardChecks>
    {
        /// <summary>
        /// If a address line1 was provided, results of the check, one of <c>pass</c>, <c>fail</c>,
        /// <c>unavailable</c>, or <c>unchecked</c>.
        /// </summary>
        [JsonProperty("address_line1_check")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_line1_check")]
#endif

        public string AddressLine1Check { get; set; }

        /// <summary>
        /// If a address postal code was provided, results of the check, one of <c>pass</c>,
        /// <c>fail</c>, <c>unavailable</c>, or <c>unchecked</c>.
        /// </summary>
        [JsonProperty("address_postal_code_check")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_postal_code_check")]
#endif

        public string AddressPostalCodeCheck { get; set; }

        /// <summary>
        /// If a CVC was provided, results of the check, one of <c>pass</c>, <c>fail</c>,
        /// <c>unavailable</c>, or <c>unchecked</c>.
        /// </summary>
        [JsonProperty("cvc_check")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cvc_check")]
#endif

        public string CvcCheck { get; set; }
    }
}
