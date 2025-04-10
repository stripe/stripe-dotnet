// File generated from our OpenAPI spec
namespace Stripe.Privacy
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class RedactionJobValidationErrorService : Service,
        INestedListable<RedactionJobValidationError, RedactionJobValidationErrorListOptions>,
        INestedRetrievable<RedactionJobValidationError, RedactionJobValidationErrorGetOptions>
    {
        public RedactionJobValidationErrorService()
        {
        }

        internal RedactionJobValidationErrorService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public RedactionJobValidationErrorService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieve validation error method</p>.
        /// </summary>
        public virtual RedactionJobValidationError Get(string parentId, string id, RedactionJobValidationErrorGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<RedactionJobValidationError>(BaseAddress.Api, HttpMethod.Get, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(parentId)}/validation_errors/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve validation error method</p>.
        /// </summary>
        public virtual Task<RedactionJobValidationError> GetAsync(string parentId, string id, RedactionJobValidationErrorGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<RedactionJobValidationError>(BaseAddress.Api, HttpMethod.Get, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(parentId)}/validation_errors/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List validation errors method</p>.
        /// </summary>
        public virtual StripeList<RedactionJobValidationError> List(string parentId, RedactionJobValidationErrorListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<RedactionJobValidationError>>(BaseAddress.Api, HttpMethod.Get, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(parentId)}/validation_errors", options, requestOptions);
        }

        /// <summary>
        /// <p>List validation errors method</p>.
        /// </summary>
        public virtual Task<StripeList<RedactionJobValidationError>> ListAsync(string parentId, RedactionJobValidationErrorListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<RedactionJobValidationError>>(BaseAddress.Api, HttpMethod.Get, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(parentId)}/validation_errors", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List validation errors method</p>.
        /// </summary>
        public virtual IEnumerable<RedactionJobValidationError> ListAutoPaging(string parentId, RedactionJobValidationErrorListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<RedactionJobValidationError>($"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(parentId)}/validation_errors", options, requestOptions);
        }

        /// <summary>
        /// <p>List validation errors method</p>.
        /// </summary>
        public virtual IAsyncEnumerable<RedactionJobValidationError> ListAutoPagingAsync(string parentId, RedactionJobValidationErrorListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<RedactionJobValidationError>($"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(parentId)}/validation_errors", options, requestOptions, cancellationToken);
        }
    }
}
