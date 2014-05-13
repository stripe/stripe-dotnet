using System.Collections.Generic;

namespace Stripe
{
	public class StripeCustomerService
	{
		private string ApiKey { get; set; }

		public StripeCustomerService(string apiKey = null)
		{
			ApiKey = apiKey;
		}

		public virtual StripeResponse<StripeCustomer> Create(StripeCustomerCreateOptions createOptions)
		{
			var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.Customers);
		    return url.PostResponse<StripeCustomer>(ApiKey);
		}

		public virtual StripeResponse<StripeCustomer> Get(string customerId)
		{
			var url = string.Format("{0}/{1}", Urls.Customers, customerId);

		    return url.GetResponse<StripeCustomer>(ApiKey);
		}

		public virtual StripeResponse<StripeCustomer> Update(string customerId, StripeCustomerUpdateOptions updateOptions)
		{
			var url = string.Format("{0}/{1}", Urls.Customers, customerId);
			url = ParameterBuilder.ApplyAllParameters(updateOptions, url);

		    return url.PostResponse<StripeCustomer>(ApiKey);
		}

		public virtual void Delete(string customerId)
		{
			var url = string.Format("{0}/{1}", Urls.Customers, customerId);
            url.DeleteResponse<StripeCustomer>(ApiKey);
		}

		public virtual StripeResponse<List<StripeCustomer>> List(StripeCustomerListOptions listOptions = null)
		{
			var url = Urls.Customers;
		    if (listOptions != null)
		    {
		        url = ParameterBuilder.ApplyAllParameters(listOptions, url);
		    }
            return url.GetResponseList<StripeCustomer>(ApiKey);
		}

		public virtual StripeResponse<StripeSubscription> UpdateSubscription(string customerId, StripeCustomerUpdateSubscriptionOptions updateOptions)
		{
			var url = string.Format("{0}/{1}/subscription", Urls.Customers, customerId);
			url = ParameterBuilder.ApplyAllParameters(updateOptions, url);

		    return url.PostResponse<StripeSubscription>(ApiKey);
		}

		public virtual StripeResponse<StripeSubscription> CancelSubscription(string customerId, bool cancelAtPeriodEnd = false)
		{
			var url = string.Format("{0}/{1}/subscription", Urls.Customers, customerId);
			url = ParameterBuilder.ApplyParameterToUrl(url, "at_period_end", cancelAtPeriodEnd.ToString());

            return url.DeleteResponse<StripeSubscription>(ApiKey);
		}
	}
}