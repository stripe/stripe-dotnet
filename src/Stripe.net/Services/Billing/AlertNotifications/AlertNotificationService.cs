// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AlertNotificationService : Service,
        INestedListable<AlertNotification, AlertNotificationListOptions>
    {
        public AlertNotificationService()
        {
        }

        internal AlertNotificationService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public AlertNotificationService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Lists sent billing alert triggered and recovered notifications for a billing
        /// alert.</p>.
        /// </summary>
        public virtual StripeList<AlertNotification> List(string parentId, AlertNotificationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<AlertNotification>>(BaseAddress.Api, HttpMethod.Get, $"/v1/billing/alerts/{WebUtility.UrlEncode(parentId)}/notifications", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists sent billing alert triggered and recovered notifications for a billing
        /// alert.</p>.
        /// </summary>
        public virtual Task<StripeList<AlertNotification>> ListAsync(string parentId, AlertNotificationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<AlertNotification>>(BaseAddress.Api, HttpMethod.Get, $"/v1/billing/alerts/{WebUtility.UrlEncode(parentId)}/notifications", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists sent billing alert triggered and recovered notifications for a billing
        /// alert.</p>.
        /// </summary>
        public virtual IEnumerable<AlertNotification> ListAutoPaging(string parentId, AlertNotificationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<AlertNotification>($"/v1/billing/alerts/{WebUtility.UrlEncode(parentId)}/notifications", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists sent billing alert triggered and recovered notifications for a billing
        /// alert.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<AlertNotification> ListAutoPagingAsync(string parentId, AlertNotificationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<AlertNotification>($"/v1/billing/alerts/{WebUtility.UrlEncode(parentId)}/notifications", options, requestOptions, cancellationToken);
        }
    }
}
