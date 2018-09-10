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

        public string StringWithoutAttribute { get; set; }

        [JsonProperty("differentname")]
        public string StringWithDifferentName { get; set; }

        [JsonProperty("stringcontainingtext")]
        public string StringContainingText { get; set; }

        [JsonProperty("stringcontainingnull")]
        public string StringContainingNull { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("nullnumber")]
        public int? NullNumber { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("list_of_decimals")]
        public List<decimal> ListOfDecimals { get; set; }

        [JsonProperty("array_of_ints")]
        public int[] ArrayOfInts { get; set; }

        [JsonProperty("dateequals")]
        public StripeDateFilter EqualDateFilter { get; set; }

        [JsonProperty("datelessthan")]
        public StripeDateFilter LessThanDateFilter { get; set; }

        [JsonProperty("datecomplex")]
        public StripeDateFilter ComplexDateFilter { get; set; }

        [JsonProperty("enum")]
        public TestEnum? Enum { get; set; }
    }
}
