namespace Stripe
{
	public class StripeBalanceService
	{
		private string ApiKey { get; set; }

		public StripeBalanceService(string apiKey = null)
		{
			ApiKey = apiKey;
		}

		public virtual StripeBalance Get()
		{
			var response = Requestor.GetString(Urls.Balance, ApiKey);
			
			return Mapper<StripeBalance>.MapFromJson(response);
		}
	}
}
