namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    public class AbstractStripeObjectConverterTest : BaseStripeTest
    {
        private FooOrBarConverter converter;

        public AbstractStripeObjectConverterTest()
        {
            this.converter = new FooOrBarConverter();
        }

        private interface IFooOrBar : IHasObject
        {
        }

        [Fact]
        public void InstantiatesAFoo()
        {
            var json = "{\"object\": \"foo\", \"some_string\": \"Hello\"}";

            var obj = JsonConvert.DeserializeObject<IFooOrBar>(json, this.converter);

            Assert.IsType<Foo>(obj);
            Assert.Equal("foo", obj.Object);
            Assert.Equal("Hello", ((Foo)obj).SomeString);
        }

        [Fact]
        public void InstantiatesABar()
        {
            var json = "{\"object\": \"bar\", \"some_long\": 42}";

            var obj = JsonConvert.DeserializeObject<IFooOrBar>(json, this.converter);

            Assert.IsType<Bar>(obj);
            Assert.Equal("bar", obj.Object);
            Assert.Equal(42, ((Bar)obj).SomeLong);
        }

        [Fact]
        public void ReturnsNullOnUnknownType()
        {
            var json = "{\"object\": \"unknown\", \"some_list\": [1, 2, 3]}";

            var obj = JsonConvert.DeserializeObject<IFooOrBar>(json, this.converter);

            Assert.Null(obj);
        }

        private class Foo : IFooOrBar
        {
            [JsonProperty("object")]
            public string Object { get; set; }

            [JsonProperty("some_string")]
            public string SomeString { get; set; }
        }

        private class Bar : IFooOrBar
        {
            [JsonProperty("object")]
            public string Object { get; set; }

            [JsonProperty("some_long")]
            public long SomeLong { get; set; }
        }

        private class FooOrBarConverter : AbstractStripeObjectConverter<IFooOrBar>
        {
            protected override Dictionary<string, Func<string, IFooOrBar>> ObjectsToMapperFuncs =>
                new Dictionary<string, Func<string, IFooOrBar>>()
            {
                { "foo", Mapper<Foo>.MapFromJson },
                { "bar", Mapper<Bar>.MapFromJson },
            };
        }
    }
}
