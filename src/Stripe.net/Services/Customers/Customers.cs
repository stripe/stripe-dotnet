using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class CustomerService2: StripeBasicService<StripeCustomer>
    {
        public CustomerService2(string apiKey = null) : base(apiKey) { }

        public bool ExpandDefaultSource { get; set; }
        public bool ExpandDefaultCustomerBankAccount { get; set; }

        public virtual Task<StripeCustomer> Create(StripeCustomerCreateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/customers", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeCustomer> Get(string customerId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityAsync($"{Urls.BaseUrl}/customers/{customerId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeCustomer> Update(string customerId, StripeCustomerUpdateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/customers/{customerId}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeDeleted> Delete(string customerId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteEntityAsync($"{Urls.BaseUrl}/customers/{customerId}", requestOptions, cancellationToken);
        }

        public virtual Task<IEnumerable<StripeCustomer>> List(StripeCustomerListOptions options = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityListAsync($"{Urls.BaseUrl}/customers", requestOptions, cancellationToken, options);
        }
    }
}
