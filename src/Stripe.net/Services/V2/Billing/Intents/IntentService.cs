// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class IntentService : Service
    {
        internal IntentService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal IntentService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Cancel a BillingIntent.
        /// </summary>
        public virtual Intent Cancel(string id, IntentCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Intent>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/intents/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// Cancel a BillingIntent.
        /// </summary>
        public virtual Task<Intent> CancelAsync(string id, IntentCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Intent>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/intents/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Commit a BillingIntent.
        /// </summary>
        public virtual Intent Commit(string id, IntentCommitOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Intent>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/intents/{WebUtility.UrlEncode(id)}/commit", options, requestOptions);
        }

        /// <summary>
        /// Commit a BillingIntent.
        /// </summary>
        public virtual Task<Intent> CommitAsync(string id, IntentCommitOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Intent>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/intents/{WebUtility.UrlEncode(id)}/commit", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Create a BillingIntent.
        /// </summary>
        public virtual Intent Create(IntentCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Intent>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/intents", options, requestOptions);
        }

        /// <summary>
        /// Create a BillingIntent.
        /// </summary>
        public virtual Task<Intent> CreateAsync(IntentCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Intent>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/intents", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a BillingIntent.
        /// </summary>
        public virtual Intent Get(string id, IntentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Intent>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/intents/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a BillingIntent.
        /// </summary>
        public virtual Task<Intent> GetAsync(string id, IntentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Intent>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/intents/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List BillingIntents.
        /// </summary>
        public virtual V2.StripeList<Intent> List(IntentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<Intent>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/intents", options, requestOptions);
        }

        /// <summary>
        /// List BillingIntents.
        /// </summary>
        public virtual Task<V2.StripeList<Intent>> ListAsync(IntentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<Intent>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/intents", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List BillingIntents.
        /// </summary>
        public virtual IEnumerable<Intent> ListAutoPaging(IntentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Intent>($"/v2/billing/intents", options, requestOptions);
        }

        /// <summary>
        /// List BillingIntents.
        /// </summary>
        public virtual IAsyncEnumerable<Intent> ListAutoPagingAsync(IntentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Intent>($"/v2/billing/intents", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Release a BillingIntent.
        /// </summary>
        public virtual Intent ReleaseReservation(string id, IntentReleaseReservationOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Intent>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/intents/{WebUtility.UrlEncode(id)}/release_reservation", options, requestOptions);
        }

        /// <summary>
        /// Release a BillingIntent.
        /// </summary>
        public virtual Task<Intent> ReleaseReservationAsync(string id, IntentReleaseReservationOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Intent>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/intents/{WebUtility.UrlEncode(id)}/release_reservation", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Reserve a BillingIntent.
        /// </summary>
        public virtual Intent Reserve(string id, IntentReserveOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Intent>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/intents/{WebUtility.UrlEncode(id)}/reserve", options, requestOptions);
        }

        /// <summary>
        /// Reserve a BillingIntent.
        /// </summary>
        public virtual Task<Intent> ReserveAsync(string id, IntentReserveOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Intent>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/intents/{WebUtility.UrlEncode(id)}/reserve", options, requestOptions, cancellationToken);
        }
    }
}
