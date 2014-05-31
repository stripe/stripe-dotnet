using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stripe
{
	public abstract class StripeService
	{
		public string ApiKey { get; set; }

		public StripeService(string	apiKey)
		{
			ApiKey = apiKey;
		}
	}
}
