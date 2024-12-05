// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfirmationTokenPaymentMethodDataKlarnaDobOptions : INestedOptions
    {
        /// <summary>
        /// The day of birth, between 1 and 31.
        /// </summary>
        [JsonProperty("day")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("day")]
#endif
        public long? Day { get; set; }

        /// <summary>
        /// The month of birth, between 1 and 12.
        /// </summary>
        [JsonProperty("month")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("month")]
#endif
        public long? Month { get; set; }

        /// <summary>
        /// The four-digit year of birth.
        /// </summary>
        [JsonProperty("year")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("year")]
#endif
        public long? Year { get; set; }
    }
}
