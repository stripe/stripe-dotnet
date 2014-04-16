using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;

namespace Stripe.Tests.infrastructure
{
	public class when_passed_empty_object
	{
		private const string original = "foo";
		private static string _result;

		Because of = () =>
			_result = ParameterBuilder.ApplyAllParameters(null, original);

		It should_return_original = () =>
			_result.ShouldEqual(original);
	}
}
