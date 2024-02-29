// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TransferService : Service<Transfer>,
        ICreatable<Transfer, TransferCreateOptions>,
        IListable<Transfer, TransferListOptions>,
        IRetrievable<Transfer, TransferGetOptions>,
        IUpdatable<Transfer, TransferUpdateOptions>
    {
        public TransferService()
            : base(null)
        {
        }

        public TransferService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/transfers";

        public virtual Transfer Create(TransferCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Transfer>(HttpMethod.Post, $"/v1/transfers", options, requestOptions);
        }

        public virtual Task<Transfer> CreateAsync(TransferCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Transfer>(HttpMethod.Post, $"/v1/transfers", options, requestOptions, cancellationToken);
        }

        public virtual Transfer Get(string id, TransferGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Transfer>(HttpMethod.Get, $"/v1/transfers/{id}", options, requestOptions);
        }

        public virtual Task<Transfer> GetAsync(string id, TransferGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Transfer>(HttpMethod.Get, $"/v1/transfers/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Transfer> List(TransferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Transfer>>(HttpMethod.Get, $"/v1/transfers", options, requestOptions);
        }

        public virtual Task<StripeList<Transfer>> ListAsync(TransferListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Transfer>>(HttpMethod.Get, $"/v1/transfers", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Transfer> ListAutoPaging(TransferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Transfer>($"/v1/transfers", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Transfer> ListAutoPagingAsync(TransferListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Transfer>($"/v1/transfers", options, requestOptions, cancellationToken);
        }

        public virtual Transfer Update(string id, TransferUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Transfer>(HttpMethod.Post, $"/v1/transfers/{id}", options, requestOptions);
        }

        public virtual Task<Transfer> UpdateAsync(string id, TransferUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Transfer>(HttpMethod.Post, $"/v1/transfers/{id}", options, requestOptions, cancellationToken);
        }
    }
}
