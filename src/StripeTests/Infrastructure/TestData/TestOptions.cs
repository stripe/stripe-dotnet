namespace StripeTests.Infrastructure.TestData
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Stripe;
    using Stripe.Infrastructure;

    public class TestOptions : BaseOptions
    {
        public TestOptions()
        {
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public enum TestEnum
        {
            [EnumMember(Value = "test_one")]
            TestOne,

            // TestTwo doesn't define a serialization value
            TestTwo,
        }

        [FormProperty("array")]
        public string[] Array { get; set; }

        [FormProperty("bool")]
        public bool? Bool { get; set; }

        [FormProperty("date_filter")]
        public DateFilter DateFilter { get; set; }

        [FormProperty("datetime")]
        public DateTime? DateTime { get; set; }

        [FormProperty("decimal")]
        public decimal? Decimal { get; set; }

        [FormProperty("dictionary")]
        public Dictionary<string, object> Dictionary { get; set; }

        [FormProperty("enum")]
        public TestEnum? Enum { get; set; }

        [FormProperty("int")]
        public int? Int { get; set; }

        [FormProperty("list")]
        public List<object> List { get; set; }

        [FormProperty("string")]
        public string String { get; set; }
    }
}
