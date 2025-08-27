// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.Intents
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ActionService : Service
    {
        internal ActionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ActionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieve a Billing Intent Action.
        /// </summary>
        public virtual V2.Billing.IntentAction Get(string parentId, string id, ActionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Billing.IntentAction>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/intents/{WebUtility.UrlEncode(parentId)}/actions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a Billing Intent Action.
        /// </summary>
        public virtual Task<V2.Billing.IntentAction> GetAsync(string parentId, string id, ActionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Billing.IntentAction>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/intents/{WebUtility.UrlEncode(parentId)}/actions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List Billing Intent Actions.
        /// </summary>
        public virtual V2.StripeList<V2.Billing.IntentAction> List(string id, ActionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.Billing.IntentAction>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/intents/{WebUtility.UrlEncode(id)}/actions", options, requestOptions);
        }

        /// <summary>
        /// List Billing Intent Actions.
        /// </summary>
        public virtual Task<V2.StripeList<V2.Billing.IntentAction>> ListAsync(string id, ActionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.Billing.IntentAction>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/intents/{WebUtility.UrlEncode(id)}/actions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List Billing Intent Actions.
        /// </summary>
        public virtual IEnumerable<V2.Billing.IntentAction> ListAutoPaging(string id, ActionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.Billing.IntentAction>($"/v2/billing/intents/{WebUtility.UrlEncode(id)}/actions", options, requestOptions);
        }

        /// <summary>
        /// List Billing Intent Actions.
        /// </summary>
        public virtual IAsyncEnumerable<V2.Billing.IntentAction> ListAutoPagingAsync(string id, ActionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.Billing.IntentAction>($"/v2/billing/intents/{WebUtility.UrlEncode(id)}/actions", options, requestOptions, cancellationToken);
        }
    }
}
