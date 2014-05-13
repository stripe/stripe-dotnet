namespace Stripe
{
	public class StripeAccountService
	{
		private string ApiKey { get; set; }

		public StripeAccountService(string apiKey = null)
		{
			ApiKey = apiKey;
		}

		public virtual StripeResponse<StripeAccount> Get()
		{
		    return Urls.Account.GetResponse<StripeAccount>(ApiKey);
		}
	}
}