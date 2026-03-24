// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountIdentityIndividualDateOfBirth : StripeEntity<AccountIdentityIndividualDateOfBirth>
    {
        /// <summary>
        /// The day of birth, between 1 and 31.
        /// </summary>
        [JsonProperty("day")]
        [STJS.JsonPropertyName("day")]
        public long Day { get; set; }

        /// <summary>
        /// The month of birth, between 1 and 12.
        /// </summary>
        [JsonProperty("month")]
        [STJS.JsonPropertyName("month")]
        public long Month { get; set; }

        /// <summary>
        /// The four-digit year of birth.
        /// </summary>
        [JsonProperty("year")]
        [STJS.JsonPropertyName("year")]
        public long Year { get; set; }
    }
}
