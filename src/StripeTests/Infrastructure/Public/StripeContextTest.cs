namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class StripeContextTest : BaseStripeTest
    {
        [Fact]
        public void EmptyContext()
        {
            var context = new StripeContext();
            Assert.Equal(string.Empty, context.ToString());
        }

        [Fact]
        public void ContextWithSegments()
        {
            var context = new StripeContext(new[] { "a", "b", "c" });
            Assert.Equal("a/b/c", context.ToString());
        }

        [Fact]
        public void ParseEmptyString()
        {
            var context = StripeContext.Parse(string.Empty);
            Assert.Equal(string.Empty, context.ToString());
        }

        [Fact]
        public void ParseNullString()
        {
            var context = StripeContext.Parse(null);
            Assert.Equal(string.Empty, context.ToString());
        }

        [Fact]
        public void ParseSingleSegment()
        {
            var context = StripeContext.Parse("a");
            Assert.Equal("a", context.ToString());
        }

        [Fact]
        public void ParseMultipleSegments()
        {
            var context = StripeContext.Parse("a/b/c");
            Assert.Equal("a/b/c", context.ToString());
        }

        [Fact]
        public void ParentReturnsNewInstance()
        {
            var context = StripeContext.Parse("a/b/c");
            var parent = context.Parent();

            // Original unchanged
            Assert.Equal("a/b/c", context.ToString());
            // New instance with removed segment
            Assert.Equal("a/b", parent.ToString());
        }

        [Fact]
        public void ParentOfSingleSegment()
        {
            var context = StripeContext.Parse("a");
            var parent = context.Parent();
            Assert.Equal(string.Empty, parent.ToString());
        }

        [Fact]
        public void ParentOfEmptyContextThrowsException()
        {
            var context = new StripeContext();

            var ex = Assert.Throws<InvalidOperationException>(() => context.Parent());
            Assert.Equal("Cannot get parent of empty context", ex.Message);
        }

        [Fact]
        public void ChildReturnsNewInstance()
        {
            var context = StripeContext.Parse("a/b");
            var child = context.Child("c");

            // Original unchanged
            Assert.Equal("a/b", context.ToString());
            // New instance with added segment
            Assert.Equal("a/b/c", child.ToString());
        }

        [Fact]
        public void ChildOnEmptyContext()
        {
            var context = new StripeContext();
            var child = context.Child("a");
            Assert.Equal("a", child.ToString());
        }

        [Fact]
        public void MethodChaining()
        {
            var context = StripeContext.Parse("a");
            var result = context.Child("b").Child("c").Parent();
            Assert.Equal("a/b", result.ToString());
        }

        [Fact]
        public void InitWithNullSegments()
        {
            var context = new StripeContext(null);
            Assert.Equal(string.Empty, context.ToString());
        }

        [Fact]
        public void InitWithEmptyList()
        {
            var context = new StripeContext(new List<string>());
            Assert.Equal(string.Empty, context.ToString());
        }

        [Fact]
        public void RequestOptionsSetStripeContext()
        {
            var context = StripeContext.Parse("org_123/proj_456");
            var options = new RequestOptions();

            options.SetStripeContext(context);

            Assert.Equal("org_123/proj_456", options.StripeContext);
        }

        [Fact]
        public void RequestOptionsSetStripeContextWithNull()
        {
            var options = new RequestOptions();
            options.SetStripeContext(null);

            Assert.Null(options.StripeContext);
        }

        [Fact]
        public void StripeClientOptionsSetStripeContext()
        {
            var context = StripeContext.Parse("org_123/proj_456");
            var clientOptions = new StripeClientOptions();

            clientOptions.SetStripeContext(context);

            Assert.Equal("org_123/proj_456", clientOptions.StripeContext);
        }

        [Fact]
        public void StripeClientOptionsSetStripeContextWithNull()
        {
            var clientOptions = new StripeClientOptions();
            clientOptions.SetStripeContext(null);

            Assert.Null(clientOptions.StripeContext);
        }

        [Fact]
        public void JsonSerializationWithContext()
        {
            var thinEvent = new ThinEvent
            {
                Context = StripeContext.Parse("org_123/proj_456")
            };

            var json = JsonConvert.SerializeObject(thinEvent);
            var deserializedEvent = JsonConvert.DeserializeObject<ThinEvent>(json);

            Assert.NotNull(deserializedEvent.Context);
            Assert.Equal("org_123/proj_456", deserializedEvent.Context.ToString());
        }

        [Fact]
        public void JsonSerializationWithEmptyContext()
        {
            var thinEvent = new ThinEvent
            {
                Context = new StripeContext()
            };

            var json = JsonConvert.SerializeObject(thinEvent);
            var deserializedEvent = JsonConvert.DeserializeObject<ThinEvent>(json);

            Assert.NotNull(deserializedEvent.Context);
            Assert.Equal(string.Empty, deserializedEvent.Context.ToString());
        }

        [Fact]
        public void JsonSerializationWithNullContext()
        {
            var thinEvent = new ThinEvent
            {
                Context = null
            };

            var json = JsonConvert.SerializeObject(thinEvent);
            var deserializedEvent = JsonConvert.DeserializeObject<ThinEvent>(json);

            Assert.Null(deserializedEvent.Context);
        }

        [Fact]
        public void JsonDeserializationFromString()
        {
            var json = @"{""context"":""org_123/proj_456""}";

            var thinEvent = JsonConvert.DeserializeObject<ThinEvent>(json);

            Assert.NotNull(thinEvent.Context);
            Assert.Equal("org_123/proj_456", thinEvent.Context.ToString());
        }

        [Fact]
        public void JsonDeserializationFromEmptyString()
        {
            var json = @"{""context"":""""}";

            var thinEvent = JsonConvert.DeserializeObject<ThinEvent>(json);

            Assert.NotNull(thinEvent.Context);
            Assert.Equal(string.Empty, thinEvent.Context.ToString());
        }

        [Fact]
        public void JsonDeserializationFromNull()
        {
            var json = @"{""context"":null}";

            var thinEvent = JsonConvert.DeserializeObject<ThinEvent>(json);

            Assert.Null(thinEvent.Context);
        }

        [Fact]
        public void EmptyContextDoesNotSetHeader()
        {
            var emptyContext = new StripeContext();
            var options = new RequestOptions();

            options.SetStripeContext(emptyContext);

            // Empty context should result in null StripeContext
            Assert.Null(options.StripeContext);
        }

        [Fact]
        public void NonEmptyContextSetsHeader()
        {
            var context = StripeContext.Parse("org_123/proj_456");
            var options = new RequestOptions();

            options.SetStripeContext(context);

            // Non-empty context should set the header
            Assert.Equal("org_123/proj_456", options.StripeContext);
        }
    }
}