// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class FeeBatchService : Service
    {
        internal FeeBatchService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal FeeBatchService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieve a FeeBatch by id.
        /// </summary>
        public virtual FeeBatch Get(string id, FeeBatchGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FeeBatch>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/fee_batches/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a FeeBatch by id.
        /// </summary>
        public virtual Task<FeeBatch> GetAsync(string id, FeeBatchGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FeeBatch>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/fee_batches/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List FeeBatches optionally filtered by collection_record.
        /// </summary>
        public virtual V2.StripeList<FeeBatch> List(FeeBatchListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<FeeBatch>>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/fee_batches", options, requestOptions);
        }

        /// <summary>
        /// List FeeBatches optionally filtered by collection_record.
        /// </summary>
        public virtual Task<V2.StripeList<FeeBatch>> ListAsync(FeeBatchListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<FeeBatch>>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/fee_batches", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List FeeBatches optionally filtered by collection_record.
        /// </summary>
        public virtual IEnumerable<FeeBatch> ListAutoPaging(FeeBatchListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<FeeBatch>($"/v2/core/fee_batches", options, requestOptions);
        }

        /// <summary>
        /// List FeeBatches optionally filtered by collection_record.
        /// </summary>
        public virtual IAsyncEnumerable<FeeBatch> ListAutoPagingAsync(FeeBatchListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<FeeBatch>($"/v2/core/fee_batches", options, requestOptions, cancellationToken);
        }
    }
}
