// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

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

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/terminal/locations";

        public virtual Location Create(LocationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Location>(HttpMethod.Post, $"/v1/terminal/locations", options, requestOptions);
        }

        public virtual Task<Location> CreateAsync(LocationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Location>(HttpMethod.Post, $"/v1/terminal/locations", options, requestOptions, cancellationToken);
        }

        public virtual Location Delete(string id, LocationDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Location>(HttpMethod.Delete, $"/v1/terminal/locations/{id}", options, requestOptions);
        }

        public virtual Task<Location> DeleteAsync(string id, LocationDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Location>(HttpMethod.Delete, $"/v1/terminal/locations/{id}", options, requestOptions, cancellationToken);
        }

        public virtual Location Get(string id, LocationGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Location>(HttpMethod.Get, $"/v1/terminal/locations/{id}", options, requestOptions);
        }

        public virtual Task<Location> GetAsync(string id, LocationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Location>(HttpMethod.Get, $"/v1/terminal/locations/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Location> List(LocationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Location>>(HttpMethod.Get, $"/v1/terminal/locations", options, requestOptions);
        }

        public virtual Task<StripeList<Location>> ListAsync(LocationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Location>>(HttpMethod.Get, $"/v1/terminal/locations", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Location> ListAutoPaging(LocationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Location>($"/v1/terminal/locations", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Location> ListAutoPagingAsync(LocationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Location>($"/v1/terminal/locations", options, requestOptions, cancellationToken);
        }

        public virtual Location Update(string id, LocationUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Location>(HttpMethod.Post, $"/v1/terminal/locations/{id}", options, requestOptions);
        }

        public virtual Task<Location> UpdateAsync(string id, LocationUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Location>(HttpMethod.Post, $"/v1/terminal/locations/{id}", options, requestOptions, cancellationToken);
        }
    }
}
