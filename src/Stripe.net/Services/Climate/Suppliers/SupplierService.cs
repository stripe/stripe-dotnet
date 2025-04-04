// File generated from our OpenAPI spec
namespace Stripe.Climate
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SupplierService : Service,
        IListable<Supplier, SupplierListOptions>,
        IRetrievable<Supplier, SupplierGetOptions>
    {
        public SupplierService()
        {
        }

        internal SupplierService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public SupplierService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves a Climate supplier object.</p>.
        /// </summary>
        public virtual Supplier Get(string id, SupplierGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Supplier>(BaseAddress.Api, HttpMethod.Get, $"/v1/climate/suppliers/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a Climate supplier object.</p>.
        /// </summary>
        public virtual Task<Supplier> GetAsync(string id, SupplierGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Supplier>(BaseAddress.Api, HttpMethod.Get, $"/v1/climate/suppliers/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists all available Climate supplier objects.</p>.
        /// </summary>
        public virtual StripeList<Supplier> List(SupplierListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Supplier>>(BaseAddress.Api, HttpMethod.Get, $"/v1/climate/suppliers", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists all available Climate supplier objects.</p>.
        /// </summary>
        public virtual Task<StripeList<Supplier>> ListAsync(SupplierListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Supplier>>(BaseAddress.Api, HttpMethod.Get, $"/v1/climate/suppliers", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists all available Climate supplier objects.</p>.
        /// </summary>
        public virtual IEnumerable<Supplier> ListAutoPaging(SupplierListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Supplier>($"/v1/climate/suppliers", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists all available Climate supplier objects.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Supplier> ListAutoPagingAsync(SupplierListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Supplier>($"/v1/climate/suppliers", options, requestOptions, cancellationToken);
        }
    }
}
