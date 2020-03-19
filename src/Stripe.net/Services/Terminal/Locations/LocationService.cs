namespace Stripe.Terminal
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class LocationService : Service<Location>,
        ICreatable<Location, LocationCreateOptions>,
        IDeletable<Location, LocationDeleteOptions>,
        IListable<Location, LocationListOptions>,
        IRetrievable<Location, LocationGetOptions>,
        IUpdatable<Location, LocationUpdateOptions>
    {
        public LocationService()
            : base(null)
        {
        }

        public LocationService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/terminal/locations";

        public virtual Location Create(LocationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Location> CreateAsync(LocationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Location Delete(string locationId, LocationDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(locationId, options, requestOptions);
        }

        public virtual Task<Location> DeleteAsync(string locationId, LocationDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteEntityAsync(locationId, options, requestOptions, cancellationToken);
        }

        public virtual Location Get(string locationId, LocationGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(locationId, options, requestOptions);
        }

        public virtual Task<Location> GetAsync(string locationId, LocationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(locationId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Location> List(LocationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Location>> ListAsync(LocationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Location> ListAutoPaging(LocationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<Location> ListAutoPagingAsync(LocationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
#endif

        public virtual Location Update(string locationId, LocationUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(locationId, options, requestOptions);
        }

        public virtual Task<Location> UpdateAsync(string locationId, LocationUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(locationId, options, requestOptions, cancellationToken);
        }
    }
}
