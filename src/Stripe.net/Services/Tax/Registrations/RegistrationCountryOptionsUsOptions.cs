// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RegistrationCountryOptionsUsOptions : INestedOptions
    {
        /// <summary>
        /// Options for the admission tax registration.
        /// </summary>
        [JsonProperty("admissions_tax")]
        [STJS.JsonPropertyName("admissions_tax")]
        public RegistrationCountryOptionsUsAdmissionsTaxOptions AdmissionsTax { get; set; }

        /// <summary>
        /// Options for the attendance tax registration.
        /// </summary>
        [JsonProperty("attendance_tax")]
        [STJS.JsonPropertyName("attendance_tax")]
        public RegistrationCountryOptionsUsAttendanceTaxOptions AttendanceTax { get; set; }

        /// <summary>
        /// Options for the entertainment tax registration.
        /// </summary>
        [JsonProperty("entertainment_tax")]
        [STJS.JsonPropertyName("entertainment_tax")]
        public RegistrationCountryOptionsUsEntertainmentTaxOptions EntertainmentTax { get; set; }

        /// <summary>
        /// Options for the gross receipts tax registration.
        /// </summary>
        [JsonProperty("gross_receipts_tax")]
        [STJS.JsonPropertyName("gross_receipts_tax")]
        public RegistrationCountryOptionsUsGrossReceiptsTaxOptions GrossReceiptsTax { get; set; }

        /// <summary>
        /// Options for the hospitality tax registration.
        /// </summary>
        [JsonProperty("hospitality_tax")]
        [STJS.JsonPropertyName("hospitality_tax")]
        public RegistrationCountryOptionsUsHospitalityTaxOptions HospitalityTax { get; set; }

        /// <summary>
        /// Options for the local amusement tax registration.
        /// </summary>
        [JsonProperty("local_amusement_tax")]
        [STJS.JsonPropertyName("local_amusement_tax")]
        public RegistrationCountryOptionsUsLocalAmusementTaxOptions LocalAmusementTax { get; set; }

        /// <summary>
        /// Options for the local lease tax registration.
        /// </summary>
        [JsonProperty("local_lease_tax")]
        [STJS.JsonPropertyName("local_lease_tax")]
        public RegistrationCountryOptionsUsLocalLeaseTaxOptions LocalLeaseTax { get; set; }

        /// <summary>
        /// Options for the luxury tax registration.
        /// </summary>
        [JsonProperty("luxury_tax")]
        [STJS.JsonPropertyName("luxury_tax")]
        public RegistrationCountryOptionsUsLuxuryTaxOptions LuxuryTax { get; set; }

        /// <summary>
        /// Options for the resort tax registration.
        /// </summary>
        [JsonProperty("resort_tax")]
        [STJS.JsonPropertyName("resort_tax")]
        public RegistrationCountryOptionsUsResortTaxOptions ResortTax { get; set; }

        /// <summary>
        /// Two-letter US state code (<a href="https://en.wikipedia.org/wiki/ISO_3166-2">ISO
        /// 3166-2</a>).
        /// </summary>
        [JsonProperty("state")]
        [STJS.JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// Options for the state sales tax registration.
        /// </summary>
        [JsonProperty("state_sales_tax")]
        [STJS.JsonPropertyName("state_sales_tax")]
        public RegistrationCountryOptionsUsStateSalesTaxOptions StateSalesTax { get; set; }

        /// <summary>
        /// Options for the tourism tax registration.
        /// </summary>
        [JsonProperty("tourism_tax")]
        [STJS.JsonPropertyName("tourism_tax")]
        public RegistrationCountryOptionsUsTourismTaxOptions TourismTax { get; set; }

        /// <summary>
        /// Type of registration to be created in the US.
        /// One of: <c>admissions_tax</c>, <c>attendance_tax</c>, <c>entertainment_tax</c>,
        /// <c>gross_receipts_tax</c>, <c>hospitality_tax</c>, <c>local_amusement_tax</c>,
        /// <c>local_lease_tax</c>, <c>luxury_tax</c>, <c>resort_tax</c>,
        /// <c>state_communications_tax</c>, <c>state_retail_delivery_fee</c>,
        /// <c>state_sales_tax</c>, or <c>tourism_tax</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
