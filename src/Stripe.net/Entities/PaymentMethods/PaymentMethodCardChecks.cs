// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentMethodCardChecks : StripeEntity<PaymentMethodCardChecks>
    {
        /// <summary>
        /// If a address line1 was provided, results of the check, one of <c>pass</c>, <c>fail</c>,
        /// <c>unavailable</c>, or <c>unchecked</c>.
        /// </summary>
        [JsonProperty("address_line1_check")]
        [STJS.JsonPropertyName("address_line1_check")]
        public string AddressLine1Check { get; set; }

        /// <summary>
        /// If a address postal code was provided, results of the check, one of <c>pass</c>,
        /// <c>fail</c>, <c>unavailable</c>, or <c>unchecked</c>.
        /// </summary>
        [JsonProperty("address_postal_code_check")]
        [STJS.JsonPropertyName("address_postal_code_check")]
        public string AddressPostalCodeCheck { get; set; }

        /// <summary>
        /// If a CVC was provided, results of the check, one of <c>pass</c>, <c>fail</c>,
        /// <c>unavailable</c>, or <c>unchecked</c>.
        /// </summary>
        [JsonProperty("cvc_check")]
        [STJS.JsonPropertyName("cvc_check")]
        public string CvcCheck { get; set; }
    }
}
