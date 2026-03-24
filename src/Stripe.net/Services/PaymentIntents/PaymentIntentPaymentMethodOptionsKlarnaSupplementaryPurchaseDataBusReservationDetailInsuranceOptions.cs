// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataBusReservationDetailInsuranceOptions : INestedOptions
    {
        /// <summary>
        /// Insurance currency.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Name of the company providing the insurance.
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

        /// <summary>
        /// Price of insurance in cents.
        /// </summary>
        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public long? Price { get; set; }
    }
}
