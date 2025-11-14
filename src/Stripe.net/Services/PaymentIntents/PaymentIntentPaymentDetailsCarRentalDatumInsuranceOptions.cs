// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsCarRentalDatumInsuranceOptions : INestedOptions
    {
        /// <summary>
        /// Amount of the insurance coverage in cents.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// Currency of the insurance amount.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Name of the insurance company.
        /// </summary>
        [JsonProperty("insurance_company_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("insurance_company_name")]
#endif
        public string InsuranceCompanyName { get; set; }

        /// <summary>
        /// Type of insurance coverage.
        /// One of: <c>liability_supplement</c>, <c>loss_damage_waiver</c>, <c>other</c>,
        /// <c>partial_damage_waiver</c>, <c>personal_accident</c>, or <c>personal_effects</c>.
        /// </summary>
        [JsonProperty("insurance_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("insurance_type")]
#endif
        public string InsuranceType { get; set; }
    }
}
