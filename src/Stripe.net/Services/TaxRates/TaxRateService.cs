// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
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
        {
        }

        public TaxRateService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/tax_rates";

        /// <summary>
        /// <p>Creates a new tax rate.</p>.
        /// </summary>
        public virtual TaxRate Create(TaxRateCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<TaxRate>(HttpMethod.Post, $"/v1/tax_rates", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new tax rate.</p>.
        /// </summary>
        public virtual Task<TaxRate> CreateAsync(TaxRateCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TaxRate>(HttpMethod.Post, $"/v1/tax_rates", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a tax rate with the given ID</p>.
        /// </summary>
        public virtual TaxRate Get(string id, TaxRateGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TaxRate>(HttpMethod.Get, $"/v1/tax_rates/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a tax rate with the given ID</p>.
        /// </summary>
        public virtual Task<TaxRate> GetAsync(string id, TaxRateGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TaxRate>(HttpMethod.Get, $"/v1/tax_rates/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your tax rates. Tax rates are returned sorted by creation date,
        /// with the most recently created tax rates appearing first.</p>.
        /// </summary>
        public virtual StripeList<TaxRate> List(TaxRateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<TaxRate>>(HttpMethod.Get, $"/v1/tax_rates", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your tax rates. Tax rates are returned sorted by creation date,
        /// with the most recently created tax rates appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<TaxRate>> ListAsync(TaxRateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<TaxRate>>(HttpMethod.Get, $"/v1/tax_rates", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your tax rates. Tax rates are returned sorted by creation date,
        /// with the most recently created tax rates appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<TaxRate> ListAutoPaging(TaxRateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<TaxRate>($"/v1/tax_rates", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your tax rates. Tax rates are returned sorted by creation date,
        /// with the most recently created tax rates appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<TaxRate> ListAutoPagingAsync(TaxRateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<TaxRate>($"/v1/tax_rates", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates an existing tax rate.</p>.
        /// </summary>
        public virtual TaxRate Update(string id, TaxRateUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<TaxRate>(HttpMethod.Post, $"/v1/tax_rates/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates an existing tax rate.</p>.
        /// </summary>
        public virtual Task<TaxRate> UpdateAsync(string id, TaxRateUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TaxRate>(HttpMethod.Post, $"/v1/tax_rates/{id}", options, requestOptions, cancellationToken);
        }
    }
}
