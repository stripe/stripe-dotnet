using System.Runtime.InteropServices.ComTypes;

namespace Stripe
{
    public class StripeTokenService
	{
		private string ApiKey { get; set; }

		public StripeTokenService(string apiKey = null)
		{
			ApiKey = apiKey;
		}

		public virtual StripeResponse<StripeToken> Create(StripeTokenCreateOptions createOptions)
		{
			var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.Tokens);

		    return url.PostResponse<StripeToken>(ApiKey);
		}

        public virtual StripeResponse<StripeToken> Get(string tokenId)
		{
			var url = string.Format("{0}/{1}", Urls.Tokens, tokenId);

            return url.GetResponse<StripeToken>(ApiKey);
		}
	}
}