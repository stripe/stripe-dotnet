using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Machine.Specifications;

namespace Stripe.Tests.requestor
{
	public class when_creating_a_request
	{
		protected static HttpWebRequest _request;
		private const string url = "http://testurl/foo";
		private const string method = "method";

		Because of = () =>
			_request = (HttpWebRequest) Requestor.GetWebRequest(url, method);

		It should_have_matching_url = () =>
			_request.RequestUri.ToString().ShouldEqual(url);

		It should_have_matching_method = () =>
			_request.Method.ShouldEqual(method);

		It should_have_urlencoded_content_type = () =>
			_request.ContentType.ShouldEqual("application/x-www-form-urlencoded");

		It should_have_stripeversion_header_matching_config = () =>
			_request.Headers["Stripe-Version"].ShouldEqual(StripeConfiguration.ApiVersion);

		It should_contain_user_agent = () =>
			_request.UserAgent.ShouldStartWith("Stripe.net");

	}
}
