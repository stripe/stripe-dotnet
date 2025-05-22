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
        INestedListable<RedactionJobValidationError, RedactionJobValidationErrorListOptions>
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
        /// <p>Returns a list of validation errors for the specified redaction job.</p>.
        /// </summary>
        public virtual StripeList<RedactionJobValidationError> List(string parentId, RedactionJobValidationErrorListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<RedactionJobValidationError>>(BaseAddress.Api, HttpMethod.Get, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(parentId)}/validation_errors", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of validation errors for the specified redaction job.</p>.
        /// </summary>
        public virtual Task<StripeList<RedactionJobValidationError>> ListAsync(string parentId, RedactionJobValidationErrorListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<RedactionJobValidationError>>(BaseAddress.Api, HttpMethod.Get, $"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(parentId)}/validation_errors", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of validation errors for the specified redaction job.</p>.
        /// </summary>
        public virtual IEnumerable<RedactionJobValidationError> ListAutoPaging(string parentId, RedactionJobValidationErrorListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<RedactionJobValidationError>($"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(parentId)}/validation_errors", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of validation errors for the specified redaction job.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<RedactionJobValidationError> ListAutoPagingAsync(string parentId, RedactionJobValidationErrorListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<RedactionJobValidationError>($"/v1/privacy/redaction_jobs/{WebUtility.UrlEncode(parentId)}/validation_errors", options, requestOptions, cancellationToken);
        }
    }
}
