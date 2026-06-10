// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TaxFundService : Service,
        IListable<TaxFund, TaxFundListOptions>,
        IRetrievable<TaxFund, TaxFundGetOptions>
    {
        public TaxFundService()
        {
        }

        internal TaxFundService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public TaxFundService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves a tax fund object by its ID.</p>.
        /// </summary>
        public virtual TaxFund Get(string id, TaxFundGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TaxFund>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax_funds/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a tax fund object by its ID.</p>.
        /// </summary>
        public virtual Task<TaxFund> GetAsync(string id, TaxFundGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TaxFund>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax_funds/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of tax funds in reverse chronological order.</p>.
        /// </summary>
        public virtual StripeList<TaxFund> List(TaxFundListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<TaxFund>>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax_funds", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of tax funds in reverse chronological order.</p>.
        /// </summary>
        public virtual Task<StripeList<TaxFund>> ListAsync(TaxFundListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<TaxFund>>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax_funds", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of tax funds in reverse chronological order.</p>.
        /// </summary>
        public virtual IEnumerable<TaxFund> ListAutoPaging(TaxFundListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<TaxFund>($"/v1/tax_funds", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of tax funds in reverse chronological order.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<TaxFund> ListAutoPagingAsync(TaxFundListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<TaxFund>($"/v1/tax_funds", options, requestOptions, cancellationToken);
        }
    }
}
