using System.Collections.Generic;

namespace Stripe
{
    public class StripeCustomerService : StripeService
    {
        public StripeCustomerService(string apiKey = null) : base(apiKey) { }

        public bool ExpandDefaultSource { get; set; }

        public virtual StripeCustomer Create(StripeCustomerCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.Customers, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeCustomer>.MapFromJson(response);
        }

        public virtual StripeCustomer Get(string customerId)
        {
            var url = string.Format("{0}/{1}", Urls.Customers, customerId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeCustomer>.MapFromJson(response);
        }

        public virtual StripeCustomer Update(string customerId, StripeCustomerUpdateOptions updateOptions)
        {
            var url = string.Format("{0}/{1}", Urls.Customers, customerId);
            url = this.ApplyAllParameters(updateOptions, url, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeCustomer>.MapFromJson(response);
        }

        public virtual void Delete(string customerId)
        {
            var url = string.Format("{0}/{1}", Urls.Customers, customerId);

            Requestor.Delete(url, ApiKey);
        }

        public virtual IEnumerable<StripeCustomer> List(StripeCustomerListOptions listOptions = null)
        {
            var url = Urls.Customers;
            url = this.ApplyAllParameters(listOptions, url, true);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeCustomer>.MapCollectionFromJson(response);
        }
    }
}
