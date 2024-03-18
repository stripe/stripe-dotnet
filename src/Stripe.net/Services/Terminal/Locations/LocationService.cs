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
        {
        }

        public LocationService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/terminal/locations";

        /// <summary>
        /// <p>Creates a new <c>Location</c> object. For further details, including which address
        /// fields are required in each country, see the <a
        /// href="https://stripe.com/docs/terminal/fleet/locations">Manage locations</a> guide.</p>.
        /// </summary>
        public virtual Location Create(LocationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Location>(HttpMethod.Post, $"/v1/terminal/locations", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new <c>Location</c> object. For further details, including which address
        /// fields are required in each country, see the <a
        /// href="https://stripe.com/docs/terminal/fleet/locations">Manage locations</a> guide.</p>.
        /// </summary>
        public virtual Task<Location> CreateAsync(LocationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Location>(HttpMethod.Post, $"/v1/terminal/locations", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Deletes a <c>Location</c> object.</p>.
        /// </summary>
        public virtual Location Delete(string id, LocationDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Location>(HttpMethod.Delete, $"/v1/terminal/locations/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Deletes a <c>Location</c> object.</p>.
        /// </summary>
        public virtual Task<Location> DeleteAsync(string id, LocationDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Location>(HttpMethod.Delete, $"/v1/terminal/locations/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a <c>Location</c> object.</p>.
        /// </summary>
        public virtual Location Get(string id, LocationGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Location>(HttpMethod.Get, $"/v1/terminal/locations/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a <c>Location</c> object.</p>.
        /// </summary>
        public virtual Task<Location> GetAsync(string id, LocationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Location>(HttpMethod.Get, $"/v1/terminal/locations/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of <c>Location</c> objects.</p>.
        /// </summary>
        public virtual StripeList<Location> List(LocationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Location>>(HttpMethod.Get, $"/v1/terminal/locations", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of <c>Location</c> objects.</p>.
        /// </summary>
        public virtual Task<StripeList<Location>> ListAsync(LocationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Location>>(HttpMethod.Get, $"/v1/terminal/locations", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of <c>Location</c> objects.</p>.
        /// </summary>
        public virtual IEnumerable<Location> ListAutoPaging(LocationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Location>($"/v1/terminal/locations", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of <c>Location</c> objects.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Location> ListAutoPagingAsync(LocationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Location>($"/v1/terminal/locations", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates a <c>Location</c> object by setting the values of the parameters passed. Any
        /// parameters not provided will be left unchanged.</p>.
        /// </summary>
        public virtual Location Update(string id, LocationUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Location>(HttpMethod.Post, $"/v1/terminal/locations/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates a <c>Location</c> object by setting the values of the parameters passed. Any
        /// parameters not provided will be left unchanged.</p>.
        /// </summary>
        public virtual Task<Location> UpdateAsync(string id, LocationUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Location>(HttpMethod.Post, $"/v1/terminal/locations/{id}", options, requestOptions, cancellationToken);
        }
    }
}
