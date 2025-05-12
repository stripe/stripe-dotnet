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
        /// <p>You can cancel a redaction job when it’s in one of these statuses: <c>ready</c>,
        /// <c>failed</c>.</p>.
        ///
        /// <p>Canceling the redaction job will abandon its attempt to redact the configured
        /// objects. A canceled job cannot be used again.</p>.
        /// </summary>
        public virtual RedactionJob Cancel(string id, RedactionJobCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<RedactionJob>(BaseAddress.Api, HttpMethod.Post, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// <p>You can cancel a redaction job when it’s in one of these statuses: <c>ready</c>,
        /// <c>failed</c>.</p>.
        ///
        /// <p>Canceling the redaction job will abandon its attempt to redact the configured
        /// objects. A canceled job cannot be used again.</p>.
        /// </summary>
        public virtual Task<RedactionJob> CancelAsync(string id, RedactionJobCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RedactionJob>(BaseAddress.Api, HttpMethod.Post, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Creates a redaction job. When a job is created, it will start to validate.</p>.
        /// </summary>
        public virtual RedactionJob Create(RedactionJobCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<RedactionJob>(BaseAddress.Api, HttpMethod.Post, $"/v1/privacy/redaction_jobs", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a redaction job. When a job is created, it will start to validate.</p>.
        /// </summary>
        public virtual Task<RedactionJob> CreateAsync(RedactionJobCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RedactionJob>(BaseAddress.Api, HttpMethod.Post, $"/v1/privacy/redaction_jobs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of a previously created redaction job.</p>.
        /// </summary>
        public virtual RedactionJob Get(string id, RedactionJobGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<RedactionJob>(BaseAddress.Api, HttpMethod.Get, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of a previously created redaction job.</p>.
        /// </summary>
        public virtual Task<RedactionJob> GetAsync(string id, RedactionJobGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RedactionJob>(BaseAddress.Api, HttpMethod.Get, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of redaction jobs.</p>.
        /// </summary>
        public virtual StripeList<RedactionJob> List(RedactionJobListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<RedactionJob>>(BaseAddress.Api, HttpMethod.Get, $"/v1/privacy/redaction_jobs", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of redaction jobs.</p>.
        /// </summary>
        public virtual Task<StripeList<RedactionJob>> ListAsync(RedactionJobListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<RedactionJob>>(BaseAddress.Api, HttpMethod.Get, $"/v1/privacy/redaction_jobs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of redaction jobs.</p>.
        /// </summary>
        public virtual IEnumerable<RedactionJob> ListAutoPaging(RedactionJobListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<RedactionJob>($"/v1/privacy/redaction_jobs", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of redaction jobs.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<RedactionJob> ListAutoPagingAsync(RedactionJobListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<RedactionJob>($"/v1/privacy/redaction_jobs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Run a redaction job in a <c>ready</c> status.</p>.
        ///
        /// <p>When you run a job, the configured objects will be redacted asynchronously. This
        /// action is irreversible and cannot be canceled once started.</p>.
        ///
        /// <p>The status of the job will move to <c>redacting</c>. Once all of the objects are
        /// redacted, the status will become <c>succeeded</c>. If the job’s
        /// <c>validation_behavior</c> is set to <c>fix</c>, the automatic fixes will be applied to
        /// objects at this step.</p>.
        /// </summary>
        public virtual RedactionJob Run(string id, RedactionJobRunOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<RedactionJob>(BaseAddress.Api, HttpMethod.Post, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(id)}/run", options, requestOptions);
        }

        /// <summary>
        /// <p>Run a redaction job in a <c>ready</c> status.</p>.
        ///
        /// <p>When you run a job, the configured objects will be redacted asynchronously. This
        /// action is irreversible and cannot be canceled once started.</p>.
        ///
        /// <p>The status of the job will move to <c>redacting</c>. Once all of the objects are
        /// redacted, the status will become <c>succeeded</c>. If the job’s
        /// <c>validation_behavior</c> is set to <c>fix</c>, the automatic fixes will be applied to
        /// objects at this step.</p>.
        /// </summary>
        public virtual Task<RedactionJob> RunAsync(string id, RedactionJobRunOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RedactionJob>(BaseAddress.Api, HttpMethod.Post, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(id)}/run", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the properties of a redaction job without running or canceling the job.</p>.
        ///
        /// <p>If the job to update is in a <c>failed</c> status, it will not automatically start to
        /// validate. Once you applied all of the changes, use the validate API to start validation
        /// again.</p>.
        /// </summary>
        public virtual RedactionJob Update(string id, RedactionJobUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<RedactionJob>(BaseAddress.Api, HttpMethod.Post, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the properties of a redaction job without running or canceling the job.</p>.
        ///
        /// <p>If the job to update is in a <c>failed</c> status, it will not automatically start to
        /// validate. Once you applied all of the changes, use the validate API to start validation
        /// again.</p>.
        /// </summary>
        public virtual Task<RedactionJob> UpdateAsync(string id, RedactionJobUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RedactionJob>(BaseAddress.Api, HttpMethod.Post, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Validate a redaction job when it is in a <c>failed</c> status.</p>.
        ///
        /// <p>When a job is created, it automatically begins to validate on the configured objects’
        /// eligibility for redaction. Use this to validate the job again after its validation
        /// errors are resolved or the job’s <c>validation_behavior</c> is changed.</p>.
        ///
        /// <p>The status of the job will move to <c>validating</c>. Once all of the objects are
        /// validated, the status of the job will become <c>ready</c>. If there are any validation
        /// errors preventing the job from running, the status will become <c>failed</c>.</p>.
        /// </summary>
        public virtual RedactionJob Validate(string id, RedactionJobValidateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<RedactionJob>(BaseAddress.Api, HttpMethod.Post, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(id)}/validate", options, requestOptions);
        }

        /// <summary>
        /// <p>Validate a redaction job when it is in a <c>failed</c> status.</p>.
        ///
        /// <p>When a job is created, it automatically begins to validate on the configured objects’
        /// eligibility for redaction. Use this to validate the job again after its validation
        /// errors are resolved or the job’s <c>validation_behavior</c> is changed.</p>.
        ///
        /// <p>The status of the job will move to <c>validating</c>. Once all of the objects are
        /// validated, the status of the job will become <c>ready</c>. If there are any validation
        /// errors preventing the job from running, the status will become <c>failed</c>.</p>.
        /// </summary>
        public virtual Task<RedactionJob> ValidateAsync(string id, RedactionJobValidateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RedactionJob>(BaseAddress.Api, HttpMethod.Post, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(id)}/validate", options, requestOptions, cancellationToken);
        }
    }
}
