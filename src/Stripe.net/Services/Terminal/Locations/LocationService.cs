namespace Stripe.Terminal
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class LocationService : Service<Location>,
        ICreatable<Location, LocationCreateOptions>
    {
        public LocationService()
            : base(null)
        {
        }

        public LocationService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/terminal/locations";

        public virtual Location Create(LocationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Location> CreateAsync(LocationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Location Delete(string locationId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(locationId, null, requestOptions);
        }

        public virtual Task<Location> DeleteAsync(string locationId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync(locationId, null, requestOptions, cancellationToken);
        }

        public virtual Location Get(string locationId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(locationId, null, requestOptions);
        }

        public virtual Task<Location> GetAsync(string locationId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(locationId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<Location> List(LocationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Location>> ListAsync(LocationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual Location Update(string locationId, LocationUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(locationId, options, requestOptions);
        }

        public virtual Task<Location> UpdateAsync(string locationId, LocationUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(locationId, options, requestOptions, cancellationToken);
        }
    }
}
