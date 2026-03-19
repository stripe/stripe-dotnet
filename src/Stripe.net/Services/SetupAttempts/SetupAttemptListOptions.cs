// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SetupAttemptListOptions : ListOptions
    {
        /// <summary>
        /// A filter on the list, based on the object <c>created</c> field. The value can be a
        /// string with an integer Unix timestamp or a dictionary with a number of different query
        /// options.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Only return SetupAttempts created by the SetupIntent specified by this ID.
        /// </summary>
        [JsonProperty("setup_intent")]
        [STJS.JsonPropertyName("setup_intent")]
        public string SetupIntent { get; set; }
    }
}
