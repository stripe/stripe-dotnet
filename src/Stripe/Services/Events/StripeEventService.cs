using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Stripe.Services;

namespace Stripe
{
	public class StripeEventService : BaseStripeService
	{
		public StripeEventService(string apiKey = null) : base(apiKey)
		{
		}

		public virtual async Task<StripeEvent> Get(string eventId)
		{
			var url = string.Format("{0}/{1}", Urls.Events, eventId);

			var response = await Requestor.GetStringAsync(url, ApiKey);

			return Mapper<StripeEvent>.MapFromJson(response);
		}

		public virtual async Task<IEnumerable<StripeEvent>> List(int count = 10, int offset = 0, StripeEventSearchOptions searchOptions = null)
		{
			var url = Urls.Events;

            IEnumerable<KeyValuePair<string,string>> data = new List<KeyValuePair<string,string>>
            {
                new KeyValuePair<string,string>("count", count.ToString()),
                new KeyValuePair<string,string>("offset", offset.ToString())
            };

			data = data.Union(ParameterBuilder.GenerateFormData(searchOptions).ToList()).Where(x => !string.IsNullOrEmpty(x.Value));
            url = ParameterBuilder.ApplyDataToUrl(url, data);

			var response = await Requestor.GetStringAsync(url, ApiKey);

			return Mapper<StripeEvent>.MapCollectionFromJson(response);
		}
	}
}