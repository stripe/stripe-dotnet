namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;
    using STJS = System.Text.Json.Serialization;

    public class DeserializationTest : BaseStripeTest
    {
        [Fact]
        public void TestStubWithIdDirect()
        {
            string json = "{\"some_ref\":{\"id\":\"xyz\"}}";
            var entity = StripeEntity.FromJson<MyEntity>(json);
            Assert.NotNull(entity);
            Assert.IsType<MyEntity>(entity);
            var id = entity.SomeRef.Id;
            Assert.Equal("xyz", id);
        }

        [Fact]
        public void TestStubWithIdExpanded()
        {
            string json = "{\"some_expandable\":{\"id\":\"xyz\"}}";
            var entity = StripeEntity.FromJson<MyEntity>(json);
            Assert.NotNull(entity);
            Assert.IsType<MyEntity>(entity);
            var id = entity.SomeExpandable.Id;
            Assert.Equal("xyz", id);
        }

        [Fact]
        public void TestStubWithIdArrayExpanded()
        {
            string json = "{\"some_expanded_array\":[{\"id\":\"xyz\"}]}";
            var entity = StripeEntity.FromJson<MyEntity>(json);
            Assert.NotNull(entity);
            Assert.IsType<MyEntity>(entity);
            var id = entity.SomeExpandedArray[0].Id;
            Assert.Equal("xyz", id);
        }

        [Fact]
        public void TestStubWithIdInArray()
        {
            string json = "{\"some_ref_array\":[{\"id\":\"xyz\"}]}";
            var entity = StripeEntity.FromJson<MyEntity>(json);
            Assert.NotNull(entity);
            Assert.IsType<MyEntity>(entity);
            var id = entity.SomeRefArray[0].Id;
            Assert.Equal("xyz", id);
        }

        [Fact]
        public void TestStubWithIdInListObject()
        {
            string json = "{\"some_list_object\":{\"data\":[{\"id\":\"xyz\"}]}}";
            var entity = StripeEntity.FromJson<MyEntity>(json);
            Assert.NotNull(entity);
            Assert.IsType<MyEntity>(entity);
            var enumerator = entity.SomeListObject.GetEnumerator();
            enumerator.MoveNext();
            var id = enumerator.Current.Id;
            Assert.Equal("xyz", id);
        }

        [Fact]
        public void TestEmptyObjectDirect()
        {
            string json = "{\"some_ref\":{}}";
            var entity = StripeEntity.FromJson<MyEntity>(json);
            var id = entity.SomeRef.Id;
            Assert.Null(id);
        }

        [Fact]
        public void TestEmptyObjectArray()
        {
            string json = "{\"some_ref_array\":[{}]}";
            var entity = StripeEntity.FromJson<MyEntity>(json);
            var id = entity.SomeRefArray[0].Id;
            Assert.Null(id);
        }

        [Fact]
        public void TestEmptyObjectExpanded()
        {
            string json = "{\"some_expandable\":{}}";
            var entity = StripeEntity.FromJson<MyEntity>(json);
            var id = entity.SomeExpandable.Id;
            Assert.Null(id);
        }

        [Fact]
        public void TestEmptyObjectArrayExpanded()
        {
            string json = "{\"some_expanded_array\":[{}]}";
            var entity = StripeEntity.FromJson<MyEntity>(json);
            var id = entity.SomeExpandedArray[0].Id;
            Assert.Null(id);
        }

        [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
        public class MyEntity : StripeEntity<MyEntity>, IHasId
        {
            [JsonProperty("id")]
            [STJS.JsonPropertyName("id")]
            public string Id { get; set; }

            [JsonProperty("some_integer")]
            [STJS.JsonPropertyName("some_integer")]
            public long SomeInteger { get; set; }

            [JsonProperty("some_longinteger")]
            [STJS.JsonPropertyName("some_longinteger")]
            public long SomeLonginteger { get; set; }

            [JsonProperty("some_boolean")]
            [STJS.JsonPropertyName("some_boolean")]
            public bool SomeBoolean { get; set; }

            [JsonProperty("some_number")]
            [STJS.JsonPropertyName("some_number")]
            public decimal SomeNumber { get; set; }

            [JsonProperty("some_decimal_string")]
            [STJS.JsonPropertyName("some_decimal_string")]
            public decimal SomeDecimalString { get; set; }

            [JsonProperty("some_string")]
            [STJS.JsonPropertyName("some_string")]
            public string SomeString { get; set; }

            [JsonProperty("some_datetime")]
            [JsonConverter(typeof(UnixDateTimeConverter))]
            [STJS.JsonPropertyName("some_datetime")]
            [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
            public DateTime SomeDatetime { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

            [JsonProperty("some_ref")]
            [STJS.JsonPropertyName("some_ref")]
            public MyEntity SomeRef { get; set; }

            [JsonProperty("some_literal")]
            [STJS.JsonPropertyName("some_literal")]
            public string SomeLiteral { get; set; }

            [JsonProperty("some_nullable")]
            [STJS.JsonPropertyName("some_nullable")]
            public string SomeNullable { get; set; }

            [JsonProperty("some_string_array")]
            [STJS.JsonPropertyName("some_string_array")]
            public List<string> SomeStringArray { get; set; }

            [JsonProperty("some_ref_array")]
            [STJS.JsonPropertyName("some_ref_array")]
            public List<MyEntity> SomeRefArray { get; set; }

            #region Expandable SomeExpandedArray

            [JsonIgnore]
            [STJS.JsonIgnore]
            public List<string> SomeExpandedArrayIds
            {
                get => this.InternalSomeExpandedArray?.Select((x) => x.Id).ToList();
                set => this.InternalSomeExpandedArray = SetExpandableArrayIds<MyEntity>(value);
            }

            [JsonIgnore]
            [STJS.JsonIgnore]
            public List<MyEntity> SomeExpandedArray
            {
                get => this.InternalSomeExpandedArray?.Select((x) => x.ExpandedObject).ToList();
                set => this.InternalSomeExpandedArray = SetExpandableArrayObjects(value);
            }

            [JsonProperty("some_expanded_array", ItemConverterType = typeof(ExpandableFieldConverter<MyEntity>))]
            [STJS.JsonPropertyName("some_expanded_array")]
            internal List<ExpandableField<MyEntity>> InternalSomeExpandedArray { get; set; }
            #endregion

            [JsonProperty("some_enum")]
            [STJS.JsonPropertyName("some_enum")]
            public string SomeEnum { get; set; }

            [JsonProperty("some_map")]
            [STJS.JsonPropertyName("some_map")]
            public Dictionary<string, string> SomeMap { get; set; }

            [JsonProperty("some_object")]
            [STJS.JsonPropertyName("some_object")]
            public MyEntitySomeObject SomeObject { get; set; }

            [JsonProperty("some_list_object")]
            [STJS.JsonPropertyName("some_list_object")]
            public StripeList<MyEntity> SomeListObject { get; set; }

            #region Expandable SomeExpandable

            [JsonIgnore]
            [STJS.JsonIgnore]
            public string SomeExpandableId
            {
                get => this.InternalSomeExpandable?.Id;
                set => this.InternalSomeExpandable = SetExpandableFieldId(value, this.InternalSomeExpandable);
            }

            [JsonIgnore]
            [STJS.JsonIgnore]
            public MyEntity SomeExpandable
            {
                get => this.InternalSomeExpandable?.ExpandedObject;
                set => this.InternalSomeExpandable = SetExpandableFieldObject(value, this.InternalSomeExpandable);
            }

            [JsonProperty("some_expandable")]
            [JsonConverter(typeof(ExpandableFieldConverter<MyEntity>))]
            [STJS.JsonPropertyName("some_expandable")]
            [STJS.JsonConverter(typeof(STJExpandableFieldConverter<MyEntity>))]
            internal ExpandableField<MyEntity> InternalSomeExpandable { get; set; }
            #endregion

            [JsonProperty("some_polymorphic_group")]
            [STJS.JsonPropertyName("some_polymorphic_group")]
            public MyEntity SomePolymorphicGroup { get; set; }
        }

        public class MyEntitySomeObject : StripeEntity<MyEntitySomeObject>
        {
            [JsonProperty("some_string")]
            [STJS.JsonPropertyName("some_string")]
            public string SomeString { get; set; }
        }
    }
}
