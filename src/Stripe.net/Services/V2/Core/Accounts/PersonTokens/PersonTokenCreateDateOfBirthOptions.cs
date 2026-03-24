// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Accounts
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PersonTokenCreateDateOfBirthOptions : INestedOptions
    {
        /// <summary>
        /// The day of the birth.
        /// </summary>
        [JsonProperty("day")]
        [STJS.JsonPropertyName("day")]
        public long? Day { get; set; }

        /// <summary>
        /// The month of birth.
        /// </summary>
        [JsonProperty("month")]
        [STJS.JsonPropertyName("month")]
        public long? Month { get; set; }

        /// <summary>
        /// The year of birth.
        /// </summary>
        [JsonProperty("year")]
        [STJS.JsonPropertyName("year")]
        public long? Year { get; set; }
    }
}
