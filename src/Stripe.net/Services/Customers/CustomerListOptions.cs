// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CustomerListOptions : ListOptions
    {
        /// <summary>
        /// Only return customers that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// A case-sensitive filter on the list based on the customer's <c>email</c> field. The
        /// value must be a string.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Provides a list of customers that are associated with the specified test clock. The
        /// response will not include customers with test clocks if this parameter is not set.
        /// </summary>
        [JsonProperty("test_clock")]
        [STJS.JsonPropertyName("test_clock")]
        public string TestClock { get; set; }
    }
}
