using System.Net;
using Machine.Specifications;
using System;

namespace Stripe.Tests
{
	public class when_requesting_a_mismatched_certificate
	{
		private static StripeError error;

	    private Because of = () => Requestor.GetString("https://mismatched.stripe.com/", out error, "");
	
		It should_raise_a_trust_exception = () => error.StatusCode.ShouldEqual(HttpStatusCode.Forbidden);
	}
}
