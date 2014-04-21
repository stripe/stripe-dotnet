using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Machine.Specifications;
using NCrunch.Framework;

namespace Stripe.Tests.requestor
{
	[Serial]		// Lowering API version at global level, so can't have any other tests running
	public class when_requesting_an_old_api_version
	{
		protected static string _response;

		Because of = () =>
		{
			// Temporarily lower API version
			StripeConfiguration.ApiVersion = "2014-03-13";		// Re-adds .Count property to list methods

			_response = Requestor.GetString(Urls.Customers);

			// Restore main supported API version
			StripeConfiguration.ApiVersion = StripeConfiguration.SupportedApiVersion;
		};

		It should_contain_count_property = () =>
			_response.ShouldContain("\"count\":");
	}
}
