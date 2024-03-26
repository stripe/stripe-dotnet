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
        {
        }

        public TransferService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/transfers";

        /// <summary>
        /// <p>To send funds from your Stripe account to a connected account, you create a new
        /// transfer object. Your <a href="https://stripe.com/docs/api#balance">Stripe balance</a>
        /// must be able to cover the transfer amount, or you’ll receive an “Insufficient Funds”
        /// error.</p>.
        /// </summary>
        public virtual Transfer Create(TransferCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Transfer>(HttpMethod.Post, $"/v1/transfers", options, requestOptions);
        }

        /// <summary>
        /// <p>To send funds from your Stripe account to a connected account, you create a new
        /// transfer object. Your <a href="https://stripe.com/docs/api#balance">Stripe balance</a>
        /// must be able to cover the transfer amount, or you’ll receive an “Insufficient Funds”
        /// error.</p>.
        /// </summary>
        public virtual Task<Transfer> CreateAsync(TransferCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Transfer>(HttpMethod.Post, $"/v1/transfers", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing transfer. Supply the unique transfer ID from
        /// either a transfer creation request or the transfer list, and Stripe will return the
        /// corresponding transfer information.</p>.
        /// </summary>
        public virtual Transfer Get(string id, TransferGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Transfer>(HttpMethod.Get, $"/v1/transfers/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing transfer. Supply the unique transfer ID from
        /// either a transfer creation request or the transfer list, and Stripe will return the
        /// corresponding transfer information.</p>.
        /// </summary>
        public virtual Task<Transfer> GetAsync(string id, TransferGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Transfer>(HttpMethod.Get, $"/v1/transfers/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of existing transfers sent to connected accounts. The transfers are
        /// returned in sorted order, with the most recently created transfers appearing first.</p>.
        /// </summary>
        public virtual StripeList<Transfer> List(TransferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Transfer>>(HttpMethod.Get, $"/v1/transfers", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of existing transfers sent to connected accounts. The transfers are
        /// returned in sorted order, with the most recently created transfers appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<Transfer>> ListAsync(TransferListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Transfer>>(HttpMethod.Get, $"/v1/transfers", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of existing transfers sent to connected accounts. The transfers are
        /// returned in sorted order, with the most recently created transfers appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<Transfer> ListAutoPaging(TransferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Transfer>($"/v1/transfers", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of existing transfers sent to connected accounts. The transfers are
        /// returned in sorted order, with the most recently created transfers appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Transfer> ListAutoPagingAsync(TransferListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Transfer>($"/v1/transfers", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the specified transfer by setting the values of the parameters passed. Any
        /// parameters not provided will be left unchanged.</p>.
        ///
        /// <p>This request accepts only metadata as an argument.</p>.
        /// </summary>
        public virtual Transfer Update(string id, TransferUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Transfer>(HttpMethod.Post, $"/v1/transfers/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the specified transfer by setting the values of the parameters passed. Any
        /// parameters not provided will be left unchanged.</p>.
        ///
        /// <p>This request accepts only metadata as an argument.</p>.
        /// </summary>
        public virtual Task<Transfer> UpdateAsync(string id, TransferUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Transfer>(HttpMethod.Post, $"/v1/transfers/{id}", options, requestOptions, cancellationToken);
        }
    }
}
