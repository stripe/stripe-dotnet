using System.Collections.Generic;

namespace Stripe
{
	public class StripeRecipientService
	{
		private string ApiKey { get; set; }

		public StripeRecipientService(string apiKey = null)
		{
			ApiKey = apiKey;
		}

		public virtual StripeResponse<StripeRecipient> Create(StripeRecipientCreateOptions createOptions)
		{
			var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.Recipients);

		    return url.PostResponse<StripeRecipient>(ApiKey);
		}

        public virtual StripeResponse<StripeRecipient> Get(string recipientId)
		{
			var url = string.Format("{0}/{1}", Urls.Recipients, recipientId);

            return url.GetResponse<StripeRecipient>(ApiKey);
		}

        public virtual StripeResponse<StripeRecipient> Update(string recipientId, StripeRecipientUpdateOptions updateOptions)
		{
			var url = string.Format("{0}/{1}", Urls.Recipients, recipientId);
			url = ParameterBuilder.ApplyAllParameters(updateOptions, url);

            return url.PostResponse<StripeRecipient>(ApiKey);
		}

		public virtual void Delete(string recipientId)
		{
			var url = string.Format("{0}/{1}", Urls.Recipients, recipientId);

		    url.DeleteResponse<StripeRecipient>(ApiKey);
		}

	    public virtual StripeResponse<List<StripeRecipient>> List(StripeRecipientListOptions listOptions = null)
	    {
	        var url = Urls.Recipients;
	        if (listOptions != null)
	        {
	            url = ParameterBuilder.ApplyAllParameters(listOptions, url);
	        }

	        return url.GetResponseList<StripeRecipient>(ApiKey);
	    }
	}
}
