namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class StripeApplePayDomainService : StripeBasicService<StripeApplePayDomain>
    {
        public StripeApplePayDomainService()
            : base(null)
        {
        }

        public StripeApplePayDomainService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual StripeApplePayDomain Create(StripeApplePayDomainCreateOptions options, StripeRequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/apple_pay/domains", requestOptions, options);
        }

        public virtual StripeApplePayDomain Get(string domainId, StripeRequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/apple_pay/domains/{domainId}", requestOptions);
        }

        public virtual StripeList<StripeApplePayDomain> List(StripeApplePayDomainListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/apple_pay/domains", requestOptions, listOptions);
        }

        public virtual StripeApplePayDomain Delete(string domainId, StripeRequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.BaseUrl}/apple_pay/domains/{domainId}", requestOptions);
        }

        public virtual Task<StripeApplePayDomain> CreateAsync(StripeApplePayDomainCreateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/apple_pay/domains", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeApplePayDomain> GetAsync(string domainId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/apple_pay/domains/{domainId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<StripeApplePayDomain>> ListAsync(StripeApplePayDomainListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/apple_pay/domains", requestOptions, cancellationToken, listOptions);
        }

        public virtual Task<StripeApplePayDomain> DeleteAsync(string domainId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.BaseUrl}/apple_pay/domains/{domainId}", requestOptions, cancellationToken);
        }
    }
}
