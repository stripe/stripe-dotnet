using System.Collections.Generic;

namespace Stripe
{
	public class StripeEventService
	{
		private string ApiKey { get; set; }

		public StripeEventService(string apiKey = null)
		{
			ApiKey = apiKey;
		}

		public virtual StripeEvent Get(string eventId)
		{
			var url = string.Format("{0}/{1}", Urls.Events, eventId);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeEvent>.MapFromJson(response);
		}

		public virtual IEnumerable<StripeEvent> List(int count = 10, int offset = 0, StripeEventSearchOptions searchOptions = null)
		{
			var url = Urls.Events;
			url = ParameterBuilder.ApplyParameterToUrl(url, "count", count.ToString());
			url = ParameterBuilder.ApplyParameterToUrl(url, "offset", offset.ToString());
			url = ParameterBuilder.ApplyAllParameters(searchOptions, url);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeEvent>.MapCollectionFromJson(response);
		}
	}
}