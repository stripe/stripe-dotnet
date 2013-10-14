namespace Stripe
{
	public class StripeTokenService
	{
		private string ApiKey { get; set; }

		public StripeTokenService(string apiKey = null)
		{
			ApiKey = apiKey;
		}

		public virtual StripeToken Create(StripeTokenCreateOptions createOptions)
		{
			var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.Tokens);

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeToken>.MapFromJson(response);
		}

		public virtual StripeToken Get(string tokenId)
		{
			var url = string.Format("{0}/{1}", Urls.Tokens, tokenId);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeToken>.MapFromJson(response);
		}
	}
}