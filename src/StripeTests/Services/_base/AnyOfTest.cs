namespace StripeTests
{
    using System;
    using Stripe;
    using Xunit;

    public class AnyOfTest : BaseStripeTest
    {
        [Fact]
        public void Ctor_Variant1Type()
        {
            var testCases = new[]
            {
                new TestCase
                {
                    AnyOf = new AnyOf<int>(default),
                    WantValue = default(int),
                    WantType = typeof(int),
                },
                new TestCase
                {
                    AnyOf = new AnyOf<int>(234),
                    WantValue = 234,
                    WantType = typeof(int),
                },
                new TestCase
                {
                    AnyOf = new AnyOf<string>(default),
                    WantValue = default(string),
                    WantType = typeof(string),
                },
                new TestCase
                {
                    AnyOf = new AnyOf<string>("Hello!"),
                    WantValue = "Hello!",
                    WantType = typeof(string),
                },
                new TestCase
                {
                    AnyOf = new AnyOf<int?>(default(int?)),
                    WantValue = default(int?),
                    WantType = typeof(int?),
                },
            };

            foreach (var testCase in testCases)
            {
                Assert.Equal(testCase.WantValue, testCase.AnyOf.Value);
                Assert.Equal(testCase.WantType, testCase.AnyOf.Type);
            }
        }

        [Fact]
        public void Ctor_Variant2Types()
        {
            var testCases = new[]
            {
                new TestCase
                {
                    AnyOf = new AnyOf<int, string>(default(int)),
                    WantValue = default(int),
                    WantType = typeof(int),
                },
                new TestCase
                {
                    AnyOf = new AnyOf<int, string>(234),
                    WantValue = 234,
                    WantType = typeof(int),
                },
                new TestCase
                {
                    AnyOf = new AnyOf<int, string>(default(string)),
                    WantValue = default(string),
                    WantType = typeof(string),
                },
                new TestCase
                {
                    AnyOf = new AnyOf<int, string>("Hello!"),
                    WantValue = "Hello!",
                    WantType = typeof(string),
                },
                new TestCase
                {
                    AnyOf = new AnyOf<int?, string>(default(int?)),
                    WantValue = default(int?),
                    WantType = typeof(int?),
                },
            };

            foreach (var testCase in testCases)
            {
                Assert.Equal(testCase.WantValue, testCase.AnyOf.Value);
                Assert.Equal(testCase.WantType, testCase.AnyOf.Type);
            }
        }

        [Fact]
        public void Ctor_Variant3Types()
        {
            var someClass = new SomeClass { SomeString = "foo" };
            var testCases = new[]
            {
                new TestCase
                {
                    AnyOf = new AnyOf<int, string, SomeClass>(default(int)),
                    WantValue = default(int),
                    WantType = typeof(int),
                },
                new TestCase
                {
                    AnyOf = new AnyOf<int, string, SomeClass>(234),
                    WantValue = 234,
                    WantType = typeof(int),
                },
                new TestCase
                {
                    AnyOf = new AnyOf<int, string, SomeClass>(default(string)),
                    WantValue = default(string),
                    WantType = typeof(string),
                },
                new TestCase
                {
                    AnyOf = new AnyOf<int, string, SomeClass>("Hello!"),
                    WantValue = "Hello!",
                    WantType = typeof(string),
                },
                new TestCase
                {
                    AnyOf = new AnyOf<int?, string, SomeClass>(default(int?)),
                    WantValue = default(int?),
                    WantType = typeof(int?),
                },
                new TestCase
                {
                    AnyOf = new AnyOf<int?, string, SomeClass>(default(SomeClass)),
                    WantValue = default(SomeClass),
                    WantType = typeof(SomeClass),
                },
                new TestCase
                {
                    AnyOf = new AnyOf<int?, string, SomeClass>(someClass),
                    WantValue = someClass,
                    WantType = typeof(SomeClass),
                },
            };

            foreach (var testCase in testCases)
            {
                Assert.Equal(testCase.WantValue, testCase.AnyOf.Value);
                Assert.Equal(testCase.WantType, testCase.AnyOf.Type);
            }
        }

        [Fact]
        public void ImplicitOperator_ReturnsNullForNullValuesRegardlessOfType()
        {
            var testCases = new[]
            {
                new Container(),
                new Container { AnyOf2 = null },
                new Container { AnyOf2 = (AnyOf<int, string>)null },
                new Container { AnyOf2 = (string)null },
                new Container { AnyOf3 = null },
                new Container { AnyOf3 = (AnyOf<int, string, SomeClass>)null },
                new Container { AnyOf3 = (string)null },
                new Container { AnyOf3 = (SomeClass)null },
            };

            foreach (var testCase in testCases)
            {
                Assert.Null(testCase.AnyOf2);
                Assert.Null(testCase.AnyOf3);
            }
        }

        private class TestCase
        {
            public IAnyOf AnyOf { get; set; }

            public object WantValue { get; set; }

            public Type WantType { get; set; }
        }

        private class SomeClass
        {
            public string SomeString { get; set; }
        }

        private class Container
        {
            public AnyOf<int, string> AnyOf2 { get; set; }

            public AnyOf<int, string, SomeClass> AnyOf3 { get; set; }
        }
    }
}
