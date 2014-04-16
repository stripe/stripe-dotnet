using Newtonsoft.Json;
namespace Stripe
{
	public class StripeCardListOptions : StripeListOptions
	{
		public string Customer { get; set; }
	}
}
