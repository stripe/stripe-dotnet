// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// A case-sensitive filter on the list based on the customer's <c>email</c> field. The
        /// value must be a string.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Provides a list of customers that are associated with the specified test clock. The
        /// response will not include customers with test clocks if this parameter is not set.
        /// </summary>
        [JsonProperty("test_clock")]
        public string TestClock { get; set; }
    }
}
