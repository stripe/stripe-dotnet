using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeCardList : StripeBase
	{
		[JsonProperty("data")]
		public List<StripeCard> StripeCards { get; set; }
	}
}
