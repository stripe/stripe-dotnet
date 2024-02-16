// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SetupAttemptListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// A filter on the list, based on the object <c>created</c> field. The value can be a
        /// string with an integer Unix timestamp or a dictionary with a number of different query
        /// options.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Only return SetupAttempts created by the SetupIntent specified by this ID.
        /// </summary>
        [JsonProperty("setup_intent")]
        public string SetupIntent { get; set; }
    }
}
