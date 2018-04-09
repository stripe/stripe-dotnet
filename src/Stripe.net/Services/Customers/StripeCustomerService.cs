using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeCustomerService : StripeService
    {
        public StripeCustomerService() : base(null) { }
        public StripeCustomerService(string apiKey) : base(apiKey) { }

        public bool ExpandDefaultSource { get; set; }
        public bool ExpandDefaultCustomerBankAccount { get; set; }



        //Sync
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
                Requestor.GetString(this.ApplyAllParameters(null, $"{Urls.Customers}/{WebUtility.UrlEncode(customerId)}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeCustomer Update(string customerId, StripeCustomerUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCustomer>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(updateOptions, $"{Urls.Customers}/{WebUtility.UrlEncode(customerId)}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeDeleted Delete(string customerId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeDeleted>.MapFromJson(
                Requestor.Delete($"{Urls.Customers}/{WebUtility.UrlEncode(customerId)}",
                SetupRequestOptions(requestOptions))
             );
        }

        public virtual StripeList<StripeCustomer> List(StripeCustomerListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeCustomer>>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, Urls.Customers, true),
                SetupRequestOptions(requestOptions))
            );
        }


        //Async
        public virtual async Task<StripeCustomer> CreateAsync(StripeCustomerCreateOptions createOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCustomer>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, Urls.Customers, false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeCustomer> GetAsync(string customerId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCustomer>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, $"{Urls.Customers}/{WebUtility.UrlEncode(customerId)}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeCustomer> UpdateAsync(string customerId, StripeCustomerUpdateOptions updateOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeCustomer>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(updateOptions, $"{Urls.Customers}/{WebUtility.UrlEncode(customerId)}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeDeleted> DeleteAsync(string customerId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeDeleted>.MapFromJson(
                await Requestor.DeleteAsync($"{Urls.Customers}/{WebUtility.UrlEncode(customerId)}",
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeList<StripeCustomer>> ListAsync(StripeCustomerListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeCustomer>>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, Urls.Customers, true),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }
    }
}
