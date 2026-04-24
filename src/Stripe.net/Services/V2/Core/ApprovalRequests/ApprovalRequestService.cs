// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ApprovalRequestService : Service
    {
        internal ApprovalRequestService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ApprovalRequestService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// POST /v2/core/approval_requests/:id/cancel Cancels a pending approval request.
        /// </summary>
        public virtual ApprovalRequest Cancel(string id, ApprovalRequestCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ApprovalRequest>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/approval_requests/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// POST /v2/core/approval_requests/:id/cancel Cancels a pending approval request.
        /// </summary>
        public virtual Task<ApprovalRequest> CancelAsync(string id, ApprovalRequestCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ApprovalRequest>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/approval_requests/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// POST /v2/core/approval_requests/:id/execute Executes an approved approval request.
        /// </summary>
        public virtual ApprovalRequest Execute(string id, ApprovalRequestExecuteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ApprovalRequest>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/approval_requests/{WebUtility.UrlEncode(id)}/execute", options, requestOptions);
        }

        /// <summary>
        /// POST /v2/core/approval_requests/:id/execute Executes an approved approval request.
        /// </summary>
        public virtual Task<ApprovalRequest> ExecuteAsync(string id, ApprovalRequestExecuteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ApprovalRequest>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/approval_requests/{WebUtility.UrlEncode(id)}/execute", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// GET /v2/core/approval_requests/:id Retrieves an approval request by ID.
        /// </summary>
        public virtual ApprovalRequest Get(string id, ApprovalRequestGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ApprovalRequest>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/approval_requests/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// GET /v2/core/approval_requests/:id Retrieves an approval request by ID.
        /// </summary>
        public virtual Task<ApprovalRequest> GetAsync(string id, ApprovalRequestGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ApprovalRequest>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/approval_requests/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// GET /v2/core/approval_requests Lists approval requests with optional filtering.
        /// </summary>
        public virtual V2.StripeList<ApprovalRequest> List(ApprovalRequestListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<ApprovalRequest>>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/approval_requests", options, requestOptions);
        }

        /// <summary>
        /// GET /v2/core/approval_requests Lists approval requests with optional filtering.
        /// </summary>
        public virtual Task<V2.StripeList<ApprovalRequest>> ListAsync(ApprovalRequestListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<ApprovalRequest>>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/approval_requests", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// GET /v2/core/approval_requests Lists approval requests with optional filtering.
        /// </summary>
        public virtual IEnumerable<ApprovalRequest> ListAutoPaging(ApprovalRequestListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ApprovalRequest>($"/v2/core/approval_requests", options, requestOptions);
        }

        /// <summary>
        /// GET /v2/core/approval_requests Lists approval requests with optional filtering.
        /// </summary>
        public virtual IAsyncEnumerable<ApprovalRequest> ListAutoPagingAsync(ApprovalRequestListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ApprovalRequest>($"/v2/core/approval_requests", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// POST /v2/core/approval_requests/:id/submit Moves a pending approval request into the
        /// reviewer queue for auto-execution upon approval.
        /// </summary>
        public virtual ApprovalRequest Submit(string id, ApprovalRequestSubmitOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ApprovalRequest>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/approval_requests/{WebUtility.UrlEncode(id)}/submit", options, requestOptions);
        }

        /// <summary>
        /// POST /v2/core/approval_requests/:id/submit Moves a pending approval request into the
        /// reviewer queue for auto-execution upon approval.
        /// </summary>
        public virtual Task<ApprovalRequest> SubmitAsync(string id, ApprovalRequestSubmitOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ApprovalRequest>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/approval_requests/{WebUtility.UrlEncode(id)}/submit", options, requestOptions, cancellationToken);
        }
    }
}
