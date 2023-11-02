// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TaxRateService : Service<TaxRate>,
        ICreatable<TaxRate, TaxRateCreateOptions>,
        IListable<TaxRate, TaxRateListOptions>,
        IRetrievable<TaxRate, TaxRateGetOptions>,
        IUpdatable<TaxRate, TaxRateUpdateOptions>
    {
        public TaxRateService()
            : base(null)
        {
        }

        public TaxRateService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/tax_rates";

        public virtual TaxRate Create(TaxRateCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<TaxRate>(HttpMethod.Post, $"/v1/tax_rates", options, requestOptions);
        }

        public virtual Task<TaxRate> CreateAsync(TaxRateCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TaxRate>(HttpMethod.Post, $"/v1/tax_rates", options, requestOptions, cancellationToken);
        }

        public virtual TaxRate Get(string id, TaxRateGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TaxRate>(HttpMethod.Get, $"/v1/tax_rates/{id}", options, requestOptions);
        }

        public virtual Task<TaxRate> GetAsync(string id, TaxRateGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TaxRate>(HttpMethod.Get, $"/v1/tax_rates/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<TaxRate> List(TaxRateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<TaxRate>>(HttpMethod.Get, $"/v1/tax_rates", options, requestOptions);
        }

        public virtual Task<StripeList<TaxRate>> ListAsync(TaxRateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<TaxRate>>(HttpMethod.Get, $"/v1/tax_rates", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<TaxRate> ListAutoPaging(TaxRateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<TaxRate>($"/v1/tax_rates", options, requestOptions);
        }

        public virtual IAsyncEnumerable<TaxRate> ListAutoPagingAsync(TaxRateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<TaxRate>($"/v1/tax_rates", options, requestOptions, cancellationToken);
        }

        public virtual TaxRate Update(string id, TaxRateUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<TaxRate>(HttpMethod.Post, $"/v1/tax_rates/{id}", options, requestOptions);
        }

        public virtual Task<TaxRate> UpdateAsync(string id, TaxRateUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TaxRate>(HttpMethod.Post, $"/v1/tax_rates/{id}", options, requestOptions, cancellationToken);
        }
    }
}
