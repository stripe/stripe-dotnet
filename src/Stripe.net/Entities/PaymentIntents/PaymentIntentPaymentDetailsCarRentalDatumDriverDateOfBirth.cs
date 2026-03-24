// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsCarRentalDatumDriverDateOfBirth : StripeEntity<PaymentIntentPaymentDetailsCarRentalDatumDriverDateOfBirth>
    {
        /// <summary>
        /// Day of birth.
        /// </summary>
        [JsonProperty("day")]
        [STJS.JsonPropertyName("day")]
        public long Day { get; set; }

        /// <summary>
        /// Month of birth.
        /// </summary>
        [JsonProperty("month")]
        [STJS.JsonPropertyName("month")]
        public long Month { get; set; }

        /// <summary>
        /// Year of birth.
        /// </summary>
        [JsonProperty("year")]
        [STJS.JsonPropertyName("year")]
        public long Year { get; set; }
    }
}
