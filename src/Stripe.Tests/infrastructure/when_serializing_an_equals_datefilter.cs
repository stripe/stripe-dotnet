using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using Stripe.Tests.infrastructure.test_data;

namespace Stripe.Tests.infrastructure
{
	class when_serializing_an_equals_datefilter
	{
		private const string origurl = "http://test/foo";
		private static sample_object _testObject;
		private static string _result;

		Establish context = () =>
		{
			_testObject = new sample_object();
		};

		Because of = () =>
		{
			_result = ParameterBuilder.ApplyAllParameters(_testObject, origurl);
		};

		It should_contain_plain_equals = () =>
			_result.ShouldContain("dateequals=946684800");

		It should_not_contain_complex_filter = () =>
			_result.ShouldNotContain("dateequals[");
	}
}
