// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class ShippingRateService : Service<ShippingRate>,
        ICreatable<ShippingRate, ShippingRateCreateOptions>,
        IListable<ShippingRate, ShippingRateListOptions>,
        IRetrievable<ShippingRate, ShippingRateGetOptions>,
        IUpdatable<ShippingRate, ShippingRateUpdateOptions>
    {
        public ShippingRateService()
            : base(null)
        {
        }

        public ShippingRateService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/shipping_rates";

        public virtual ShippingRate Create(ShippingRateCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<ShippingRate> CreateAsync(ShippingRateCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual ShippingRate Get(string id, ShippingRateGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<ShippingRate> GetAsync(string id, ShippingRateGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<ShippingRate> List(ShippingRateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<ShippingRate>> ListAsync(ShippingRateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<ShippingRate> ListAutoPaging(ShippingRateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<ShippingRate> ListAutoPagingAsync(ShippingRateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }

        public virtual ShippingRate Update(string id, ShippingRateUpdateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<ShippingRate> UpdateAsync(string id, ShippingRateUpdateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
