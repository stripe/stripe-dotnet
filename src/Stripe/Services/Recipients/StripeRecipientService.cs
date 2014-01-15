using System.Collections.Generic;
using System.Threading.Tasks;
using Stripe.Services;

namespace Stripe
{
	public class StripeRecipientService : BaseStripeService
	{
		public StripeRecipientService(string apiKey = null) : base(apiKey)
		{
		}

		public virtual async Task<StripeRecipient> Create(StripeRecipientCreateOptions createOptions)
		{
			var data = ParameterBuilder.GenerateFormData(createOptions);

			var response = await Requestor.PostStringAsync(Urls.Recipients, data, ApiKey);

			return Mapper<StripeRecipient>.MapFromJson(response);
		}

		public virtual async Task<StripeRecipient> Get(string recipientId)
		{
			var url = string.Format("{0}/{1}", Urls.Recipients, recipientId);

			var response = await Requestor.GetStringAsync(url, ApiKey);

			return Mapper<StripeRecipient>.MapFromJson(response);
		}

		public virtual async Task<StripeRecipient> Update(string recipientId, StripeRecipientUpdateOptions updateOptions)
		{
			var url = string.Format("{0}/{1}", Urls.Recipients, recipientId);
			var data = ParameterBuilder.GenerateFormData(updateOptions);

			var response = await Requestor.PostStringAsync(url, data, ApiKey);

			return Mapper<StripeRecipient>.MapFromJson(response);
		}

		public virtual async Task Delete(string recipientId)
		{
			var url = string.Format("{0}/{1}", Urls.Recipients, recipientId);

			await Requestor.DeleteAsync(url, ApiKey);
		}

		public virtual async Task<List<StripeRecipient>> List(int count = 10, int offset = 0, bool? verified = null)
		{
            var data = new List<KeyValuePair<string, string>>
		    {
		        new KeyValuePair<string, string>("count", count.ToString()),
		        new KeyValuePair<string, string>("offset", offset.ToString())
		    };
            if (verified.HasValue)
                data.Add(new KeyValuePair<string, string>("verified", verified.ToString()));

			var url = ParameterBuilder.ApplyDataToUrl(Urls.Recipients, data);
            
			var response = await Requestor.GetStringAsync(url, ApiKey);

			return Mapper<StripeRecipient>.MapCollectionFromJson(response);
		}
	}
}
