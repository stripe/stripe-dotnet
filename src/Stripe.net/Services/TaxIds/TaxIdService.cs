// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class TaxIdService : Service<TaxId>,
        ICreatable<TaxId, TaxIdCreateOptions>,
        IDeletable<TaxId, TaxIdDeleteOptions>,
        IListable<TaxId, TaxIdListOptions>,
        IRetrievable<TaxId, TaxIdGetOptions>
    {
        public TaxIdService()
        {
        }

        internal TaxIdService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public TaxIdService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a new account or customer <c>tax_id</c> object.</p>.
        /// </summary>
        public virtual TaxId Create(TaxIdCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<TaxId>(BaseAddress.Api, HttpMethod.Post, $"/v1/tax_ids", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new account or customer <c>tax_id</c> object.</p>.
        /// </summary>
        public virtual Task<TaxId> CreateAsync(TaxIdCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TaxId>(BaseAddress.Api, HttpMethod.Post, $"/v1/tax_ids", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Deletes an existing account or customer <c>tax_id</c> object.</p>.
        /// </summary>
        public virtual TaxId Delete(string id, TaxIdDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TaxId>(BaseAddress.Api, HttpMethod.Delete, $"/v1/tax_ids/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Deletes an existing account or customer <c>tax_id</c> object.</p>.
        /// </summary>
        public virtual Task<TaxId> DeleteAsync(string id, TaxIdDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TaxId>(BaseAddress.Api, HttpMethod.Delete, $"/v1/tax_ids/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves an account or customer <c>tax_id</c> object.</p>.
        /// </summary>
        public virtual TaxId Get(string id, TaxIdGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TaxId>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax_ids/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves an account or customer <c>tax_id</c> object.</p>.
        /// </summary>
        public virtual Task<TaxId> GetAsync(string id, TaxIdGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TaxId>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax_ids/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of tax IDs.</p>.
        /// </summary>
        public virtual StripeList<TaxId> List(TaxIdListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<TaxId>>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax_ids", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of tax IDs.</p>.
        /// </summary>
        public virtual Task<StripeList<TaxId>> ListAsync(TaxIdListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<TaxId>>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax_ids", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of tax IDs.</p>.
        /// </summary>
        public virtual IEnumerable<TaxId> ListAutoPaging(TaxIdListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<TaxId>($"/v1/tax_ids", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of tax IDs.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<TaxId> ListAutoPagingAsync(TaxIdListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<TaxId>($"/v1/tax_ids", options, requestOptions, cancellationToken);
        }
    }
}
