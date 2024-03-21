// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class MeterEventSummaryService : ServiceNested<MeterEventSummary>,
        INestedListable<MeterEventSummary, MeterEventSummaryListOptions>
    {
        public MeterEventSummaryService()
        {
        }

        public MeterEventSummaryService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/billing/meters/{PARENT_ID}/event_summaries";

        /// <summary>
        /// <p>Retrieve a list of billing meter event summaries.</p>.
        /// </summary>
        public virtual StripeList<MeterEventSummary> List(string parentId, MeterEventSummaryListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<MeterEventSummary>>(BaseAddress.Api, HttpMethod.Get, $"/v1/billing/meters/{parentId}/event_summaries", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Retrieve a list of billing meter event summaries.</p>.
        /// </summary>
        public virtual Task<StripeList<MeterEventSummary>> ListAsync(string parentId, MeterEventSummaryListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<MeterEventSummary>>(BaseAddress.Api, HttpMethod.Get, $"/v1/billing/meters/{parentId}/event_summaries", options, requestOptions, ApiMode.V1, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a list of billing meter event summaries.</p>.
        /// </summary>
        public virtual IEnumerable<MeterEventSummary> ListAutoPaging(string parentId, MeterEventSummaryListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<MeterEventSummary>($"/v1/billing/meters/{parentId}/event_summaries", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Retrieve a list of billing meter event summaries.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<MeterEventSummary> ListAutoPagingAsync(string parentId, MeterEventSummaryListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<MeterEventSummary>($"/v1/billing/meters/{parentId}/event_summaries", options, requestOptions, ApiMode.V1, cancellationToken);
        }
    }
}
