namespace StripeTests.Infrastructure.TestData
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TestOptions : BaseOptions
    {
        [JsonProperty("any_of")]
        [STJS.JsonPropertyName("any_of")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, Dictionary<string, string>> AnyOf { get; set; }

        [JsonProperty("array")]
        [STJS.JsonPropertyName("array")]
        public string[] Array { get; set; }

        [JsonProperty("bool")]
        [STJS.JsonPropertyName("bool")]
        public bool? Bool { get; set; }

        [JsonProperty("date_filter")]
        [STJS.JsonPropertyName("date_filter")]
        public DateRangeOptions DateRangeOptions { get; set; }

        [JsonProperty("datetime")]
        [STJS.JsonPropertyName("datetime")]
        public DateTime? DateTime { get; set; }

        [JsonProperty("decimal")]
        [STJS.JsonPropertyName("decimal")]
        public decimal? Decimal { get; set; }

        [JsonProperty("dictionary")]
        [STJS.JsonPropertyName("dictionary")]
        public Dictionary<string, object> Dictionary { get; set; }

        [JsonProperty("enum")]
        [STJS.JsonPropertyName("enum")]
        public string Enum { get; set; }

        [JsonProperty("list")]
        [STJS.JsonPropertyName("list")]
        public List<object> List { get; set; }

        [JsonProperty("long")]
        [STJS.JsonPropertyName("long")]
        public long? Long { get; set; }

        [JsonProperty("stream")]
        [STJS.JsonPropertyName("stream")]
        public Stream Stream { get; set; }

        [JsonProperty("string")]
        [STJS.JsonPropertyName("string")]
        public string String { get; set; }

        [JsonProperty("string_enum")]
        [STJS.JsonPropertyName("string_enum")]
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
        [STJS.JsonPropertyName("empty_stringable")]
        [JsonConverter(typeof(EmptyableConverter<Nested>))]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<Nested>))]
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
            [STJS.JsonPropertyName("bool")]
            public bool? Bool { get; set; }
        }
    }
}
