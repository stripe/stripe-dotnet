using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeApplePayDomainService : StripeBasicService<StripeApplePayDomain>
    {
        public StripeApplePayDomainService() : base(null) { }
        public StripeApplePayDomainService(string apiKey) : base(apiKey) { }



        // Sync
        public virtual StripeApplePayDomain Create(StripeApplePayDomainCreateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/apple_pay/domains", requestOptions, options);
        }

        public virtual StripeApplePayDomain Get(string domainId, StripeRequestOptions requestOptions = null)
        {
            return GetEntity($"{Urls.BaseUrl}/apple_pay/domains/{domainId}", requestOptions);
        }

        public virtual StripeList<StripeApplePayDomain> List(StripeApplePayDomainListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return GetEntityList($"{Urls.BaseUrl}/apple_pay/domains", requestOptions, listOptions);
        }

        public virtual StripeDeleted Delete(string domainId, StripeRequestOptions requestOptions = null)
        {
            return DeleteEntity($"{Urls.BaseUrl}/apple_pay/domains/{domainId}", requestOptions);
        }



        // Async
        public virtual Task<StripeApplePayDomain> CreateAsync(StripeApplePayDomainCreateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/apple_pay/domains", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeApplePayDomain> GetAsync(string domainId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityAsync($"{Urls.BaseUrl}/apple_pay/domains/{domainId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<StripeApplePayDomain>> ListAsync(StripeApplePayDomainListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityListAsync($"{Urls.BaseUrl}/apple_pay/domains", requestOptions, cancellationToken, listOptions);
        }

        public virtual Task<StripeDeleted> DeleteAsync(string domainId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteEntityAsync($"{Urls.BaseUrl}/apple_pay/domains/{domainId}", requestOptions, cancellationToken);
        }
    }
}
