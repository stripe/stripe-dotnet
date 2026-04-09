// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsMoneyServicesAccountFundingSenderDetailsDateOfBirth : StripeEntity<PaymentIntentPaymentDetailsMoneyServicesAccountFundingSenderDetailsDateOfBirth>
    {
        /// <summary>
        /// Day of birth, between 1 and 31.
        /// </summary>
        [JsonProperty("day")]
        [STJS.JsonPropertyName("day")]
        public long Day { get; set; }

        /// <summary>
        /// Month of birth, between 1 and 12.
        /// </summary>
        [JsonProperty("month")]
        [STJS.JsonPropertyName("month")]
        public long Month { get; set; }

        /// <summary>
        /// Four-digit year of birth.
        /// </summary>
        [JsonProperty("year")]
        [STJS.JsonPropertyName("year")]
        public long Year { get; set; }
    }
}
