// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CreditGrantService : Service<CreditGrant>,
        ICreatable<CreditGrant, CreditGrantCreateOptions>,
        IListable<CreditGrant, CreditGrantListOptions>,
        IRetrievable<CreditGrant, CreditGrantGetOptions>,
        IUpdatable<CreditGrant, CreditGrantUpdateOptions>
    {
        public CreditGrantService()
        {
        }

        public CreditGrantService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/billing/credit_grants";

        /// <summary>
        /// <p>Creates a credit grant</p>.
        /// </summary>
        public virtual CreditGrant Create(CreditGrantCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CreditGrant>(HttpMethod.Post, $"/v1/billing/credit_grants", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a credit grant</p>.
        /// </summary>
        public virtual Task<CreditGrant> CreateAsync(CreditGrantCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditGrant>(HttpMethod.Post, $"/v1/billing/credit_grants", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Expires a credit grant</p>.
        /// </summary>
        public virtual CreditGrant Expire(string id, CreditGrantExpireOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CreditGrant>(HttpMethod.Post, $"/v1/billing/credit_grants/{WebUtility.UrlEncode(id)}/expire", options, requestOptions);
        }

        /// <summary>
        /// <p>Expires a credit grant</p>.
        /// </summary>
        public virtual Task<CreditGrant> ExpireAsync(string id, CreditGrantExpireOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditGrant>(HttpMethod.Post, $"/v1/billing/credit_grants/{WebUtility.UrlEncode(id)}/expire", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a credit grant</p>.
        /// </summary>
        public virtual CreditGrant Get(string id, CreditGrantGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CreditGrant>(HttpMethod.Get, $"/v1/billing/credit_grants/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a credit grant</p>.
        /// </summary>
        public virtual Task<CreditGrant> GetAsync(string id, CreditGrantGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditGrant>(HttpMethod.Get, $"/v1/billing/credit_grants/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a list of credit grants</p>.
        /// </summary>
        public virtual StripeList<CreditGrant> List(CreditGrantListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CreditGrant>>(HttpMethod.Get, $"/v1/billing/credit_grants", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a list of credit grants</p>.
        /// </summary>
        public virtual Task<StripeList<CreditGrant>> ListAsync(CreditGrantListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CreditGrant>>(HttpMethod.Get, $"/v1/billing/credit_grants", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a list of credit grants</p>.
        /// </summary>
        public virtual IEnumerable<CreditGrant> ListAutoPaging(CreditGrantListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CreditGrant>($"/v1/billing/credit_grants", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a list of credit grants</p>.
        /// </summary>
        public virtual IAsyncEnumerable<CreditGrant> ListAutoPagingAsync(CreditGrantListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CreditGrant>($"/v1/billing/credit_grants", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates a credit grant</p>.
        /// </summary>
        public virtual CreditGrant Update(string id, CreditGrantUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CreditGrant>(HttpMethod.Post, $"/v1/billing/credit_grants/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates a credit grant</p>.
        /// </summary>
        public virtual Task<CreditGrant> UpdateAsync(string id, CreditGrantUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditGrant>(HttpMethod.Post, $"/v1/billing/credit_grants/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Voids a credit grant</p>.
        /// </summary>
        public virtual CreditGrant VoidGrant(string id, CreditGrantVoidGrantOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CreditGrant>(HttpMethod.Post, $"/v1/billing/credit_grants/{WebUtility.UrlEncode(id)}/void", options, requestOptions);
        }

        /// <summary>
        /// <p>Voids a credit grant</p>.
        /// </summary>
        public virtual Task<CreditGrant> VoidGrantAsync(string id, CreditGrantVoidGrantOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditGrant>(HttpMethod.Post, $"/v1/billing/credit_grants/{WebUtility.UrlEncode(id)}/void", options, requestOptions, cancellationToken);
        }
    }
}
