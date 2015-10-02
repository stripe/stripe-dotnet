using System.Net;
using Machine.Specifications;
using System;

namespace Stripe.Tests
{
    public class when_requesting_a_mismatched_certificate
    {
        private static WebException ex;

        Because of = () =>
            ex = (WebException) Catch.Exception(() => Requestor.Instance.GetString("https://mismatched.stripe.com/", new StripeRequestOptions()));

        It should_raise_a_trust_exception = () =>
             ex.Status.ShouldEqual(WebExceptionStatus.TrustFailure);
    }
}
