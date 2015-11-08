using System.Collections.Generic;

namespace Stripe
{
    public class StripeManagedAccountService : StripeService
    {
        public StripeManagedAccountService(string apiKey = null) : base(apiKey) { }

        public bool ExpandDefaultSource { get; set; }

        public virtual StripeManagedAccount Create(StripeManagedAccountCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = this.ApplyAllParameters(createOptions, Urls.Customers, false);

            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripeManagedAccount>.MapFromJson(response);
        }

        public virtual StripeManagedAccount Get(string accountId, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}", Urls.Accounts, accountId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeManagedAccount>.MapFromJson(response);
        }

        public virtual StripeManagedAccount Update(string accountId, StripeManagedAccountUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}", Urls.Accounts, accountId);
            url = this.ApplyAllParameters(updateOptions, url, false);

            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripeManagedAccount>.MapFromJson(response);
        }

        public virtual void Delete(string accountId, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}", Urls.Accounts, accountId);

            Requestor.Delete(url, requestOptions);
        }

        public virtual IEnumerable<StripeManagedAccount> List(StripeManagedAccountListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = Urls.Customers;
            url = this.ApplyAllParameters(listOptions, url, true);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeManagedAccount>.MapCollectionFromJson(response);
        }
    }
}
