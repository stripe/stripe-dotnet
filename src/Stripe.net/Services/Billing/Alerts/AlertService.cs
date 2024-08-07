// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AlertService : Service<Alert>,
        ICreatable<Alert, AlertCreateOptions>,
        IListable<Alert, AlertListOptions>,
        IRetrievable<Alert, AlertGetOptions>
    {
        public AlertService()
        {
        }

        public AlertService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/billing/alerts";

        /// <summary>
        /// <p>Reactivates this alert, allowing it to trigger again.</p>.
        /// </summary>
        public virtual Alert Activate(string id, AlertActivateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Alert>(HttpMethod.Post, $"/v1/billing/alerts/{id}/activate", options, requestOptions);
        }

        /// <summary>
        /// <p>Reactivates this alert, allowing it to trigger again.</p>.
        /// </summary>
        public virtual Task<Alert> ActivateAsync(string id, AlertActivateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Alert>(HttpMethod.Post, $"/v1/billing/alerts/{id}/activate", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Archives this alert, removing it from the list view and APIs. This is
        /// non-reversible.</p>.
        /// </summary>
        public virtual Alert Archive(string id, AlertArchiveOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Alert>(HttpMethod.Post, $"/v1/billing/alerts/{id}/archive", options, requestOptions);
        }

        /// <summary>
        /// <p>Archives this alert, removing it from the list view and APIs. This is
        /// non-reversible.</p>.
        /// </summary>
        public virtual Task<Alert> ArchiveAsync(string id, AlertArchiveOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Alert>(HttpMethod.Post, $"/v1/billing/alerts/{id}/archive", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Creates a billing alert</p>.
        /// </summary>
        public virtual Alert Create(AlertCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Alert>(HttpMethod.Post, $"/v1/billing/alerts", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a billing alert</p>.
        /// </summary>
        public virtual Task<Alert> CreateAsync(AlertCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Alert>(HttpMethod.Post, $"/v1/billing/alerts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Deactivates this alert, preventing it from triggering.</p>.
        /// </summary>
        public virtual Alert Deactivate(string id, AlertDeactivateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Alert>(HttpMethod.Post, $"/v1/billing/alerts/{id}/deactivate", options, requestOptions);
        }

        /// <summary>
        /// <p>Deactivates this alert, preventing it from triggering.</p>.
        /// </summary>
        public virtual Task<Alert> DeactivateAsync(string id, AlertDeactivateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Alert>(HttpMethod.Post, $"/v1/billing/alerts/{id}/deactivate", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a billing alert given an ID</p>.
        /// </summary>
        public virtual Alert Get(string id, AlertGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Alert>(HttpMethod.Get, $"/v1/billing/alerts/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a billing alert given an ID</p>.
        /// </summary>
        public virtual Task<Alert> GetAsync(string id, AlertGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Alert>(HttpMethod.Get, $"/v1/billing/alerts/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists billing active and inactive alerts</p>.
        /// </summary>
        public virtual StripeList<Alert> List(AlertListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Alert>>(HttpMethod.Get, $"/v1/billing/alerts", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists billing active and inactive alerts</p>.
        /// </summary>
        public virtual Task<StripeList<Alert>> ListAsync(AlertListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Alert>>(HttpMethod.Get, $"/v1/billing/alerts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists billing active and inactive alerts</p>.
        /// </summary>
        public virtual IEnumerable<Alert> ListAutoPaging(AlertListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Alert>($"/v1/billing/alerts", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists billing active and inactive alerts</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Alert> ListAutoPagingAsync(AlertListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Alert>($"/v1/billing/alerts", options, requestOptions, cancellationToken);
        }
    }
}
