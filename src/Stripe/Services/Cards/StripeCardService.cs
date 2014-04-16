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

		public virtual StripeCard Create(string customerId, StripeCardCreateOptions createOptions)
		{
			var url = string.Format(Urls.Cards, customerId);
			url = ParameterBuilder.ApplyAllParameters(createOptions, url);

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeCard>.MapFromJson(response);
		}

		public virtual StripeCard Get(string customerId, string cardId)
		{
			var customerUrl = string.Format(Urls.Cards, customerId);
			var url = string.Format("{0}/{1}", customerUrl, cardId);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeCard>.MapFromJson(response);
		}

		public virtual StripeCard Update(string customerId, string cardId, StripeCardUpdateOptions updateOptions)
		{
			var customerUrl = string.Format(Urls.Cards, customerId);
			var url = string.Format("{0}/{1}", customerUrl, cardId);
			url = ParameterBuilder.ApplyAllParameters(updateOptions, url);

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeCard>.MapFromJson(response);
		}

		public virtual void Delete(string customerId, string cardId)
		{
			var customerUrl = string.Format(Urls.Cards, customerId);
			var url = string.Format("{0}/{1}", customerUrl, cardId);

			Requestor.Delete(url, ApiKey);
		}

		public virtual IEnumerable<StripeCard> List(string customerId, int limit = 10)
		{
			var url = string.Format(Urls.Cards, customerId);
			url = ParameterBuilder.ApplyParameterToUrl(url, "limit", limit.ToString());

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeCard>.MapCollectionFromJson(response);
		}
	}
}