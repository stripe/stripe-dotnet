using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.xUnit
{
    public abstract class test
    {
        protected readonly string _stripe_api_key = "sk_test_H6laumw3ZO9BQ4r3eL58fUcM";
            //Environment.GetEnvironmentVariable("stripe_test_secret_key");
    }
}
