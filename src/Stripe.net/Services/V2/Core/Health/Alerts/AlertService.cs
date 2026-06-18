// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Health
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AlertService : Service
    {
        private V2.Core.Health.Alerts.HistoryService history;

        internal AlertService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal AlertService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Core.Health.Alerts.HistoryService History => this.history ??= new V2.Core.Health.Alerts.HistoryService(
            this.Requestor);

        /// <summary>
        /// Retrieves a health alert by ID.
        /// </summary>
        public virtual Alert Get(string id, AlertGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Alert>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/health/alerts/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a health alert by ID.
        /// </summary>
        public virtual Task<Alert> GetAsync(string id, AlertGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Alert>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/health/alerts/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves a list of health alerts.
        /// </summary>
        public virtual V2.StripeList<Alert> List(AlertListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<Alert>>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/health/alerts", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a list of health alerts.
        /// </summary>
        public virtual Task<V2.StripeList<Alert>> ListAsync(AlertListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<Alert>>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/health/alerts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves a list of health alerts.
        /// </summary>
        public virtual IEnumerable<Alert> ListAutoPaging(AlertListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Alert>($"/v2/core/health/alerts", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a list of health alerts.
        /// </summary>
        public virtual IAsyncEnumerable<Alert> ListAutoPagingAsync(AlertListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Alert>($"/v2/core/health/alerts", options, requestOptions, cancellationToken);
        }
    }
}
