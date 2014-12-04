using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stripe
{
    public class StripeCustomerService : StripeService
    {
        public StripeCustomerService(string apiKey = null) : base(apiKey) { }

        public bool ExpandDefaultCard { get; set; }

        public virtual StripeCustomer Create(StripeCustomerCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.Customers, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeCustomer>.MapFromJson(response);
        }

        public virtual async Task<StripeCustomer> CreateAsync(StripeCustomerCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.Customers, false);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripeCustomer>.MapFromJson(response);
        }

        public virtual StripeCustomer Get(string customerId)
        {
            var url = FormatGetUrl(customerId);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeCustomer>.MapFromJson(response);
        }
        
        public virtual async Task<StripeCustomer> GetAsync(string customerId)
        {
            var url = FormatGetUrl(customerId);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeCustomer>.MapFromJson(response);
        }

        public virtual StripeCustomer Update(string customerId, StripeCustomerUpdateOptions updateOptions)
        {
            var url = FormatUpdateUrl(customerId, updateOptions);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeCustomer>.MapFromJson(response);
        }

        public virtual async Task<StripeCustomer> UpdateAsync(string customerId, StripeCustomerUpdateOptions updateOptions)
        {
            var url = FormatUpdateUrl(customerId, updateOptions);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripeCustomer>.MapFromJson(response);
        }

        public virtual void Delete(string customerId)
        {
            var url = FormatDeleteUrl(customerId);

            Requestor.Delete(url, ApiKey);
        }

        public virtual async Task DeleteAsync(string customerId)
        {
            var url = FormatDeleteUrl(customerId);

            await Requestor.DeleteAsync(url, ApiKey);
        }

        public virtual IEnumerable<StripeCustomer> List(StripeCustomerListOptions listOptions = null)
        {
            var url = FormatListUrl(listOptions);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeCustomer>.MapCollectionFromJson(response);
        }

        public virtual async Task<IEnumerable<StripeCustomer>> ListAsync(StripeCustomerListOptions listOptions = null)
        {
            var url = FormatListUrl(listOptions);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeCustomer>.MapCollectionFromJson(response);
        }

        private string FormatListUrl(StripeCustomerListOptions listOptions)
        {
            var url = Urls.Customers;
            url = this.ApplyAllParameters(listOptions, url, true);
            return url;
        }
        
        private string FormatGetUrl(string customerId)
        {
            var url = string.Format("{0}/{1}", Urls.Customers, customerId);
            this.ApplyAllParameters(null, url, false);
            return url;
        }

        private string FormatUpdateUrl(string customerId, StripeCustomerUpdateOptions updateOptions)
        {
            var url = string.Format("{0}/{1}", Urls.Customers, customerId);
            url = this.ApplyAllParameters(updateOptions, url, false);
            return url;
        }

        private static string FormatDeleteUrl(string customerId)
        {
            var url = string.Format("{0}/{1}", Urls.Customers, customerId);
            return url;
        }
    }
}
