// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class PaymentLinkService : Service,
        ICreatable<PaymentLink, PaymentLinkCreateOptions>,
        IListable<PaymentLink, PaymentLinkListOptions>,
        IRetrievable<PaymentLink, PaymentLinkGetOptions>,
        IUpdatable<PaymentLink, PaymentLinkUpdateOptions>
    {
        private PaymentLinkLineItemService lineItems;

        public PaymentLinkService()
        {
        }

        internal PaymentLinkService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public PaymentLinkService(IStripeClient client)
            : base(client)
        {
        }

        public virtual PaymentLinkLineItemService LineItems => this.lineItems ??= new PaymentLinkLineItemService(
            this.Requestor);

        /// <summary>
        /// <p>Creates a payment link.</p>.
        /// </summary>
        public virtual PaymentLink Create(PaymentLinkCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentLink>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_links", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a payment link.</p>.
        /// </summary>
        public virtual Task<PaymentLink> CreateAsync(PaymentLinkCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentLink>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_links", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a payment link.</p>.
        /// </summary>
        public virtual PaymentLink Get(string id, PaymentLinkGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentLink>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_links/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a payment link.</p>.
        /// </summary>
        public virtual Task<PaymentLink> GetAsync(string id, PaymentLinkGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentLink>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_links/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your payment links.</p>.
        /// </summary>
        public virtual StripeList<PaymentLink> List(PaymentLinkListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<PaymentLink>>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_links", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your payment links.</p>.
        /// </summary>
        public virtual Task<StripeList<PaymentLink>> ListAsync(PaymentLinkListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<PaymentLink>>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_links", options, requestOptions, cancellationToken);
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
        /// <p>Updates a payment link.</p>.
        /// </summary>
        public virtual PaymentLink Update(string id, PaymentLinkUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentLink>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_links/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates a payment link.</p>.
        /// </summary>
        public virtual Task<PaymentLink> UpdateAsync(string id, PaymentLinkUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentLink>(BaseAddress.Api, HttpMethod.Post, $"/v1/payment_links/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
