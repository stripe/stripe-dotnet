using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stripe
{
	public class StripeServiceBase
	{
		protected bool LiveMode { get; set; }

		public StripeServiceBase() { LiveMode = true; }
		public StripeServiceBase(bool liveMode) { LiveMode = liveMode; }
	}
}
