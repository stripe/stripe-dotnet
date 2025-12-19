// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RegistrationCountryOptionsUs : StripeEntity<RegistrationCountryOptionsUs>
    {
        [JsonProperty("local_amusement_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("local_amusement_tax")]
#endif
        public RegistrationCountryOptionsUsLocalAmusementTax LocalAmusementTax { get; set; }

        [JsonProperty("local_lease_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("local_lease_tax")]
#endif
        public RegistrationCountryOptionsUsLocalLeaseTax LocalLeaseTax { get; set; }

        /// <summary>
        /// Two-letter US state code (<a href="https://en.wikipedia.org/wiki/ISO_3166-2">ISO
        /// 3166-2</a>).
        /// </summary>
        [JsonProperty("state")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("state")]
#endif
        public string State { get; set; }

        [JsonProperty("state_sales_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("state_sales_tax")]
#endif
        public RegistrationCountryOptionsUsStateSalesTax StateSalesTax { get; set; }

        /// <summary>
        /// Type of registration in the US.
        /// One of: <c>admissions_tax</c>, <c>attendance_tax</c>, <c>entertainment_tax</c>,
        /// <c>gross_receipts_tax</c>, <c>hospitality_tax</c>, <c>local_amusement_tax</c>,
        /// <c>local_lease_tax</c>, <c>luxury_tax</c>, <c>resort_tax</c>,
        /// <c>state_communications_tax</c>, <c>state_retail_delivery_fee</c>,
        /// <c>state_sales_tax</c>, or <c>tourism_tax</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        [JsonProperty("admissions_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("admissions_tax")]
#endif
        public RegistrationCountryOptionsUsAdmissionsTax AdmissionsTax { get; set; }

        [JsonProperty("attendance_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("attendance_tax")]
#endif
        public RegistrationCountryOptionsUsAttendanceTax AttendanceTax { get; set; }

        [JsonProperty("entertainment_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("entertainment_tax")]
#endif
        public RegistrationCountryOptionsUsEntertainmentTax EntertainmentTax { get; set; }

        [JsonProperty("gross_receipts_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gross_receipts_tax")]
#endif
        public RegistrationCountryOptionsUsGrossReceiptsTax GrossReceiptsTax { get; set; }

        [JsonProperty("hospitality_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hospitality_tax")]
#endif
        public RegistrationCountryOptionsUsHospitalityTax HospitalityTax { get; set; }

        [JsonProperty("luxury_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("luxury_tax")]
#endif
        public RegistrationCountryOptionsUsLuxuryTax LuxuryTax { get; set; }

        [JsonProperty("resort_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("resort_tax")]
#endif
        public RegistrationCountryOptionsUsResortTax ResortTax { get; set; }

        [JsonProperty("tourism_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tourism_tax")]
#endif
        public RegistrationCountryOptionsUsTourismTax TourismTax { get; set; }
    }
}
