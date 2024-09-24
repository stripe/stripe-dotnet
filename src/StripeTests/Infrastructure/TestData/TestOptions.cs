namespace StripeTests.Infrastructure.TestData
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Stripe;
    using Stripe.Infrastructure;

    public class TestOptions : BaseOptions
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TestEnum
        {
            [EnumMember(Value = "test_one")]
            TestOne,

            // TestTwo purposefully doesn't define a serialization value
            TestTwo,
        }

        [JsonProperty("any_of")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, Dictionary<string, string>> AnyOf { get; set; }

        [JsonProperty("array")]
        public string[] Array { get; set; }

        [JsonProperty("bool")]
        public bool? Bool { get; set; }

        [JsonProperty("date_filter")]
        public DateRangeOptions DateRangeOptions { get; set; }

        [JsonProperty("datetime")]
        public DateTime? DateTime { get; set; }

        [JsonProperty("decimal")]
        public decimal? Decimal { get; set; }

        [JsonProperty("dictionary")]
        public Dictionary<string, object> Dictionary { get; set; }

        [JsonProperty("enum")]
        public TestEnum? Enum { get; set; }

        [JsonProperty("list")]
        public List<object> List { get; set; }

        [JsonProperty("long")]
        public long? Long { get; set; }

        [JsonProperty("stream")]
        public Stream Stream { get; set; }

        [JsonProperty("string")]
        public string String { get; set; }

        [JsonProperty("string_enum")]
        public TestStringEnum StringEnum { get; set; }

        [JsonIgnore]
        public bool EmptyEmptyStringable
        {
            get => this.InternalEmptyStringable?.Empty ?? false;
            set
            {
                this.InternalEmptyStringable ??= new Emptyable<Nested>();
                this.InternalEmptyStringable.Empty = value;
            }
        }

        [JsonIgnore]
        public Nested EmptyStringable
        {
            get => this.InternalEmptyStringable?.Value;
            set
            {
                this.InternalEmptyStringable ??= new Emptyable<Nested>();
                this.InternalEmptyStringable.Value = value;
            }
        }

        [JsonProperty("empty_stringable")]
        [JsonConverter(typeof(EmptyableConverter<Nested>))]
        internal Emptyable<Nested> InternalEmptyStringable { get; set; }

        public class TestStringEnum : StringEnum
        {
            public static readonly TestStringEnum Foo = new TestStringEnum("foo");

            private TestStringEnum(string value)
                : base(value)
            {
            }
        }

        public class Nested
        {
            [JsonProperty("bool")]
            public bool? Bool { get; set; }
        }
    }
}
