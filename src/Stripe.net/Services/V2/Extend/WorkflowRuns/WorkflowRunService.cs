// File generated from our OpenAPI spec
namespace Stripe.V2.Extend
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class WorkflowRunService : Service
    {
        internal WorkflowRunService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal WorkflowRunService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieves the details of a Workflow Run by ID.
        /// </summary>
        public virtual WorkflowRun Get(string id, WorkflowRunGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<WorkflowRun>(BaseAddress.Api, HttpMethod.Get, $"/v2/extend/workflow_runs/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the details of a Workflow Run by ID.
        /// </summary>
        public virtual Task<WorkflowRun> GetAsync(string id, WorkflowRunGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<WorkflowRun>(BaseAddress.Api, HttpMethod.Get, $"/v2/extend/workflow_runs/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Workflow Runs.
        /// </summary>
        public virtual V2.StripeList<WorkflowRun> List(WorkflowRunListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<WorkflowRun>>(BaseAddress.Api, HttpMethod.Get, $"/v2/extend/workflow_runs", options, requestOptions);
        }

        /// <summary>
        /// List all Workflow Runs.
        /// </summary>
        public virtual Task<V2.StripeList<WorkflowRun>> ListAsync(WorkflowRunListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<WorkflowRun>>(BaseAddress.Api, HttpMethod.Get, $"/v2/extend/workflow_runs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Workflow Runs.
        /// </summary>
        public virtual IEnumerable<WorkflowRun> ListAutoPaging(WorkflowRunListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<WorkflowRun>($"/v2/extend/workflow_runs", options, requestOptions);
        }

        /// <summary>
        /// List all Workflow Runs.
        /// </summary>
        public virtual IAsyncEnumerable<WorkflowRun> ListAutoPagingAsync(WorkflowRunListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<WorkflowRun>($"/v2/extend/workflow_runs", options, requestOptions, cancellationToken);
        }
    }
}
