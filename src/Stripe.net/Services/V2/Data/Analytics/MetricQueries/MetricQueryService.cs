// File generated from our OpenAPI spec
namespace Stripe.V2.Data.Analytics
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class MetricQueryService : Service
    {
        internal MetricQueryService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal MetricQueryService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Run a synchronous metric query against one or more metrics within the same metric
        /// namespace.
        /// </summary>
        public virtual MetricQueryResult Create(MetricQueryCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<MetricQueryResult>(BaseAddress.Api, HttpMethod.Post, $"/v2/data/analytics/metric_query", options, requestOptions);
        }

        /// <summary>
        /// Run a synchronous metric query against one or more metrics within the same metric
        /// namespace.
        /// </summary>
        public virtual Task<MetricQueryResult> CreateAsync(MetricQueryCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<MetricQueryResult>(BaseAddress.Api, HttpMethod.Post, $"/v2/data/analytics/metric_query", options, requestOptions, cancellationToken);
        }
    }
}
