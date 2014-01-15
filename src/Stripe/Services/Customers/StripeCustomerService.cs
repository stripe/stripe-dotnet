using System.Collections.Generic;
using System.Threading.Tasks;
using Stripe.Services;

namespace Stripe
{
	public class StripeCustomerService : BaseStripeService
	{
		public StripeCustomerService(string apiKey = null) : base(apiKey)
		{
		}

		public virtual async Task<StripeCustomer> Create(StripeCustomerCreateOptions createOptions)
		{
			var data = ParameterBuilder.GenerateFormData(createOptions);

			var response = await Requestor.PostStringAsync(Urls.Customers, data, ApiKey);

			return Mapper<StripeCustomer>.MapFromJson(response);
		}

		public virtual async Task<StripeCustomer> Get(string customerId)
		{
			var url = string.Format("{0}/{1}", Urls.Customers, customerId);

			var response = await Requestor.GetStringAsync(url, ApiKey);

			return Mapper<StripeCustomer>.MapFromJson(response);
		}

		public virtual async Task<StripeCustomer> Update(string customerId, StripeCustomerUpdateOptions updateOptions)
		{
			var url = string.Format("{0}/{1}", Urls.Customers, customerId);
			var data = ParameterBuilder.GenerateFormData(updateOptions);

			var response = await Requestor.PostStringAsync(url, data, ApiKey);

			return Mapper<StripeCustomer>.MapFromJson(response);
		}

		public virtual async Task Delete(string customerId)
		{
			var url = string.Format("{0}/{1}", Urls.Customers, customerId);

			await Requestor.DeleteAsync(url, ApiKey);
		}

	    public virtual async Task<List<StripeCustomer>> List(int count = 10, int offset = 0)
		{
            var url = ParameterBuilder.ApplyDataToUrl(Urls.Customers, new List<KeyValuePair<string, string>>
		    {
		        new KeyValuePair<string, string>("count", count.ToString()),
		        new KeyValuePair<string, string>("offset", offset.ToString())
		    });

			var response = await Requestor.GetStringAsync(url, ApiKey);

			return Mapper<StripeCustomer>.MapCollectionFromJson(response);
		}

		public virtual async Task<StripeSubscription> UpdateSubscription(string customerId, StripeCustomerUpdateSubscriptionOptions updateOptions)
		{
			var url = string.Format("{0}/{1}/subscription", Urls.Customers, customerId);
			var data = ParameterBuilder.GenerateFormData(updateOptions);

			var response = await Requestor.PostStringAsync(url, data, ApiKey);

			return Mapper<StripeSubscription>.MapFromJson(response);
		}

		public virtual async Task<StripeSubscription> CancelSubscription(string customerId, bool cancelAtPeriodEnd = false)
		{
			var url = string.Format("{0}/{1}/subscription", Urls.Customers, customerId);
			url = ParameterBuilder.ApplyDataToUrl(url, new List<KeyValuePair<string,string>>{new KeyValuePair<string, string>("at_period_end", cancelAtPeriodEnd.ToString())});

			var response = await Requestor.DeleteAsync(url, ApiKey);

			return Mapper<StripeSubscription>.MapFromJson(response);
		}
	}
}