using System.Net;
using Machine.Specifications;
using System;

namespace Stripe.Tests
{
	public class when_requesting_a_blacklisted_certificate
	{
		protected static Exception ex;

		Because of = () =>
			ex = Catch.Exception(() => Requestor.GetString("https://revoked.stripe.com:444/", ""));

		It should_raise_an_authentication_exception = () =>
			ex.ShouldBeOfType<WebException>();

		It should_be_a_trust_failure = () =>
			((WebException) ex).Status.ShouldEqual(WebExceptionStatus.TrustFailure);
	}
}
