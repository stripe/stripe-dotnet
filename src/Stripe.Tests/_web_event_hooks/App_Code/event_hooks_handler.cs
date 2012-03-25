using System;
using System.Web;
using System.IO;

namespace Stripe.Tests
{
	public class event_hooks_handler : IHttpHandler
	{
		public bool IsReusable
		{
			get { return true; }
		}

		public void ProcessRequest(HttpContext context)
		{
			var json = new StreamReader(context.Request.InputStream).ReadToEnd();

			var stripeEvent = StripeEventUtility.ParseEvent(json);
		}
	}
}