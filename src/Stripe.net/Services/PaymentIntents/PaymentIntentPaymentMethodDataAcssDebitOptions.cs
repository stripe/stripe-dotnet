// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodDataAcssDebitOptions : INestedOptions
    {
        /// <summary>
        /// Customer's bank account number.
        /// </summary>
        [JsonProperty("account_number")]
        [STJS.JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Institution number of the customer's bank.
        /// </summary>
        [JsonProperty("institution_number")]
        [STJS.JsonPropertyName("institution_number")]
        public string InstitutionNumber { get; set; }

        /// <summary>
        /// Transit number of the customer's bank.
        /// </summary>
        [JsonProperty("transit_number")]
        [STJS.JsonPropertyName("transit_number")]
        public string TransitNumber { get; set; }
    }
}
