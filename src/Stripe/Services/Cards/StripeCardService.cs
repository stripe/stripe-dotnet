using System.Collections.Generic;
using System.Threading.Tasks;
using Stripe.Services;

namespace Stripe
{
	public class StripeCardService : BaseStripeService
	{
		public StripeCardService(string apiKey = null):base(apiKey)
		{
		}

		public virtual async Task<StripeCard> Create(string customerId, StripeCardCreateOptions createOptions)
		{
		    var url = string.Format(Urls.Cards, customerId);
			var data = ParameterBuilder.GenerateFormData(createOptions);

			var response = await Requestor.PostStringAsync(url, data, ApiKey);

			return Mapper<StripeCard>.MapFromJson(response);
		}

		public virtual async Task<StripeCard> Get(string customerId, string cardId)
		{
			var customerUrl = string.Format(Urls.Cards, customerId);
			var url = string.Format("{0}/{1}", customerUrl, cardId);

			var response = await Requestor.GetStringAsync(url, ApiKey);

			return Mapper<StripeCard>.MapFromJson(response);
		}

		public virtual async Task<StripeCard> Update(string customerId, string cardId, StripeCardUpdateOptions updateOptions)
		{
			var customerUrl = string.Format(Urls.Cards, customerId);
			var url = string.Format("{0}/{1}", customerUrl, cardId);
			var data = ParameterBuilder.GenerateFormData(updateOptions);

			var response = await Requestor.PostStringAsync(url, data, ApiKey);

			return Mapper<StripeCard>.MapFromJson(response);
		}

		public virtual async Task Delete(string customerId, string cardId)
		{
			var customerUrl = string.Format(Urls.Cards, customerId);
			var url = string.Format("{0}/{1}", customerUrl, cardId);

			await Requestor.DeleteAsync(url, ApiKey);
		}

		public virtual async Task<IEnumerable<StripeCard>> List(string customerId, int count = 10, int offset = 0)
		{
			var url = string.Format(Urls.Cards, customerId);
		    url = ParameterBuilder.ApplyDataToUrl(url, new List<KeyValuePair<string, string>>
		    {
		        new KeyValuePair<string, string>("count", count.ToString()),
		        new KeyValuePair<string, string>("offset", offset.ToString())
		    });

			var response = await Requestor.GetStringAsync(url, ApiKey);

			return Mapper<StripeCard>.MapCollectionFromJson(response);
		}
	}
}