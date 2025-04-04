// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TaxCodeService : Service,
        IListable<TaxCode, TaxCodeListOptions>,
        IRetrievable<TaxCode, TaxCodeGetOptions>
    {
        public TaxCodeService()
        {
        }

        internal TaxCodeService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public TaxCodeService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves the details of an existing tax code. Supply the unique tax code ID and
        /// Stripe will return the corresponding tax code information.</p>.
        /// </summary>
        public virtual TaxCode Get(string id, TaxCodeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TaxCode>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax_codes/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing tax code. Supply the unique tax code ID and
        /// Stripe will return the corresponding tax code information.</p>.
        /// </summary>
        public virtual Task<TaxCode> GetAsync(string id, TaxCodeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TaxCode>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax_codes/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>A list of <a href="https://stripe.com/docs/tax/tax-categories">all tax codes
        /// available</a> to add to Products in order to allow specific tax calculations.</p>.
        /// </summary>
        public virtual StripeList<TaxCode> List(TaxCodeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<TaxCode>>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax_codes", options, requestOptions);
        }

        /// <summary>
        /// <p>A list of <a href="https://stripe.com/docs/tax/tax-categories">all tax codes
        /// available</a> to add to Products in order to allow specific tax calculations.</p>.
        /// </summary>
        public virtual Task<StripeList<TaxCode>> ListAsync(TaxCodeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<TaxCode>>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax_codes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>A list of <a href="https://stripe.com/docs/tax/tax-categories">all tax codes
        /// available</a> to add to Products in order to allow specific tax calculations.</p>.
        /// </summary>
        public virtual IEnumerable<TaxCode> ListAutoPaging(TaxCodeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<TaxCode>($"/v1/tax_codes", options, requestOptions);
        }

        /// <summary>
        /// <p>A list of <a href="https://stripe.com/docs/tax/tax-categories">all tax codes
        /// available</a> to add to Products in order to allow specific tax calculations.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<TaxCode> ListAutoPagingAsync(TaxCodeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<TaxCode>($"/v1/tax_codes", options, requestOptions, cancellationToken);
        }
    }
}
