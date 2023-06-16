namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    public class DeserializationTest : BaseStripeTest
    {
        [Fact]
        public void TestStubWithIdDirect()
        {
            string json = "{\"direct\":{\"id\":\"xyz\"}}";
            var resource = StripeEntity.FromJson<MyTopLevelEntity>(json);
            Assert.NotNull(resource);
            Assert.IsType<MyTopLevelEntity>(resource);
            var id = resource.Direct.Id;
            Assert.Equal("xyz", id);
        }

        [Fact]
        public void TestStubWithIdExpanded()
        {
            string json = "{\"expanded\":{\"id\":\"xyz\"}}";
            var resource = StripeEntity.FromJson<MyTopLevelEntity>(json);
            Assert.NotNull(resource);
            Assert.IsType<MyTopLevelEntity>(resource);
            var id = resource.Expanded.Id;
            Assert.Equal("xyz", id);
        }

        [Fact]
        public void TestStubWithIdArrayExpanded()
        {
            string json = "{\"array_expanded\":[{\"id\":\"xyz\"}]}";
            var resource = StripeEntity.FromJson<MyTopLevelEntity>(json);
            Assert.NotNull(resource);
            Assert.IsType<MyTopLevelEntity>(resource);
            var id = resource.ArrayExpanded[0].Id;
            Assert.Equal("xyz", id);
        }

        [Fact]
        public void TestStubWithIdInArray()
        {
            string json = "{\"in_array\":[{\"id\":\"xyz\"}]}";
            var resource = StripeEntity.FromJson<MyTopLevelEntity>(json);
            Assert.NotNull(resource);
            Assert.IsType<MyTopLevelEntity>(resource);
            var id = resource.InArray[0].Id;
            Assert.Equal("xyz", id);
        }

        [Fact]
        public void TestStubWithIdInListObject()
        {
            string json = "{\"in_list_object\":{\"data\":[{\"id\":\"xyz\"}]}}";
            var resource = StripeEntity.FromJson<MyTopLevelEntity>(json);
            Assert.NotNull(resource);
            Assert.IsType<MyTopLevelEntity>(resource);
            var enumerator = resource.InListObject.GetEnumerator();
            enumerator.MoveNext();
            var id = enumerator.Current.Id;
            Assert.Equal("xyz", id);
        }

        [Fact]
        public void TestEmptyObjectDirect()
        {
            string json = "{\"direct\":{}}";
            var resource = StripeEntity.FromJson<MyTopLevelEntity>(json);
            var id = resource.Direct.Id;
            Assert.Null(id);
        }

        [Fact]
        public void TestEmptyObjectArray()
        {
            string json = "{\"in_array\":[{}]}";
            var resource = StripeEntity.FromJson<MyTopLevelEntity>(json);
            var id = resource.InArray[0].Id;
            Assert.Null(id);
        }

        [Fact]
        public void TestEmptyObjectExpanded()
        {
            string json = "{\"expanded\":{}}";
            var resource = StripeEntity.FromJson<MyTopLevelEntity>(json);
            var id = resource.Expanded.Id;
            Assert.Null(id);
        }

        [Fact]
        public void TestEmptyObjectArrayExpanded()
        {
            string json = "{\"array_expanded\":[{}]}";
            var resource = StripeEntity.FromJson<MyTopLevelEntity>(json);
            var id = resource.ArrayExpanded[0].Id;
            Assert.Null(id);
        }

        public class MyReferencedEntity : StripeEntity<MyReferencedEntity>, IHasId
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("some_int")]
            public long SomeInt { get; set; }
        }

        public class MyTopLevelEntity : StripeEntity<MyTopLevelEntity>
        {
            [JsonProperty("direct")]
            public MyReferencedEntity Direct { get; set; }

            #region Expandable Expanded

            [JsonIgnore]
            public string ExpandedId
            {
                get => this.InternalExpanded?.Id;
                set => this.InternalExpanded = SetExpandableFieldId(value, this.InternalExpanded);
            }

            [JsonIgnore]
            public MyReferencedEntity Expanded
            {
                get => this.InternalExpanded?.ExpandedObject;
                set => this.InternalExpanded = SetExpandableFieldObject(value, this.InternalExpanded);
            }

            [JsonProperty("expanded")]
            [JsonConverter(typeof(ExpandableFieldConverter<MyReferencedEntity>))]
            internal ExpandableField<MyReferencedEntity> InternalExpanded { get; set; }
            #endregion

            #region Expandable ArrayExpanded

            [JsonIgnore]
            public List<string> ArrayExpandedIds
            {
                get => this.InternalArrayExpanded?.Select((x) => x.Id).ToList();
                set => this.InternalArrayExpanded = SetExpandableArrayIds<MyReferencedEntity>(value);
            }

            [JsonIgnore]
            public List<MyReferencedEntity> ArrayExpanded
            {
                get => this.InternalArrayExpanded?.Select((x) => x.ExpandedObject).ToList();
                set => this.InternalArrayExpanded = SetExpandableArrayObjects(value);
            }

            [JsonProperty("array_expanded", ItemConverterType = typeof(ExpandableFieldConverter<MyReferencedEntity>))]
            internal List<ExpandableField<MyReferencedEntity>> InternalArrayExpanded { get; set; }
            #endregion

            [JsonProperty("in_array")]
            public List<MyReferencedEntity> InArray { get; set; }

            [JsonProperty("in_list_object")]
            public StripeList<MyReferencedEntity> InListObject { get; set; }
        }
    }
}
