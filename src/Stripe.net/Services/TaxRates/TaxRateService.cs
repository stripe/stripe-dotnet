namespace Stripe
{
    using System.Collections.Generic;
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
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<TaxRate> CreateAsync(TaxRateCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual TaxRate Get(string id, TaxRateGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<TaxRate> GetAsync(string id, TaxRateGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<TaxRate> List(TaxRateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<TaxRate>> ListAsync(TaxRateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<TaxRate> ListAutoPaging(TaxRateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<TaxRate> ListAutoPagingAsync(TaxRateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
#endif

        public virtual TaxRate Update(string id, TaxRateUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<TaxRate> UpdateAsync(string id, TaxRateUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
