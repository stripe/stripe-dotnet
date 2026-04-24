// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ActivityLogService : Service
    {
        internal ActivityLogService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ActivityLogService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// List activity logs of an account.
        /// </summary>
        public virtual V2.StripeList<ActivityLog> List(ActivityLogListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<ActivityLog>>(BaseAddress.Api, HttpMethod.Get, $"/v2/iam/activity_logs", options, requestOptions);
        }

        /// <summary>
        /// List activity logs of an account.
        /// </summary>
        public virtual Task<V2.StripeList<ActivityLog>> ListAsync(ActivityLogListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<ActivityLog>>(BaseAddress.Api, HttpMethod.Get, $"/v2/iam/activity_logs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List activity logs of an account.
        /// </summary>
        public virtual IEnumerable<ActivityLog> ListAutoPaging(ActivityLogListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ActivityLog>($"/v2/iam/activity_logs", options, requestOptions);
        }

        /// <summary>
        /// List activity logs of an account.
        /// </summary>
        public virtual IAsyncEnumerable<ActivityLog> ListAutoPagingAsync(ActivityLogListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ActivityLog>($"/v2/iam/activity_logs", options, requestOptions, cancellationToken);
        }
    }
}
