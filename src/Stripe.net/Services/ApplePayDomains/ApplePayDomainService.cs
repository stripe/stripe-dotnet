// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ApplePayDomainService : Service<ApplePayDomain>,
        ICreatable<ApplePayDomain, ApplePayDomainCreateOptions>,
        IDeletable<ApplePayDomain, ApplePayDomainDeleteOptions>,
        IListable<ApplePayDomain, ApplePayDomainListOptions>,
        IRetrievable<ApplePayDomain, ApplePayDomainGetOptions>
    {
        public ApplePayDomainService()
        {
        }

        public ApplePayDomainService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/apple_pay/domains";

        /// <summary>
        /// <p>Create an apple pay domain.</p>.
        /// </summary>
        public virtual ApplePayDomain Create(ApplePayDomainCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ApplePayDomain>(HttpMethod.Post, $"/v1/apple_pay/domains", options, requestOptions);
        }

        /// <summary>
        /// <p>Create an apple pay domain.</p>.
        /// </summary>
        public virtual Task<ApplePayDomain> CreateAsync(ApplePayDomainCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ApplePayDomain>(HttpMethod.Post, $"/v1/apple_pay/domains", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Delete an apple pay domain.</p>.
        /// </summary>
        public virtual ApplePayDomain Delete(string id, ApplePayDomainDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ApplePayDomain>(HttpMethod.Delete, $"/v1/apple_pay/domains/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Delete an apple pay domain.</p>.
        /// </summary>
        public virtual Task<ApplePayDomain> DeleteAsync(string id, ApplePayDomainDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ApplePayDomain>(HttpMethod.Delete, $"/v1/apple_pay/domains/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve an apple pay domain.</p>.
        /// </summary>
        public virtual ApplePayDomain Get(string id, ApplePayDomainGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ApplePayDomain>(HttpMethod.Get, $"/v1/apple_pay/domains/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve an apple pay domain.</p>.
        /// </summary>
        public virtual Task<ApplePayDomain> GetAsync(string id, ApplePayDomainGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ApplePayDomain>(HttpMethod.Get, $"/v1/apple_pay/domains/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List apple pay domains.</p>.
        /// </summary>
        public virtual StripeList<ApplePayDomain> List(ApplePayDomainListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<ApplePayDomain>>(HttpMethod.Get, $"/v1/apple_pay/domains", options, requestOptions);
        }

        /// <summary>
        /// <p>List apple pay domains.</p>.
        /// </summary>
        public virtual Task<StripeList<ApplePayDomain>> ListAsync(ApplePayDomainListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<ApplePayDomain>>(HttpMethod.Get, $"/v1/apple_pay/domains", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List apple pay domains.</p>.
        /// </summary>
        public virtual IEnumerable<ApplePayDomain> ListAutoPaging(ApplePayDomainListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ApplePayDomain>($"/v1/apple_pay/domains", options, requestOptions);
        }

        /// <summary>
        /// <p>List apple pay domains.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<ApplePayDomain> ListAutoPagingAsync(ApplePayDomainListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ApplePayDomain>($"/v1/apple_pay/domains", options, requestOptions, cancellationToken);
        }
    }
}
