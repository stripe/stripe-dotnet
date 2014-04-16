﻿using System.Collections.Generic;

namespace Stripe
{
	public class StripeRecipientService
	{
		private string ApiKey { get; set; }

		public StripeRecipientService(string apiKey = null)
		{
			ApiKey = apiKey;
		}

		public virtual StripeRecipient Create(StripeRecipientCreateOptions createOptions)
		{
			var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.Recipients);

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeRecipient>.MapFromJson(response);
		}

		public virtual StripeRecipient Get(string recipientId)
		{
			var url = string.Format("{0}/{1}", Urls.Recipients, recipientId);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeRecipient>.MapFromJson(response);
		}

		public virtual StripeRecipient Update(string recipientId, StripeRecipientUpdateOptions updateOptions)
		{
			var url = string.Format("{0}/{1}", Urls.Recipients, recipientId);
			url = ParameterBuilder.ApplyAllParameters(updateOptions, url);

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeRecipient>.MapFromJson(response);
		}

		public virtual void Delete(string recipientId)
		{
			var url = string.Format("{0}/{1}", Urls.Recipients, recipientId);

			Requestor.Delete(url, ApiKey);
		}

		public virtual IEnumerable<StripeRecipient> List(StripeRecipientListOptions options = null)
		{
			var url = Urls.Recipients;
			if (options != null)
			{
				url = ParameterBuilder.ApplyAllParameters(options, url);
			}

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeRecipient>.MapCollectionFromJson(response);
		}
	}
}
