// File generated from our OpenAPI spec
namespace Stripe
{
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
            : base(null)
        {
        }

        public PaymentLinkService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/payment_links";

        public virtual PaymentLink Create(PaymentLinkCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentLink>(HttpMethod.Post, $"/v1/payment_links", options, requestOptions);
        }

        public virtual Task<PaymentLink> CreateAsync(PaymentLinkCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentLink>(HttpMethod.Post, $"/v1/payment_links", options, requestOptions, cancellationToken);
        }

        public virtual PaymentLink Get(string id, PaymentLinkGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentLink>(HttpMethod.Get, $"/v1/payment_links/{id}", options, requestOptions);
        }

        public virtual Task<PaymentLink> GetAsync(string id, PaymentLinkGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentLink>(HttpMethod.Get, $"/v1/payment_links/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<PaymentLink> List(PaymentLinkListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<PaymentLink>>(HttpMethod.Get, $"/v1/payment_links", options, requestOptions);
        }

        public virtual Task<StripeList<PaymentLink>> ListAsync(PaymentLinkListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<PaymentLink>>(HttpMethod.Get, $"/v1/payment_links", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<PaymentLink> ListAutoPaging(PaymentLinkListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<PaymentLink>($"/v1/payment_links", options, requestOptions);
        }

        public virtual IAsyncEnumerable<PaymentLink> ListAutoPagingAsync(PaymentLinkListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<PaymentLink>($"/v1/payment_links", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<LineItem> ListLineItems(string id, PaymentLinkListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<LineItem>>(HttpMethod.Get, $"/v1/payment_links/{id}/line_items", options, requestOptions);
        }

        public virtual Task<StripeList<LineItem>> ListLineItemsAsync(string id, PaymentLinkListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<LineItem>>(HttpMethod.Get, $"/v1/payment_links/{id}/line_items", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<LineItem> ListLineItemsAutoPaging(string id, PaymentLinkListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<LineItem>($"/v1/payment_links/{id}/line_items", options, requestOptions);
        }

        public virtual IAsyncEnumerable<LineItem> ListLineItemsAutoPagingAsync(string id, PaymentLinkListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<LineItem>($"/v1/payment_links/{id}/line_items", options, requestOptions, cancellationToken);
        }

        public virtual PaymentLink Update(string id, PaymentLinkUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentLink>(HttpMethod.Post, $"/v1/payment_links/{id}", options, requestOptions);
        }

        public virtual Task<PaymentLink> UpdateAsync(string id, PaymentLinkUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentLink>(HttpMethod.Post, $"/v1/payment_links/{id}", options, requestOptions, cancellationToken);
        }
    }
}
