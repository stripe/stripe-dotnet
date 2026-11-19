// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentDetailsCarRentalDatumDriverDateOfBirthOptions : INestedOptions
    {
        /// <summary>
        /// Day of birth (1-31).
        /// </summary>
        [JsonProperty("day")]
        [STJS.JsonPropertyName("day")]
        public long? Day { get; set; }

        /// <summary>
        /// Month of birth (1-12).
        /// </summary>
        [JsonProperty("month")]
        [STJS.JsonPropertyName("month")]
        public long? Month { get; set; }

        /// <summary>
        /// Year of birth (must be greater than 1900).
        /// </summary>
        [JsonProperty("year")]
        [STJS.JsonPropertyName("year")]
        public long? Year { get; set; }
    }
}
