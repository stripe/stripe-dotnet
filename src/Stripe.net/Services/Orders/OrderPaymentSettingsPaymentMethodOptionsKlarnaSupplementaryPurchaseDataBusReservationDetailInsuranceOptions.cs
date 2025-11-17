// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataBusReservationDetailInsuranceOptions : INestedOptions
    {
        /// <summary>
        /// Insurance currency.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Name of the company providing the insurance.
        /// </summary>
        [JsonProperty("insurance_company_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("insurance_company_name")]
#endif
        public string InsuranceCompanyName { get; set; }

        /// <summary>
        /// Type of insurance.
        /// One of: <c>baggage</c>, <c>bankruptcy</c>, <c>cancelation</c>, <c>emergency</c>, or
        /// <c>medical</c>.
        /// </summary>
        [JsonProperty("insurance_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("insurance_type")]
#endif
        public string InsuranceType { get; set; }

        /// <summary>
        /// Price of insurance in cents.
        /// </summary>
        [JsonProperty("price")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price")]
#endif
        public long? Price { get; set; }
    }
}
