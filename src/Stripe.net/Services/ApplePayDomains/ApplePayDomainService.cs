namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class ApplePayDomainService : Service<ApplePayDomain>,
        ICreatable<ApplePayDomain, ApplePayDomainCreateOptions>,
        IDeletable<ApplePayDomain>,
        IListable<ApplePayDomain, ApplePayDomainListOptions>,
        IRetrievable<ApplePayDomain, ApplePayDomainGetOptions>
    {
        public ApplePayDomainService()
            : base(null)
        {
        }

        public ApplePayDomainService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/apple_pay/domains";

        public virtual ApplePayDomain Create(ApplePayDomainCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<ApplePayDomain> CreateAsync(ApplePayDomainCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual ApplePayDomain Delete(string domainId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(domainId, null, requestOptions);
        }

        public virtual Task<ApplePayDomain> DeleteAsync(string domainId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync(domainId, null, requestOptions, cancellationToken);
        }

        public virtual ApplePayDomain Get(string domainId, ApplePayDomainGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(domainId, options, requestOptions);
        }

        public virtual Task<ApplePayDomain> GetAsync(string domainId, ApplePayDomainGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(domainId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<ApplePayDomain> List(ApplePayDomainListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<ApplePayDomain>> ListAsync(ApplePayDomainListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<ApplePayDomain> ListAutoPaging(ApplePayDomainListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }
    }
}
