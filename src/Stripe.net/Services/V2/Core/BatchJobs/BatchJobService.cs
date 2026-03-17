// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class BatchJobService : Service
    {
        internal BatchJobService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal BatchJobService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Cancels an existing batch job.
        /// </summary>
        public virtual BatchJob Cancel(string id, BatchJobCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<BatchJob>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/batch_jobs/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// Cancels an existing batch job.
        /// </summary>
        public virtual Task<BatchJob> CancelAsync(string id, BatchJobCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BatchJob>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/batch_jobs/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Creates a new batch job.
        /// </summary>
        public virtual BatchJob Create(BatchJobCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<BatchJob>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/batch_jobs", options, requestOptions);
        }

        /// <summary>
        /// Creates a new batch job.
        /// </summary>
        public virtual Task<BatchJob> CreateAsync(BatchJobCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BatchJob>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/batch_jobs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves an existing batch job.
        /// </summary>
        public virtual BatchJob Get(string id, BatchJobGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<BatchJob>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/batch_jobs/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves an existing batch job.
        /// </summary>
        public virtual Task<BatchJob> GetAsync(string id, BatchJobGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BatchJob>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/batch_jobs/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
