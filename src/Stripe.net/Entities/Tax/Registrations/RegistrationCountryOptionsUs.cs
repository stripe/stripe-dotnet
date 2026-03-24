// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RegistrationCountryOptionsUs : StripeEntity<RegistrationCountryOptionsUs>
    {
        [JsonProperty("admissions_tax")]
        [STJS.JsonPropertyName("admissions_tax")]
        public RegistrationCountryOptionsUsAdmissionsTax AdmissionsTax { get; set; }

        [JsonProperty("attendance_tax")]
        [STJS.JsonPropertyName("attendance_tax")]
        public RegistrationCountryOptionsUsAttendanceTax AttendanceTax { get; set; }

        [JsonProperty("entertainment_tax")]
        [STJS.JsonPropertyName("entertainment_tax")]
        public RegistrationCountryOptionsUsEntertainmentTax EntertainmentTax { get; set; }

        [JsonProperty("gross_receipts_tax")]
        [STJS.JsonPropertyName("gross_receipts_tax")]
        public RegistrationCountryOptionsUsGrossReceiptsTax GrossReceiptsTax { get; set; }

        [JsonProperty("hospitality_tax")]
        [STJS.JsonPropertyName("hospitality_tax")]
        public RegistrationCountryOptionsUsHospitalityTax HospitalityTax { get; set; }

        [JsonProperty("local_amusement_tax")]
        [STJS.JsonPropertyName("local_amusement_tax")]
        public RegistrationCountryOptionsUsLocalAmusementTax LocalAmusementTax { get; set; }

        [JsonProperty("local_lease_tax")]
        [STJS.JsonPropertyName("local_lease_tax")]
        public RegistrationCountryOptionsUsLocalLeaseTax LocalLeaseTax { get; set; }

        [JsonProperty("luxury_tax")]
        [STJS.JsonPropertyName("luxury_tax")]
        public RegistrationCountryOptionsUsLuxuryTax LuxuryTax { get; set; }

        [JsonProperty("resort_tax")]
        [STJS.JsonPropertyName("resort_tax")]
        public RegistrationCountryOptionsUsResortTax ResortTax { get; set; }

        /// <summary>
        /// Two-letter US state code (<a href="https://en.wikipedia.org/wiki/ISO_3166-2">ISO
        /// 3166-2</a>).
        /// </summary>
        [JsonProperty("state")]
        [STJS.JsonPropertyName("state")]
        public string State { get; set; }

        [JsonProperty("state_sales_tax")]
        [STJS.JsonPropertyName("state_sales_tax")]
        public RegistrationCountryOptionsUsStateSalesTax StateSalesTax { get; set; }

        [JsonProperty("tourism_tax")]
        [STJS.JsonPropertyName("tourism_tax")]
        public RegistrationCountryOptionsUsTourismTax TourismTax { get; set; }

        /// <summary>
        /// Type of registration in the US.
        /// One of: <c>admissions_tax</c>, <c>attendance_tax</c>, <c>entertainment_tax</c>,
        /// <c>gross_receipts_tax</c>, <c>home_rule_tax</c>, <c>hospitality_tax</c>,
        /// <c>local_amusement_tax</c>, <c>local_lease_tax</c>, <c>luxury_tax</c>,
        /// <c>resort_tax</c>, <c>state_communications_tax</c>, <c>state_retail_delivery_fee</c>,
        /// <c>state_sales_tax</c>, or <c>tourism_tax</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonProperty("home_rule_tax")]
        [STJS.JsonPropertyName("home_rule_tax")]
        public RegistrationCountryOptionsUsHomeRuleTax HomeRuleTax { get; set; }
    }
}
