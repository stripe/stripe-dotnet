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

		public virtual StripeResponse<StripeEvent> Get(string eventId)
		{
			var url = string.Format("{0}/{1}", Urls.Events, eventId);

		    return url.GetResponse<StripeEvent>(ApiKey);
		}

		public virtual StripeResponse<List<StripeEvent>> List(StripeEventListOptions listOptions = null)
		{
			var url = Urls.Events;
		    if (listOptions != null)
		    {
		        url = ParameterBuilder.ApplyAllParameters(listOptions, url);
		    }

		    return url.GetResponseList<StripeEvent>(ApiKey);
		}
	}
}