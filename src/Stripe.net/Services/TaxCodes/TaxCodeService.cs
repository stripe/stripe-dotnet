// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TaxCodeService : Service<TaxCode>,
        IListable<TaxCode, TaxCodeListOptions>,
        IRetrievable<TaxCode, TaxCodeGetOptions>
    {
        public TaxCodeService()
            : base(null)
        {
        }

        public TaxCodeService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/tax_codes";

        public virtual TaxCode Get(string id, TaxCodeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TaxCode>(HttpMethod.Get, $"/v1/tax_codes/{id}", options, requestOptions);
        }

        public virtual Task<TaxCode> GetAsync(string id, TaxCodeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TaxCode>(HttpMethod.Get, $"/v1/tax_codes/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<TaxCode> List(TaxCodeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<TaxCode>>(HttpMethod.Get, $"/v1/tax_codes", options, requestOptions);
        }

        public virtual Task<StripeList<TaxCode>> ListAsync(TaxCodeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<TaxCode>>(HttpMethod.Get, $"/v1/tax_codes", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<TaxCode> ListAutoPaging(TaxCodeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<TaxCode>($"/v1/tax_codes", options, requestOptions);
        }

        public virtual IAsyncEnumerable<TaxCode> ListAutoPagingAsync(TaxCodeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<TaxCode>($"/v1/tax_codes", options, requestOptions, cancellationToken);
        }
    }
}
