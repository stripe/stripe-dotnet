// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerListOptions : ListOptionsWithCreated
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("test_clock")]
        public string TestClock { get; set; }
    }
}
