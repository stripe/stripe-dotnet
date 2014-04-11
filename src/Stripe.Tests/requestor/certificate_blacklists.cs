using Machine.Specifications;
using System;

namespace Stripe.Tests
{
	public class certificate_blacklists
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
}
