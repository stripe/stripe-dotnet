namespace Stripe
{
	public class StripeAccountService
	{
		private string ApiKey { get; set; }

		public StripeAccountService(string apiKey = null)
		{
			ApiKey = apiKey;
		}

		public virtual StripeAccount Get()
		{
			var response = Requestor.GetString(Urls.Account, ApiKey);

			return Mapper<StripeAccount>.MapFromJson(response);
		}
	}
}