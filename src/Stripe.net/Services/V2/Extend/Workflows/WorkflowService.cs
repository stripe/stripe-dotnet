// File generated from our OpenAPI spec
namespace Stripe.V2.Extend
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class WorkflowService : Service
    {
        internal WorkflowService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal WorkflowService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieves the details of a Workflow by ID.
        /// </summary>
        public virtual Workflow Get(string id, WorkflowGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Workflow>(BaseAddress.Api, HttpMethod.Get, $"/v2/extend/workflows/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the details of a Workflow by ID.
        /// </summary>
        public virtual Task<Workflow> GetAsync(string id, WorkflowGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Workflow>(BaseAddress.Api, HttpMethod.Get, $"/v2/extend/workflows/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Invokes an on-demand Workflow with parameters, to launch a new Workflow Run.
        /// </summary>
        public virtual WorkflowRun Invoke(string id, WorkflowInvokeOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<WorkflowRun>(BaseAddress.Api, HttpMethod.Post, $"/v2/extend/workflows/{WebUtility.UrlEncode(id)}/invoke", options, requestOptions);
        }

        /// <summary>
        /// Invokes an on-demand Workflow with parameters, to launch a new Workflow Run.
        /// </summary>
        public virtual Task<WorkflowRun> InvokeAsync(string id, WorkflowInvokeOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<WorkflowRun>(BaseAddress.Api, HttpMethod.Post, $"/v2/extend/workflows/{WebUtility.UrlEncode(id)}/invoke", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Workflows.
        /// </summary>
        public virtual V2.StripeList<Workflow> List(WorkflowListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<Workflow>>(BaseAddress.Api, HttpMethod.Get, $"/v2/extend/workflows", options, requestOptions);
        }

        /// <summary>
        /// List all Workflows.
        /// </summary>
        public virtual Task<V2.StripeList<Workflow>> ListAsync(WorkflowListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<Workflow>>(BaseAddress.Api, HttpMethod.Get, $"/v2/extend/workflows", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Workflows.
        /// </summary>
        public virtual IEnumerable<Workflow> ListAutoPaging(WorkflowListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Workflow>($"/v2/extend/workflows", options, requestOptions);
        }

        /// <summary>
        /// List all Workflows.
        /// </summary>
        public virtual IAsyncEnumerable<Workflow> ListAutoPagingAsync(WorkflowListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Workflow>($"/v2/extend/workflows", options, requestOptions, cancellationToken);
        }
    }
}
