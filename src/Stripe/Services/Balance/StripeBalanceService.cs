namespace Stripe
{
	public class StripeBalanceService
	{
		private string ApiKey { get; set; }

		public StripeBalanceService(string apiKey = null)
		{
			ApiKey = apiKey;
		}

		public virtual StripeResponse<StripeBalance> Get()
		{
			return Urls.Balance.GetResponse<StripeBalance>(ApiKey);
		}
	}
}
