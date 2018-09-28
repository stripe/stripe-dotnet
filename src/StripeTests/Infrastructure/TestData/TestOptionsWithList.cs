namespace StripeTests.Infrastructure.TestData
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Infrastructure;

    public class TestOptionsWithList : BaseOptions
    {
        public TestOptionsWithList()
        {
            this.SomeList = new List<TestNestedOptions>
            {
                new TestNestedOptions
                {
                    AnInt = 1,
                    AString = "foo",
                },
                new TestNestedOptions
                {
                    AnInt = 2,
                    AString = "bar",
                },
            };
        }

        [FormProperty("some_list")]
        public List<TestNestedOptions> SomeList { get; set; }
    }
}
