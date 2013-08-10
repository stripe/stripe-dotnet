using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripeCardList
	{
		[JsonProperty("data")]
		public List<StripeCard> StripeCards { get; set; }
	}
}
