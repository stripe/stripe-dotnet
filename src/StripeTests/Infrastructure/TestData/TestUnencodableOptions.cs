namespace StripeTests.Infrastructure.TestData
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe;

    public class TestUnencodableOptions : BaseOptions
    {
        public TestUnencodableOptions()
        {
        }

        [JsonProperty("dict_int_keys")]
        public Dictionary<int, string> DictIntKeys { get; set; }

        [JsonProperty("dict_int_values")]
        public Dictionary<string, int> DictIntValues { get; set; }
    }
}
