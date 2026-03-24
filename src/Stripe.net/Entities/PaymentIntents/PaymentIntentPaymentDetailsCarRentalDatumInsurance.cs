// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsCarRentalDatumInsurance : StripeEntity<PaymentIntentPaymentDetailsCarRentalDatumInsurance>
    {
        /// <summary>
        /// Amount of the insurance.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Currency for the insurance price.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Name of the insurance company.
        /// </summary>
        [JsonProperty("insurance_company_name")]
        [STJS.JsonPropertyName("insurance_company_name")]
        public string InsuranceCompanyName { get; set; }

        /// <summary>
        /// Type of insurance.
        /// One of: <c>liability_supplement</c>, <c>loss_damage_waiver</c>, <c>other</c>,
        /// <c>partial_damage_waiver</c>, <c>personal_accident</c>, or <c>personal_effects</c>.
        /// </summary>
        [JsonProperty("insurance_type")]
        [STJS.JsonPropertyName("insurance_type")]
        public string InsuranceType { get; set; }
    }
}
