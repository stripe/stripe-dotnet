// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupAttemptListOptions : ListOptions
    {
        /// <summary>
        /// A filter on the list, based on the object <c>created</c> field. The value can be a
        /// string with an integer Unix timestamp or a dictionary with a number of different query
        /// options.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Only return SetupAttempts created by the SetupIntent specified by this ID.
        /// </summary>
        [JsonProperty("setup_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("setup_intent")]
#endif
        public string SetupIntent { get; set; }
    }
}
