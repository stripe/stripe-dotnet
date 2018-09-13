namespace StripeTests.Infrastructure.TestData
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Stripe;

    public class TestOptions : StripeBaseOptions
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

        [JsonProperty("array")]
        public string[] Array { get; set; }

        [JsonProperty("bool")]
        public bool Bool { get; set; }

        [JsonProperty("bool_nullable")]
        public bool? BoolNullable { get; set; }

        [JsonProperty("date_filter")]
        public StripeDateFilter DateFilter { get; set; }

        [JsonProperty("datetime_nullable")]
        public DateTime? DateTimeNullable { get; set; }

        [JsonProperty("decimal")]
        public decimal Decimal { get; set; }

        [JsonProperty("decimal_nullable")]
        public decimal? DecimalNullable { get; set; }

        [JsonProperty("dictionary")]
        public Dictionary<string, object> Dictionary { get; set; }

        [JsonProperty("enum")]
        public TestEnum Enum { get; set; }

        [JsonProperty("enum_nullable")]
        public TestEnum? EnumNullable { get; set; }

        [JsonProperty("int")]
        public int Int { get; set; }

        [JsonProperty("int_nullable")]
        public int? IntNullable { get; set; }

        [JsonProperty("list")]
        public List<object> List { get; set; }

        [JsonProperty("string")]
        public string String { get; set; }
    }
}
