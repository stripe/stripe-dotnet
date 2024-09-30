namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class TaxIdService
    {
        /// <summary>
        /// <p>Creates a new <c>tax_id</c> object for a customer.</p>.
        /// </summary>
        [Obsolete("Use CustomerTaxIdService.Create instead.")]
        public virtual TaxId Create(string parentId, TaxIdCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TaxId>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{parentId}/tax_ids", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new <c>tax_id</c> object for a customer.</p>.
        /// </summary>
        [Obsolete("Use CustomerTaxIdService.CreateAsync instead.")]
        public virtual Task<TaxId> CreateAsync(string parentId, TaxIdCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TaxId>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{parentId}/tax_ids", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Deletes an existing <c>tax_id</c> object.</p>.
        /// </summary>
        [Obsolete("Use CustomerTaxIdService.Delete instead.")]
        public virtual TaxId Delete(string parentId, string id, TaxIdDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TaxId>(BaseAddress.Api, HttpMethod.Delete, $"/v1/customers/{parentId}/tax_ids/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Deletes an existing <c>tax_id</c> object.</p>.
        /// </summary>
        [Obsolete("Use CustomerTaxIdService.DeleteAsync instead.")]
        public virtual Task<TaxId> DeleteAsync(string parentId, string id, TaxIdDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TaxId>(BaseAddress.Api, HttpMethod.Delete, $"/v1/customers/{parentId}/tax_ids/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the <c>tax_id</c> object with the given identifier.</p>.
        /// </summary>
        [Obsolete("Use CustomerTaxIdService.Get instead.")]
        public virtual TaxId Get(string parentId, string id, TaxIdGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TaxId>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{parentId}/tax_ids/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the <c>tax_id</c> object with the given identifier.</p>.
        /// </summary>
        [Obsolete("Use CustomerTaxIdService.GetAsync instead.")]
        public virtual Task<TaxId> GetAsync(string parentId, string id, TaxIdGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TaxId>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{parentId}/tax_ids/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of tax IDs for a customer.</p>.
        /// </summary>
        [Obsolete("Use CustomerTaxIdService.List instead.")]
        public virtual StripeList<TaxId> List(string parentId, TaxIdListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<TaxId>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{parentId}/tax_ids", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of tax IDs for a customer.</p>.
        /// </summary>
        [Obsolete("Use CustomerTaxIdService.ListAsync instead.")]
        public virtual Task<StripeList<TaxId>> ListAsync(string parentId, TaxIdListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<TaxId>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{parentId}/tax_ids", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of tax IDs for a customer.</p>.
        /// </summary>
        [Obsolete("Use CustomerTaxIdService.ListAutoPaging instead.")]
        public virtual IEnumerable<TaxId> ListAutoPaging(string parentId, TaxIdListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<TaxId>($"/v1/customers/{parentId}/tax_ids", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of tax IDs for a customer.</p>.
        /// </summary>
        [Obsolete("Use CustomerTaxIdService.ListAutoPagingAsync instead.")]
        public virtual IAsyncEnumerable<TaxId> ListAutoPagingAsync(string parentId, TaxIdListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<TaxId>($"/v1/customers/{parentId}/tax_ids", options, requestOptions, cancellationToken);
        }
    }
}
