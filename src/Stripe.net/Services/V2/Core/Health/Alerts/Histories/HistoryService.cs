// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Health.Alerts
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class HistoryService : Service
    {
        internal HistoryService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal HistoryService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieves a list of alert history entries for a health alert.
        /// </summary>
        public virtual V2.StripeList<V2.Core.Health.AlertHistoryEntry> List(string id, HistoryListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.Core.Health.AlertHistoryEntry>>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/health/alerts/{WebUtility.UrlEncode(id)}/history", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a list of alert history entries for a health alert.
        /// </summary>
        public virtual Task<V2.StripeList<V2.Core.Health.AlertHistoryEntry>> ListAsync(string id, HistoryListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.Core.Health.AlertHistoryEntry>>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/health/alerts/{WebUtility.UrlEncode(id)}/history", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves a list of alert history entries for a health alert.
        /// </summary>
        public virtual IEnumerable<V2.Core.Health.AlertHistoryEntry> ListAutoPaging(string id, HistoryListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.Core.Health.AlertHistoryEntry>($"/v2/core/health/alerts/{WebUtility.UrlEncode(id)}/history", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a list of alert history entries for a health alert.
        /// </summary>
        public virtual IAsyncEnumerable<V2.Core.Health.AlertHistoryEntry> ListAutoPagingAsync(string id, HistoryListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.Core.Health.AlertHistoryEntry>($"/v2/core/health/alerts/{WebUtility.UrlEncode(id)}/history", options, requestOptions, cancellationToken);
        }
    }
}
