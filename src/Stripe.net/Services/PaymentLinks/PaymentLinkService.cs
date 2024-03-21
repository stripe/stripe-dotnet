// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentLinkService : Service<PaymentLink>,
        ICreatable<PaymentLink, PaymentLinkCreateOptions>,
        IListable<PaymentLink, PaymentLinkListOptions>,
        IRetrievable<PaymentLink, PaymentLinkGetOptions>,
        IUpdatable<PaymentLink, PaymentLinkUpdateOptions>
    {
        public PaymentLinkService()
        {
        }

        public PaymentLinkService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/payment_links";

        /// <summary>
        /// <p>Creates a payment link.</p>.
        /// </summary>
        public virtual PaymentLink Create(PaymentLinkCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentLink>(HttpMethod.Post, $"/v1/payment_links", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a payment link.</p>.
        /// </summary>
        public virtual Task<PaymentLink> CreateAsync(PaymentLinkCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentLink>(HttpMethod.Post, $"/v1/payment_links", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a payment link.</p>.
        /// </summary>
        public virtual PaymentLink Get(string id, PaymentLinkGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentLink>(HttpMethod.Get, $"/v1/payment_links/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a payment link.</p>.
        /// </summary>
        public virtual Task<PaymentLink> GetAsync(string id, PaymentLinkGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentLink>(HttpMethod.Get, $"/v1/payment_links/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your payment links.</p>.
        /// </summary>
        public virtual StripeList<PaymentLink> List(PaymentLinkListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<PaymentLink>>(HttpMethod.Get, $"/v1/payment_links", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your payment links.</p>.
        /// </summary>
        public virtual Task<StripeList<PaymentLink>> ListAsync(PaymentLinkListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<PaymentLink>>(HttpMethod.Get, $"/v1/payment_links", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your payment links.</p>.
        /// </summary>
        public virtual IEnumerable<PaymentLink> ListAutoPaging(PaymentLinkListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<PaymentLink>($"/v1/payment_links", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your payment links.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<PaymentLink> ListAutoPagingAsync(PaymentLinkListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<PaymentLink>($"/v1/payment_links", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving a payment link, there is an includable <strong>line_items</strong>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual StripeList<LineItem> ListLineItems(string id, PaymentLinkListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<LineItem>>(HttpMethod.Get, $"/v1/payment_links/{id}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving a payment link, there is an includable <strong>line_items</strong>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual Task<StripeList<LineItem>> ListLineItemsAsync(string id, PaymentLinkListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<LineItem>>(HttpMethod.Get, $"/v1/payment_links/{id}/line_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving a payment link, there is an includable <strong>line_items</strong>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual IEnumerable<LineItem> ListLineItemsAutoPaging(string id, PaymentLinkListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<LineItem>($"/v1/payment_links/{id}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving a payment link, there is an includable <strong>line_items</strong>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<LineItem> ListLineItemsAutoPagingAsync(string id, PaymentLinkListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<LineItem>($"/v1/payment_links/{id}/line_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates a payment link.</p>.
        /// </summary>
        public virtual PaymentLink Update(string id, PaymentLinkUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentLink>(HttpMethod.Post, $"/v1/payment_links/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates a payment link.</p>.
        /// </summary>
        public virtual Task<PaymentLink> UpdateAsync(string id, PaymentLinkUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentLink>(HttpMethod.Post, $"/v1/payment_links/{id}", options, requestOptions, cancellationToken);
        }
    }
}
