using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripeEventService
	{
		public StripeEvent Get(string eventId)
		{
			var url = string.Format("{0}/{1}", Urls.Events, eventId);

			var response = Requestor.GetString(url);

			return Mapper<StripeEvent>.MapFromJson(response);
		}

		public IEnumerable<StripeEvent> List(int count = 10, int offset = 0, string type = null, DateTime? created = null, StripeEventSearchOptions createdOptions = null)
		{
			var url = Urls.Events;
			url = ParameterBuilder.ApplyParameterToUrl(url, "count", count.ToString());
			url = ParameterBuilder.ApplyParameterToUrl(url, "offset", offset.ToString());

			if (!string.IsNullOrEmpty(type))
				url = ParameterBuilder.ApplyParameterToUrl(url, "type", type);

			if (created.HasValue)
			{
				string createdString = "0";
				var epochStart = new DateTime(1970, 1, 1);
				if (created.Value >= epochStart)
				{
					createdString = Convert.ToInt64(created.Value.Subtract(epochStart).TotalSeconds).ToString();
				}
				url = ParameterBuilder.ApplyParameterToUrl(url, "created", createdString);
			}
			else if (createdOptions != null)
			{
				throw new NotImplementedException();
				// I'm not sure how to pull this off because the dates need to be converted to stripe timestamp strings
				// We could just pass in strings instead of dates to the StripeEventSearchOptions, but that's not very user friendly.
				//url = ParameterBuilder.ApplyAllParameters(createdOptions, url);
			}


			var response = Requestor.GetString(url);

			return Mapper<StripeEvent>.MapCollectionFromJson(response);
		}
	}
}
