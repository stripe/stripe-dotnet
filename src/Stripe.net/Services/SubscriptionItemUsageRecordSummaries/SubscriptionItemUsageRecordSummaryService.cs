// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SubscriptionItemUsageRecordSummaryService : Service,
        INestedListable<UsageRecordSummary, SubscriptionItemUsageRecordSummaryListOptions>
    {
        public SubscriptionItemUsageRecordSummaryService()
        {
        }

        internal SubscriptionItemUsageRecordSummaryService(
            ApiRequestor requestor)
            : base(requestor)
        {
        }

        public SubscriptionItemUsageRecordSummaryService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>For the specified subscription item, returns a list of summary objects. Each object
        /// in the list provides usage information that’s been summarized from multiple usage
        /// records and over a subscription billing period (e.g., 15 usage records in the month of
        /// September).</p>.
        ///
        /// <p>The list is sorted in reverse-chronological order (newest first). The first list item
        /// represents the most current usage period that hasn’t ended yet. Since new usage records
        /// can still be added, the returned summary information for the subscription item’s ID
        /// should be seen as unstable until the subscription billing period ends.</p>.
        /// </summary>
        public virtual StripeList<UsageRecordSummary> List(string parentId, SubscriptionItemUsageRecordSummaryListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<UsageRecordSummary>>(BaseAddress.Api, HttpMethod.Get, $"/v1/subscription_items/{WebUtility.UrlEncode(parentId)}/usage_record_summaries", options, requestOptions);
        }

        /// <summary>
        /// <p>For the specified subscription item, returns a list of summary objects. Each object
        /// in the list provides usage information that’s been summarized from multiple usage
        /// records and over a subscription billing period (e.g., 15 usage records in the month of
        /// September).</p>.
        ///
        /// <p>The list is sorted in reverse-chronological order (newest first). The first list item
        /// represents the most current usage period that hasn’t ended yet. Since new usage records
        /// can still be added, the returned summary information for the subscription item’s ID
        /// should be seen as unstable until the subscription billing period ends.</p>.
        /// </summary>
        public virtual Task<StripeList<UsageRecordSummary>> ListAsync(string parentId, SubscriptionItemUsageRecordSummaryListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<UsageRecordSummary>>(BaseAddress.Api, HttpMethod.Get, $"/v1/subscription_items/{WebUtility.UrlEncode(parentId)}/usage_record_summaries", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>For the specified subscription item, returns a list of summary objects. Each object
        /// in the list provides usage information that’s been summarized from multiple usage
        /// records and over a subscription billing period (e.g., 15 usage records in the month of
        /// September).</p>.
        ///
        /// <p>The list is sorted in reverse-chronological order (newest first). The first list item
        /// represents the most current usage period that hasn’t ended yet. Since new usage records
        /// can still be added, the returned summary information for the subscription item’s ID
        /// should be seen as unstable until the subscription billing period ends.</p>.
        /// </summary>
        public virtual IEnumerable<UsageRecordSummary> ListAutoPaging(string parentId, SubscriptionItemUsageRecordSummaryListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<UsageRecordSummary>($"/v1/subscription_items/{WebUtility.UrlEncode(parentId)}/usage_record_summaries", options, requestOptions);
        }

        /// <summary>
        /// <p>For the specified subscription item, returns a list of summary objects. Each object
        /// in the list provides usage information that’s been summarized from multiple usage
        /// records and over a subscription billing period (e.g., 15 usage records in the month of
        /// September).</p>.
        ///
        /// <p>The list is sorted in reverse-chronological order (newest first). The first list item
        /// represents the most current usage period that hasn’t ended yet. Since new usage records
        /// can still be added, the returned summary information for the subscription item’s ID
        /// should be seen as unstable until the subscription billing period ends.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<UsageRecordSummary> ListAutoPagingAsync(string parentId, SubscriptionItemUsageRecordSummaryListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<UsageRecordSummary>($"/v1/subscription_items/{WebUtility.UrlEncode(parentId)}/usage_record_summaries", options, requestOptions, cancellationToken);
        }
    }
}
