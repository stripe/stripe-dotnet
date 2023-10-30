// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class DobOptions : INestedOptions
    {
        /// <summary>
        /// The day of birth, between 1 and 31.
        /// </summary>
        [JsonProperty("day")]
        public long? Day { get; set; }

        /// <summary>
        /// The month of birth, between 1 and 12.
        /// </summary>
        [JsonProperty("month")]
        public long? Month { get; set; }

        /// <summary>
        /// The four-digit year of birth.
        /// </summary>
        [JsonProperty("year")]
        public long? Year { get; set; }
    }
}
