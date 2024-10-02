// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class MarginService : Service<Margin>,
        ICreatable<Margin, MarginCreateOptions>,
        IListable<Margin, MarginListOptions>,
        IRetrievable<Margin, MarginGetOptions>,
        IUpdatable<Margin, MarginUpdateOptions>
    {
        public MarginService()
        {
        }

        internal MarginService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public MarginService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Create a margin object to be used with invoices, invoice items, and invoice line
        /// items for a customer to represent a partner discount. A margin has a <c>percent_off</c>
        /// which is the percent that will be taken off the subtotal after all items and other
        /// discounts and promotions) of any invoices for a customer. Calculation of prorations do
        /// not include any partner margins applied on the original invoice item.</p>.
        /// </summary>
        public virtual Margin Create(MarginCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Margin>(BaseAddress.Api, HttpMethod.Post, $"/v1/billing/margins", options, requestOptions);
        }

        /// <summary>
        /// <p>Create a margin object to be used with invoices, invoice items, and invoice line
        /// items for a customer to represent a partner discount. A margin has a <c>percent_off</c>
        /// which is the percent that will be taken off the subtotal after all items and other
        /// discounts and promotions) of any invoices for a customer. Calculation of prorations do
        /// not include any partner margins applied on the original invoice item.</p>.
        /// </summary>
        public virtual Task<Margin> CreateAsync(MarginCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Margin>(BaseAddress.Api, HttpMethod.Post, $"/v1/billing/margins", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a margin object with the given ID.</p>.
        /// </summary>
        public virtual Margin Get(string id, MarginGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Margin>(BaseAddress.Api, HttpMethod.Get, $"/v1/billing/margins/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a margin object with the given ID.</p>.
        /// </summary>
        public virtual Task<Margin> GetAsync(string id, MarginGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Margin>(BaseAddress.Api, HttpMethod.Get, $"/v1/billing/margins/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a list of your margins.</p>.
        /// </summary>
        public virtual StripeList<Margin> List(MarginListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Margin>>(BaseAddress.Api, HttpMethod.Get, $"/v1/billing/margins", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a list of your margins.</p>.
        /// </summary>
        public virtual Task<StripeList<Margin>> ListAsync(MarginListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Margin>>(BaseAddress.Api, HttpMethod.Get, $"/v1/billing/margins", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a list of your margins.</p>.
        /// </summary>
        public virtual IEnumerable<Margin> ListAutoPaging(MarginListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Margin>($"/v1/billing/margins", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a list of your margins.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Margin> ListAutoPagingAsync(MarginListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Margin>($"/v1/billing/margins", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Update the specified margin object. Certain fields of the margin object are not
        /// editable.</p>.
        /// </summary>
        public virtual Margin Update(string id, MarginUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Margin>(BaseAddress.Api, HttpMethod.Post, $"/v1/billing/margins/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Update the specified margin object. Certain fields of the margin object are not
        /// editable.</p>.
        /// </summary>
        public virtual Task<Margin> UpdateAsync(string id, MarginUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Margin>(BaseAddress.Api, HttpMethod.Post, $"/v1/billing/margins/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
