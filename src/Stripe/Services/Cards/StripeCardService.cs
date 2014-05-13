using System.Collections.Generic;

namespace Stripe
{
	public class StripeCardService
	{
		private string ApiKey { get; set; }

		public StripeCardService(string apiKey = null)
		{
			ApiKey = apiKey;
		}

		public virtual StripeResponse<StripeCard> Create(string customerId, StripeCardCreateOptions createOptions)
		{
			var url = string.Format(Urls.Cards, customerId);
			url = ParameterBuilder.ApplyAllParameters(createOptions, url);

		    return url.PostResponse<StripeCard>(ApiKey);
		}

        public virtual StripeResponse<StripeCard> Get(string customerId, string cardId)
		{
			var customerUrl = string.Format(Urls.Cards, customerId);
			var url = string.Format("{0}/{1}", customerUrl, cardId);

            return url.GetResponse<StripeCard>(ApiKey);
		}

        public virtual StripeResponse<StripeCard> Update(string customerId, string cardId, StripeCardUpdateOptions updateOptions)
		{
			var customerUrl = string.Format(Urls.Cards, customerId);
			var url = string.Format("{0}/{1}", customerUrl, cardId);
			url = ParameterBuilder.ApplyAllParameters(updateOptions, url);

            return url.PostResponse<StripeCard>(ApiKey);
		}

		public virtual void Delete(string customerId, string cardId)
		{
			var customerUrl = string.Format(Urls.Cards, customerId);
			var url = string.Format("{0}/{1}", customerUrl, cardId);

		    url.DeleteResponse<StripeCard>(ApiKey);
		}

		public virtual StripeResponse<List<StripeCard>> List(string customerId, StripeListOptions listOptions = null)
		{
			var url = string.Format(Urls.Cards, customerId);
		    if (listOptions != null)
		    {
		        url = ParameterBuilder.ApplyAllParameters(listOptions, url);
		    }

		    return url.GetResponseList<StripeCard>(ApiKey);
		}
	}
}