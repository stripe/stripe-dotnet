using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stripe
{
    public class StripeCustomerService : StripeService
    {
        public StripeCustomerService(string apiKey = null) : base(apiKey) { }

        public bool ExpandDefaultSource { get; set; }

        public virtual StripeCustomer Create(StripeCustomerCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCustomer>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(createOptions, Urls.Customers, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeCustomer Get(string customerId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCustomer>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, $"{Urls.Customers}/{customerId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeCustomer Update(string customerId, StripeCustomerUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCustomer>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(updateOptions, $"{Urls.Customers}/{customerId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual void Delete(string customerId, StripeRequestOptions requestOptions = null)
        {
            Requestor.Delete($"{Urls.Customers}/{customerId}",
                SetupRequestOptions(requestOptions));
        }

        public virtual IEnumerable<StripeCustomer> List(StripeCustomerListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCustomer>.MapCollectionFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, Urls.Customers, true),
                SetupRequestOptions(requestOptions))
            );
        }

#if !PORTABLE
        public virtual async Task<StripeCustomer> CreateAsync(StripeCustomerCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCustomer>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, Urls.Customers, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<StripeCustomer> GetAsync(string customerId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCustomer>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, $"{Urls.Customers}/{customerId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<StripeCustomer> UpdateAsync(string customerId, StripeCustomerUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCustomer>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(updateOptions, $"{Urls.Customers}/{customerId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async void DeleteAsync(string customerId, StripeRequestOptions requestOptions = null)
        {
            await Requestor.DeleteAsync($"{Urls.Customers}/{customerId}",
                SetupRequestOptions(requestOptions));
        }

        public virtual async Task<IEnumerable<StripeCustomer>> ListAsync(StripeCustomerListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCustomer>.MapCollectionFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, Urls.Customers, true),
                SetupRequestOptions(requestOptions))
            );
        }
#endif
    }
}
