// File generated from our OpenAPI spec
namespace Stripe.Climate
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SupplierService : Service<Supplier>,
        IListable<Supplier, SupplierListOptions>,
        IRetrievable<Supplier, SupplierGetOptions>
    {
        public SupplierService()
        {
        }

        public SupplierService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/climate/suppliers";

        /// <summary>
        /// <p>Retrieves a Climate supplier object.</p>.
        /// </summary>
        public virtual Supplier Get(string id, SupplierGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Supplier>(HttpMethod.Get, $"/v1/climate/suppliers/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a Climate supplier object.</p>.
        /// </summary>
        public virtual Task<Supplier> GetAsync(string id, SupplierGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Supplier>(HttpMethod.Get, $"/v1/climate/suppliers/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists all available Climate supplier objects.</p>.
        /// </summary>
        public virtual StripeList<Supplier> List(SupplierListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Supplier>>(HttpMethod.Get, $"/v1/climate/suppliers", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists all available Climate supplier objects.</p>.
        /// </summary>
        public virtual Task<StripeList<Supplier>> ListAsync(SupplierListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Supplier>>(HttpMethod.Get, $"/v1/climate/suppliers", options, requestOptions, cancellationToken);
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
