namespace StripeTests.Infrastructure.Public
{
    using System;
    using Stripe;
    using Stripe.V2.Core;
    using Xunit;

    public class StripeContextIntegrationTest
    {
        [Fact]
        public void RequestOptions_StripeContextObject_GetAndSet()
        {
            var context = new StripeContext(new[] { "workspace", "123" });
            var options = new RequestOptions
            {
                StripeContext = context,
            };

            Assert.Equal("workspace/123", options.StripeContext);
        }

        [Fact]
        public void RequestOptions_StripeContextConversion()
        {
            var options = new RequestOptions
            {
                StripeContext = "a/b/c",
            };

            Assert.Equal("a/b/c", options.StripeContext);
            StripeContext ctx = options.StripeContext;
            Assert.Equal(new[] { "a", "b", "c" }, ctx.Segments);
        }

        [Fact]
        public void RequestOptions_StripeContextNull_ReturnsNullObject()
        {
            var options = new RequestOptions
            {
                StripeContext = null,
            };

            Assert.Null(options.StripeContext);
        }

        [Fact]
        public void StripeClientOptions_StripeContextObject_GetAndSet()
        {
            var context = new StripeContext(new[] { "workspace", "123" });
            var options = new StripeClientOptions()
            {
                StripeContext = context,
            };

            Assert.Equal("workspace/123", options.StripeContext);
        }

        [Fact]
        public void StripeClientOptions_StripeContextString_ReturnsContextObject()
        {
            var options = new StripeClientOptions
            {
                StripeContext = "a/b/c",
            };

            Assert.Equal("a/b/c", options.StripeContext);
            StripeContext ctx = options.StripeContext;
            Assert.Equal(new[] { "a", "b", "c" }, ctx.Segments);
        }

        [Fact]
        public void EventNotification_ContextString_ReturnsStripeContextObject()
        {
            var eventNotification = new EventNotification
            {
                Id = "evt_123",
                Type = "test.event",
                Created = DateTime.UtcNow,
                Livemode = false,
                Context = "a/b/c",
            };

            Assert.Equal("a/b/c", eventNotification.Context);
        }

        [Fact]
        public void EventNotification_NullContext_ReturnsNullStripeContext()
        {
            var eventNotification = new EventNotification
            {
                Id = "evt_123",
                Type = "test.event",
                Created = DateTime.UtcNow,
                Livemode = false,
                Context = null,
            };

            Assert.Null(eventNotification.Context);
        }

        [Fact]
        public void EventNotification_EmptyContext_ReturnsEmptyStripeContext()
        {
            var eventNotification = new EventNotification
            {
                Id = "evt_123",
                Type = "test.event",
                Created = DateTime.UtcNow,
                Livemode = false,
                Context = string.Empty,
            };

            Assert.Null(eventNotification.Context);
        }

        [Fact]
        public void ContextBuilderPattern_WorksWithRequestOptions()
        {
            var baseContext = StripeContext.Parse("workspace_123");
            var options = new RequestOptions
            {
                StripeContext = baseContext.Push("account_456"),
            };
            Assert.Equal("workspace_123/account_456", options.StripeContext);
        }

        [Fact]
        public void ContextCompatibility_StringAndObjectEquivalent()
        {
            var stringOptions = new RequestOptions
            {
                StripeContext = "a/b/c",
            };
            var context = new StripeContext(new[] { "a", "b", "c" });
            var contextOptions = new RequestOptions
            {
                StripeContext = context,
            };

            // Both should represent the same logical context
            Assert.Equal(stringOptions.StripeContext, contextOptions.StripeContext);
        }

        [Fact]
        public void ImplicitConversion_WorksInRequestOptions()
        {
            var options = new RequestOptions();

            // Can assign string to StripeContext due to implicit conversion
            options.StripeContext = "workspace/123";
            Assert.Equal("workspace/123", options.StripeContext);
        }

        [Fact]
        public void RequestOptionsExtensions_WithClientOptions_PreservesStripeContext()
        {
            var clientOptions = new StripeClientOptions
            {
                ApiKey = "sk_test_123",
                StripeContext = "client_context",
            };

            var requestOptions = new RequestOptions
            {
                StripeContext = "request_context",
            };

            var merged = requestOptions.WithClientOptions(clientOptions);

            // Request context should take precedence
            Assert.Equal("request_context", merged.StripeContext);
        }

        [Fact]
        public void RequestOptionsExtensions_WithClientOptions_FallsBackToClientContext()
        {
            var clientOptions = new StripeClientOptions
            {
                ApiKey = "sk_test_123",
                StripeContext = "client_context",
            };

            var requestOptions = new RequestOptions();

            var merged = requestOptions.WithClientOptions(clientOptions);

            // Should use client context when request has none
            Assert.Equal("client_context", merged.StripeContext);
        }

        [Fact]
        public void RequestOptionsExtensions_WithClientOptions_RequestOverwritesWithEmptyContext()
        {
            var clientOptions = new StripeClientOptions
            {
                ApiKey = "sk_test_123",
                StripeContext = "client_context",
            };

            var requestOptions = new RequestOptions
            {
                StripeContext = new StripeContext(),
            };

            var merged = requestOptions.WithClientOptions(clientOptions);

            // Should use client context when request has none
            Assert.Equal(string.Empty, merged.StripeContext);
        }

        [Fact]
        public void RequestOptionsExtensions_WithClientOptions_RequestOverwritesEmptyClientContext()
        {
            var clientOptions = new StripeClientOptions
            {
                ApiKey = "sk_test_123",
                StripeContext = new StripeContext(),
            };

            var requestOptions = new RequestOptions
            {
                StripeContext = "acct_123",
            };

            var merged = requestOptions.WithClientOptions(clientOptions);

            // Should use client context when request has none
            Assert.Equal("acct_123", merged.StripeContext);
        }
    }
}
