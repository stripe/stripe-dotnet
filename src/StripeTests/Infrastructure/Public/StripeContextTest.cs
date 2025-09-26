namespace StripeTests.Infrastructure.Public
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Stripe;
    using Xunit;

    public class StripeContextTest
    {
        [Fact]
        public void Constructor_WithNoSegments_CreatesEmptyContext()
        {
            var context = new StripeContext();
            Assert.Empty(context.Segments);
        }

        [Fact]
        public void Constructor_WithSegments_CreatesContextWithSegments()
        {
            var segments = new[] { "a", "b", "c" };
            var context = new StripeContext(segments);
            Assert.Equal(segments, context.Segments);
        }

        [Fact]
        public void Constructor_WithNullSegments_CreatesEmptyContext()
        {
            var context = new StripeContext(null);
            Assert.Empty(context.Segments);
        }

        [Fact]
        public void Segments_IsReadOnly()
        {
            var context = new StripeContext(new[] { "a", "b" });
            Assert.IsAssignableFrom<IReadOnlyList<string>>(context.Segments);
        }

        [Fact]
        public void Push_WithValidSegment_ReturnsNewContextWithAddedSegment()
        {
            var context = new StripeContext(new[] { "a", "b" });
            var newContext = context.Push("c");

            // Original context unchanged
            Assert.Equal(new[] { "a", "b" }, context.Segments);

            // New context has added segment
            Assert.Equal(new[] { "a", "b", "c" }, newContext.Segments);

            // Different objects
            Assert.NotSame(context, newContext);
        }

        [Fact]
        public void Push_WithNullSegment_ThrowsArgumentNullException()
        {
            var context = new StripeContext();
            Assert.Throws<ArgumentNullException>(() => context.Push(null));
        }

        [Fact]
        public void Push_WithEmptySegment_ThrowsArgumentException()
        {
            var context = new StripeContext();
            Assert.Throws<ArgumentException>(() => context.Push(string.Empty));
        }

        [Fact]
        public void Push_WithWhitespaceSegment_ThrowsArgumentException()
        {
            var context = new StripeContext();
            Assert.Throws<ArgumentException>(() => context.Push("   "));
        }

        [Fact]
        public void Pop_WithSegments_ReturnsNewContextWithLastSegmentRemoved()
        {
            var context = new StripeContext(new[] { "a", "b", "c" });
            var newContext = context.Pop();

            // Original context unchanged
            Assert.Equal(new[] { "a", "b", "c" }, context.Segments);

            // New context has removed last segment
            Assert.Equal(new[] { "a", "b" }, newContext.Segments);

            // Different objects
            Assert.NotSame(context, newContext);
        }

        [Fact]
        public void Pop_WithEmptyContext_ReturnsNewEmptyContext()
        {
            var context = new StripeContext();
            Assert.Throws<InvalidOperationException>(() => context.Pop());
        }

        [Fact]
        public void ToString_WithEmptyContext_ReturnsEmptyString()
        {
            var context = new StripeContext();
            Assert.Equal(string.Empty, context.ToString());
        }

        [Fact]
        public void ToString_WithSingleSegment_ReturnsSegment()
        {
            var context = new StripeContext(new[] { "a" });
            Assert.Equal("a", context.ToString());
        }

        [Fact]
        public void ToString_WithMultipleSegments_ReturnsSlashSeparatedSegments()
        {
            var context = new StripeContext(new[] { "a", "b", "c" });
            Assert.Equal("a/b/c", context.ToString());
        }

        [Fact]
        public void Parse_WithNullString_ReturnsEmptyContext()
        {
            var context = StripeContext.Parse(null);
            Assert.Empty(context.Segments);
        }

        [Fact]
        public void Parse_WithEmptyString_ReturnsEmptyContext()
        {
            var context = StripeContext.Parse(string.Empty);
            Assert.Empty(context.Segments);
        }

        [Fact]
        public void Parse_WithSingleSegment_ReturnsContextWithSingleSegment()
        {
            var context = StripeContext.Parse("a");
            Assert.Equal(new[] { "a" }, context.Segments);
        }

        [Fact]
        public void Parse_WithMultipleSegments_ReturnsContextWithMultipleSegments()
        {
            var context = StripeContext.Parse("a/b/c");
            Assert.Equal(new[] { "a", "b", "c" }, context.Segments);
        }

        [Fact]
        public void Equals_WithSameSegments_ReturnsTrue()
        {
            var context1 = new StripeContext(new[] { "a", "b" });
            var context2 = new StripeContext(new[] { "a", "b" });

            Assert.True(context1.Equals(context2));
        }

        [Fact]
        public void Equals_WithDifferentSegments_ReturnsFalse()
        {
            var context1 = new StripeContext(new[] { "a", "b" });
            var context2 = new StripeContext(new[] { "a", "c" });

            Assert.False(context1.Equals(context2));
            Assert.True(context1 != context2);
        }

        [Fact]
        public void Equals_WithNull_ReturnsFalse()
        {
            var context = new StripeContext(new[] { "a", "b" });

            Assert.False(context.Equals(null));
            Assert.False(context.Equals((object)null));
        }

        [Fact]
        public void GetHashCode_WithEqualContexts_ReturnsSameHashCode()
        {
            var context1 = new StripeContext(new[] { "a", "b" });
            var context2 = new StripeContext(new[] { "a", "b" });

            Assert.Equal(context1.GetHashCode(), context2.GetHashCode());
        }

        [Fact]
        public void ImplicitConversion_FromString_CreatesStripeContext()
        {
            StripeContext context = "a/b/c";
            Assert.Equal(new[] { "a", "b", "c" }, context.Segments);
        }

        [Fact]
        public void ImplicitConversion_ToString_ReturnsStringRepresentation()
        {
            var context = new StripeContext(new[] { "a", "b", "c" });
            string contextStr = context;
            Assert.Equal("a/b/c", contextStr);
        }

        [Fact]
        public void ImplicitConversion_NullContext_ReturnsNull()
        {
            StripeContext context = null;
            string contextStr = context;
            Assert.Null(contextStr);
        }

        [Fact]
        public void Immutability_OperationsDoNotModifyOriginalContext()
        {
            var original = new StripeContext(new[] { "a", "b" });
            var pushed = original.Push("c");
            var popped = original.Pop();

            // Original remains unchanged
            Assert.Equal(new[] { "a", "b" }, original.Segments);
            Assert.Equal(new[] { "a", "b", "c" }, pushed.Segments);
            Assert.Equal(new[] { "a" }, popped.Segments);

            // All are different objects
            Assert.NotSame(original, pushed);
            Assert.NotSame(original, popped);
            Assert.NotSame(pushed, popped);
        }

        [Fact]
        public void UsagePattern_ContextHierarchyBuilding()
        {
            // Common usage: start with base context, add child contexts
            var baseContext = StripeContext.Parse("workspace_123");
            var child = baseContext.Push("account_456");
            var grandchild = child.Push("customer_789");

            Assert.Equal("workspace_123", baseContext.ToString());
            Assert.Equal("workspace_123/account_456", child.ToString());
            Assert.Equal("workspace_123/account_456/customer_789", grandchild.ToString());

            // Go back up the hierarchy
            var backToChild = grandchild.Pop();
            var backToBase = backToChild.Pop();

            Assert.Equal("workspace_123/account_456", backToChild.ToString());
            Assert.Equal("workspace_123", backToBase.ToString());
        }
    }
}
