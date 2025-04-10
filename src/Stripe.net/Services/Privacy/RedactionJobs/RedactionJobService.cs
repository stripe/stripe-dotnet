// File generated from our OpenAPI spec
namespace Stripe.Privacy
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class RedactionJobService : Service,
        ICreatable<RedactionJob, RedactionJobCreateOptions>,
        IListable<RedactionJob, RedactionJobListOptions>,
        IRetrievable<RedactionJob, RedactionJobGetOptions>,
        IUpdatable<RedactionJob, RedactionJobUpdateOptions>
    {
        private RedactionJobValidationErrorService validationErrors;

        public RedactionJobService()
        {
        }

        internal RedactionJobService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public RedactionJobService(IStripeClient client)
            : base(client)
        {
        }

        public virtual RedactionJobValidationErrorService ValidationErrors => this.validationErrors ??= new RedactionJobValidationErrorService(
            this.Requestor);

        /// <summary>
        /// <p>Cancel redaction job method</p>.
        /// </summary>
        public virtual RedactionJob Cancel(string id, RedactionJobCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<RedactionJob>(BaseAddress.Api, HttpMethod.Post, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// <p>Cancel redaction job method</p>.
        /// </summary>
        public virtual Task<RedactionJob> CancelAsync(string id, RedactionJobCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RedactionJob>(BaseAddress.Api, HttpMethod.Post, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Create redaction job method</p>.
        /// </summary>
        public virtual RedactionJob Create(RedactionJobCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<RedactionJob>(BaseAddress.Api, HttpMethod.Post, $"/v1/privacy/redaction_jobs", options, requestOptions);
        }

        /// <summary>
        /// <p>Create redaction job method</p>.
        /// </summary>
        public virtual Task<RedactionJob> CreateAsync(RedactionJobCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RedactionJob>(BaseAddress.Api, HttpMethod.Post, $"/v1/privacy/redaction_jobs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve redaction job method</p>.
        /// </summary>
        public virtual RedactionJob Get(string id, RedactionJobGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<RedactionJob>(BaseAddress.Api, HttpMethod.Get, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve redaction job method</p>.
        /// </summary>
        public virtual Task<RedactionJob> GetAsync(string id, RedactionJobGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RedactionJob>(BaseAddress.Api, HttpMethod.Get, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List redaction jobs method...</p>.
        /// </summary>
        public virtual StripeList<RedactionJob> List(RedactionJobListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<RedactionJob>>(BaseAddress.Api, HttpMethod.Get, $"/v1/privacy/redaction_jobs", options, requestOptions);
        }

        /// <summary>
        /// <p>List redaction jobs method...</p>.
        /// </summary>
        public virtual Task<StripeList<RedactionJob>> ListAsync(RedactionJobListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<RedactionJob>>(BaseAddress.Api, HttpMethod.Get, $"/v1/privacy/redaction_jobs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List redaction jobs method...</p>.
        /// </summary>
        public virtual IEnumerable<RedactionJob> ListAutoPaging(RedactionJobListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<RedactionJob>($"/v1/privacy/redaction_jobs", options, requestOptions);
        }

        /// <summary>
        /// <p>List redaction jobs method...</p>.
        /// </summary>
        public virtual IAsyncEnumerable<RedactionJob> ListAutoPagingAsync(RedactionJobListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<RedactionJob>($"/v1/privacy/redaction_jobs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Run redaction job method</p>.
        /// </summary>
        public virtual RedactionJob Run(string id, RedactionJobRunOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<RedactionJob>(BaseAddress.Api, HttpMethod.Post, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(id)}/run", options, requestOptions);
        }

        /// <summary>
        /// <p>Run redaction job method</p>.
        /// </summary>
        public virtual Task<RedactionJob> RunAsync(string id, RedactionJobRunOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RedactionJob>(BaseAddress.Api, HttpMethod.Post, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(id)}/run", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Update redaction job method</p>.
        /// </summary>
        public virtual RedactionJob Update(string id, RedactionJobUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<RedactionJob>(BaseAddress.Api, HttpMethod.Post, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Update redaction job method</p>.
        /// </summary>
        public virtual Task<RedactionJob> UpdateAsync(string id, RedactionJobUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RedactionJob>(BaseAddress.Api, HttpMethod.Post, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Validate redaction job method</p>.
        /// </summary>
        public virtual RedactionJob Validate(string id, RedactionJobValidateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<RedactionJob>(BaseAddress.Api, HttpMethod.Post, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(id)}/validate", options, requestOptions);
        }

        /// <summary>
        /// <p>Validate redaction job method</p>.
        /// </summary>
        public virtual Task<RedactionJob> ValidateAsync(string id, RedactionJobValidateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RedactionJob>(BaseAddress.Api, HttpMethod.Post, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(id)}/validate", options, requestOptions, cancellationToken);
        }
    }
}
