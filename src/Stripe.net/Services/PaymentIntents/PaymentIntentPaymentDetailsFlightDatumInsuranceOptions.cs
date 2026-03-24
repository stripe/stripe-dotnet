// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentDetailsFlightDatumInsuranceOptions : INestedOptions
    {
        /// <summary>
        /// Insurance cost.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Insurance currency.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Insurance company name.
        /// </summary>
        [JsonProperty("insurance_company_name")]
        [STJS.JsonPropertyName("insurance_company_name")]
        public string InsuranceCompanyName { get; set; }

        /// <summary>
        /// Type of insurance.
        /// One of: <c>baggage</c>, <c>bankruptcy</c>, <c>cancelation</c>, <c>emergency</c>, or
        /// <c>medical</c>.
        /// </summary>
        [JsonProperty("insurance_type")]
        [STJS.JsonPropertyName("insurance_type")]
        public string InsuranceType { get; set; }
    }
}
