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

		public virtual IEnumerable<StripeEvent> List(StripeEventSearchOptions searchOptions = null)
		{
			var url = Urls.Events;
			if (searchOptions != null)
			{
				url = ParameterBuilder.ApplyAllParameters(searchOptions, url);
			}

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeEvent>.MapCollectionFromJson(response);
		}
	}
}