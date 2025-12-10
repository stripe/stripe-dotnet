// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateIdentityIndividualDateOfBirthOptions : INestedOptions
    {
        /// <summary>
        /// The day of birth.
        /// </summary>
        [JsonProperty("day")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("day")]
#endif
        public long? Day { get; set; }

        /// <summary>
        /// The month of birth.
        /// </summary>
        [JsonProperty("month")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("month")]
#endif
        public long? Month { get; set; }

        /// <summary>
        /// The year of birth.
        /// </summary>
        [JsonProperty("year")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("year")]
#endif
        public long? Year { get; set; }
    }
}
