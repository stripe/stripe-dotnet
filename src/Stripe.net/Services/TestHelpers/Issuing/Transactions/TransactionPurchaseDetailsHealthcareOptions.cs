// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TransactionPurchaseDetailsHealthcareOptions : INestedOptions
    {
        /// <summary>
        /// Clinic and urgent care sub-amount for Visa only.
        /// </summary>
        [JsonProperty("clinic_amount")]
        [STJS.JsonPropertyName("clinic_amount")]
        public long? ClinicAmount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Dental care sub-amount for Visa only.
        /// </summary>
        [JsonProperty("dental_amount")]
        [STJS.JsonPropertyName("dental_amount")]
        public long? DentalAmount { get; set; }

        /// <summary>
        /// Prescription drug sub-amount. Null if the merchant did not send this amount.
        /// </summary>
        [JsonProperty("prescription_amount")]
        [STJS.JsonPropertyName("prescription_amount")]
        public long? PrescriptionAmount { get; set; }

        /// <summary>
        /// The type of healthcare transaction. <c>medical</c> for FSA/HSA-eligible healthcare
        /// purchases; <c>transit_for_healthcare</c> for FSA/HSA-eligible transit for healthcare
        /// purchases.
        /// One of: <c>medical</c>, or <c>transit_for_healthcare</c>.
        /// </summary>
        [JsonProperty("purchase_type")]
        [STJS.JsonPropertyName("purchase_type")]
        public string PurchaseType { get; set; }

        /// <summary>
        /// Total FSA/HSA-eligible amount in the smallest currency unit.
        /// </summary>
        [JsonProperty("total_qualified_amount")]
        [STJS.JsonPropertyName("total_qualified_amount")]
        public long? TotalQualifiedAmount { get; set; }

        /// <summary>
        /// IIAS verification status from the merchant terminal. For Visa, this is always
        /// iias_verified.
        /// One of: <c>iias_merchant_exempt</c>, <c>iias_merchant_not_certified</c>,
        /// <c>iias_verified</c>, or <c>not_verified</c>.
        /// </summary>
        [JsonProperty("verification_status")]
        [STJS.JsonPropertyName("verification_status")]
        public string VerificationStatus { get; set; }

        /// <summary>
        /// Vision/optical sub-amount. Null if the merchant did not send this amount.
        /// </summary>
        [JsonProperty("vision_amount")]
        [STJS.JsonPropertyName("vision_amount")]
        public long? VisionAmount { get; set; }
    }
}
