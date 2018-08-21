namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ApplePayDomainService : BasicService<StripeApplePayDomain>
    {
        public ApplePayDomainService()
            : base(null)
        {
        }

        public ApplePayDomainService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual StripeApplePayDomain Create(ApplePayDomainCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/apple_pay/domains", requestOptions, options);
        }

        public virtual StripeApplePayDomain Get(string domainId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/apple_pay/domains/{domainId}", requestOptions);
        }

        public virtual StripeList<StripeApplePayDomain> List(ApplePayDomainListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/apple_pay/domains", requestOptions, listOptions);
        }

        public virtual StripeApplePayDomain Delete(string domainId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.BaseUrl}/apple_pay/domains/{domainId}", requestOptions);
        }

        public virtual Task<StripeApplePayDomain> CreateAsync(ApplePayDomainCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/apple_pay/domains", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeApplePayDomain> GetAsync(string domainId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/apple_pay/domains/{domainId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<StripeApplePayDomain>> ListAsync(ApplePayDomainListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/apple_pay/domains", requestOptions, cancellationToken, listOptions);
        }

        public virtual Task<StripeApplePayDomain> DeleteAsync(string domainId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.BaseUrl}/apple_pay/domains/{domainId}", requestOptions, cancellationToken);
        }
    }
}
