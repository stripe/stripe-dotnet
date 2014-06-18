using System.Collections.Generic;

namespace Stripe
{
	public class StripeCardService : StripeService
	{
		public StripeCardService(string apiKey = null) : base(apiKey) { }

		public bool ExpandCustomer { get; set; }
		public bool ExpandRecipient { get; set; }

		public virtual StripeCard Create(string customerId, StripeCardCreateOptions createOptions)
		{
			var url = string.Format(Urls.Cards, customerId);
			url = this.ApplyAllParameters(createOptions, url, false);

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeCard>.MapFromJson(response);
		}

		public virtual StripeCard Get(string customerId, string cardId)
		{
			var customerUrl = string.Format(Urls.Cards, customerId);
			var url = string.Format("{0}/{1}", customerUrl, cardId);
			url = this.ApplyAllParameters(null, url, false);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeCard>.MapFromJson(response);
		}

		public virtual StripeCard Update(string customerId, string cardId, StripeCardUpdateOptions updateOptions)
		{
			var customerUrl = string.Format(Urls.Cards, customerId);
			var url = string.Format("{0}/{1}", customerUrl, cardId);
			url = this.ApplyAllParameters(updateOptions, url, false);

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeCard>.MapFromJson(response);
		}

		public virtual void Delete(string customerId, string cardId)
		{
			var customerUrl = string.Format(Urls.Cards, customerId);
			var url = string.Format("{0}/{1}", customerUrl, cardId);

			Requestor.Delete(url, ApiKey);
		}

		public virtual IEnumerable<StripeCard> List(string customerId, StripeListOptions listOptions = null)
		{
			var url = string.Format(Urls.Cards, customerId);
			url = this.ApplyAllParameters(listOptions, url, true);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeCard>.MapCollectionFromJson(response);
		}
	}
}