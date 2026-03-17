// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class LocationService : Service,
        ICreatable<Location, LocationCreateOptions>,
        IListable<Location, LocationListOptions>,
        IRetrievable<Location, LocationGetOptions>
    {
        public LocationService()
        {
        }

        internal LocationService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public LocationService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Create a tax location to use in calculating taxes for a service, ticket, or other
        /// type of product. The resulting object contains the id, address, name, description, and
        /// current operational status of the tax location.</p>.
        /// </summary>
        public virtual Location Create(LocationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Location>(BaseAddress.Api, HttpMethod.Post, $"/v1/tax/locations", options, requestOptions);
        }

        /// <summary>
        /// <p>Create a tax location to use in calculating taxes for a service, ticket, or other
        /// type of product. The resulting object contains the id, address, name, description, and
        /// current operational status of the tax location.</p>.
        /// </summary>
        public virtual Task<Location> CreateAsync(LocationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Location>(BaseAddress.Api, HttpMethod.Post, $"/v1/tax/locations", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Fetch the details of a specific tax location using its unique identifier. Use a tax
        /// location to calculate taxes based on the location of the end product, such as a
        /// performance, instead of the customer address. For more details, check the <a
        /// href="https://docs.stripe.com/tax/tax-for-tickets/integration-guide">integration
        /// guide</a>.</p>.
        /// </summary>
        public virtual Location Get(string id, LocationGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Location>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/locations/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Fetch the details of a specific tax location using its unique identifier. Use a tax
        /// location to calculate taxes based on the location of the end product, such as a
        /// performance, instead of the customer address. For more details, check the <a
        /// href="https://docs.stripe.com/tax/tax-for-tickets/integration-guide">integration
        /// guide</a>.</p>.
        /// </summary>
        public virtual Task<Location> GetAsync(string id, LocationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Location>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/locations/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a list of all tax locations. Tax locations can represent the venues for
        /// services, tickets, or other product types.</p>.
        ///
        /// <p>The response includes detailed information for each tax location, such as its
        /// address, name, description, and current operational status.</p>.
        ///
        /// <p>You can paginate through the list by using the <c>limit</c> parameter to control the
        /// number of results returned in each request.</p>.
        /// </summary>
        public virtual StripeList<Location> List(LocationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Location>>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/locations", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a list of all tax locations. Tax locations can represent the venues for
        /// services, tickets, or other product types.</p>.
        ///
        /// <p>The response includes detailed information for each tax location, such as its
        /// address, name, description, and current operational status.</p>.
        ///
        /// <p>You can paginate through the list by using the <c>limit</c> parameter to control the
        /// number of results returned in each request.</p>.
        /// </summary>
        public virtual Task<StripeList<Location>> ListAsync(LocationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Location>>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/locations", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a list of all tax locations. Tax locations can represent the venues for
        /// services, tickets, or other product types.</p>.
        ///
        /// <p>The response includes detailed information for each tax location, such as its
        /// address, name, description, and current operational status.</p>.
        ///
        /// <p>You can paginate through the list by using the <c>limit</c> parameter to control the
        /// number of results returned in each request.</p>.
        /// </summary>
        public virtual IEnumerable<Location> ListAutoPaging(LocationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Location>($"/v1/tax/locations", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a list of all tax locations. Tax locations can represent the venues for
        /// services, tickets, or other product types.</p>.
        ///
        /// <p>The response includes detailed information for each tax location, such as its
        /// address, name, description, and current operational status.</p>.
        ///
        /// <p>You can paginate through the list by using the <c>limit</c> parameter to control the
        /// number of results returned in each request.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Location> ListAutoPagingAsync(LocationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Location>($"/v1/tax/locations", options, requestOptions, cancellationToken);
        }
    }
}
