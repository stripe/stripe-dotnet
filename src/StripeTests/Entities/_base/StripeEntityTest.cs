namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    public class StripeEntityTest : BaseStripeTest
    {
        public StripeEntityTest(
            StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void FromJsonAuto()
        {
            var json = "{\"id\": \"ch_123\", \"object\": \"charge\"}";

            var o = StripeEntity.FromJson(json);

            Assert.NotNull(o);
            Assert.IsType<Charge>(o);
            Assert.Equal("ch_123", ((Charge)o).Id);
        }

        [Fact]
        public void FromJsonAutoUnknownObject()
        {
            var json = "{\"id\": \"ch_123\", \"object\": \"foo\"}";

            var o = StripeEntity.FromJson(json);

            Assert.Null(o);
        }

        [Fact]
        public void FromJsonAutoNoObject()
        {
            var json = "{\"id\": \"ch_123\"}";

            var o = StripeEntity.FromJson(json);

            Assert.Null(o);
        }

        [Fact]
        public void FromJsonOnType()
        {
            var json = "{\"integer\": 234, \"string\": \"String!\"}";

            var o = TestEntity.FromJson(json);

            Assert.NotNull(o);
            Assert.Equal(234, o.Integer);
            Assert.Equal("String!", o.String);
        }

        [Fact]
        public void FromJsonGeneric()
        {
            var json = "{\"integer\": 234, \"string\": \"String!\"}";

            var o = StripeEntity.FromJson<TestEntity>(json);

            Assert.NotNull(o);
            Assert.Equal(234, o.Integer);
            Assert.Equal("String!", o.String);
        }

        [Fact]
        public void ToJson()
        {
            var o = new TestEntity
            {
                Integer = 234,
                String = "String!",
            };

            var json = o.ToJson().Replace("\r\n", "\n");

            var expectedJson = "{\n  \"integer\": 234,\n  \"string\": \"String!\",\n  \"nested\": null\n}";
            Assert.Equal(expectedJson, json);
        }

        [Fact]
        public void ExpandableAccessors_Id()
        {
            var o = new TestEntity
            {
                NestedId = "id_unexpanded",
            };

            Assert.Equal("id_unexpanded", o.NestedId);
            Assert.Null(o.Nested);
        }

        [Fact]
        public void ExpandableAccessors_ExpandedObject()
        {
            var o = new TestEntity
            {
                Nested = new TestNestedEntity { Id = "id_expanded", Bar = 42 },
            };

            Assert.Equal("id_expanded", o.NestedId);
            Assert.NotNull(o.Nested);
            Assert.Equal("id_expanded", o.Nested.Id);
            Assert.Equal(42, o.Nested.Bar);
        }

        [Fact]
        public void ExpandableAccessors_Null()
        {
            var o = new TestEntity();

            Assert.Null(o.NestedId);
            Assert.Null(o.Nested);
        }

        [Fact]
        public void ExpandableAccessors_Id_ResetsExistingExpandedObjectIfIdIsDifferent()
        {
            var o = new TestEntity
            {
                Nested = new TestNestedEntity { Id = "id_expanded", Bar = 42 },
            };
            o.NestedId = "id_new";

            Assert.Equal("id_new", o.NestedId);
            Assert.Null(o.Nested);
        }

        [Fact]
        public void ExpandableAccessors_Id_DoesNotResetExistingExpandedObjectIfIdIsSame()
        {
            var o = new TestEntity
            {
                Nested = new TestNestedEntity { Id = "id_expanded", Bar = 42 },
            };
            o.NestedId = "id_expanded";

            Assert.Equal("id_expanded", o.NestedId);
            Assert.NotNull(o.Nested);
            Assert.Equal("id_expanded", o.Nested.Id);
            Assert.Equal(42, o.Nested.Bar);
        }

        [Fact]
        public void RawJObject()
        {
            var service = new SubscriptionService(this.StripeClient);
            var subscription = service.Get("sub_123");

            Assert.NotNull(subscription);

            // Access `id`, a string element
            Assert.Equal(subscription.Id, subscription.RawJObject["id"]);

            // Access `created`, a number element
            Assert.Equal(subscription.Created, subscription.RawJObject["created"]);

            // Access `plan[id]`, a nested string element
            Assert.Equal(subscription.Plan.Id, subscription.RawJObject["plan"]["id"]);

            // Access `items[data][0][id]`, a deeply nested string element
            Assert.Equal(
                subscription.Items.Data[0].Id,
                subscription.RawJObject["items"]["data"][0]["id"]);
        }

        private class TestEntity : StripeEntity<TestEntity>
        {
            [JsonProperty("integer")]
            public int Integer { get; set; }

            [JsonProperty("string")]
            public string String { get; set; }

            [JsonIgnore]
            public string NestedId
            {
                get => this.InternalNested?.Id;
                set => this.InternalNested = SetExpandableFieldId(value, this.InternalNested);
            }

            [JsonIgnore]
            public TestNestedEntity Nested
            {
                get => this.InternalNested?.ExpandedObject;
                set => this.InternalNested = SetExpandableFieldObject(value, this.InternalNested);
            }

            [JsonProperty("nested")]
            [JsonConverter(typeof(ExpandableFieldConverter<TestNestedEntity>))]
            internal ExpandableField<TestNestedEntity> InternalNested { get; set; }
        }

        private class TestNestedEntity : StripeEntity<TestNestedEntity>, IHasId
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("bar")]
            public int Bar { get; set; }
        }
    }
}
