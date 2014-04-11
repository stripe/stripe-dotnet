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
			// ideally this would be more a specific exception type, but I developed
			// this test on mono and ex.GetBaseException returned a mono-specific
			// exception type
			ex.ShouldBeOfType<System.Net.WebException>();
	}

	// This is to say a non-blacklisted but name-mismatched certificate.
	// The goal here is to ensure that SSL policy checks are still working.
	public class when_requesting_a_mismatched_certificate
	{
		protected static Exception ex;

		Because of = () =>
			ex = Catch.Exception(() => Requestor.GetString("https://mismatched.stripe.com/", ""));

		It should_raise_an_authentication_exception = () =>
			// ideally this would be more a specific exception type, but I developed
			// this test on mono and ex.GetBaseException returned a mono-specific
			// exception type
			ex.ShouldBeOfType<System.Net.WebException>();
	}

}
