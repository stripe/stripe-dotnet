// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SchemaService : Service
    {
        internal SchemaService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal SchemaService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieves the schema for a particular table.
        /// </summary>
        public virtual Schema Get(string id, SchemaGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Schema>(BaseAddress.Api, HttpMethod.Get, $"/v2/data/schemas/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the schema for a particular table.
        /// </summary>
        public virtual Task<Schema> GetAsync(string id, SchemaGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Schema>(BaseAddress.Api, HttpMethod.Get, $"/v2/data/schemas/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of schemas describing the tables available to query.
        /// </summary>
        public virtual V2.StripeList<Schema> List(SchemaListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<Schema>>(BaseAddress.Api, HttpMethod.Get, $"/v2/data/schemas", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of schemas describing the tables available to query.
        /// </summary>
        public virtual Task<V2.StripeList<Schema>> ListAsync(SchemaListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<Schema>>(BaseAddress.Api, HttpMethod.Get, $"/v2/data/schemas", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of schemas describing the tables available to query.
        /// </summary>
        public virtual IEnumerable<Schema> ListAutoPaging(SchemaListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Schema>($"/v2/data/schemas", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of schemas describing the tables available to query.
        /// </summary>
        public virtual IAsyncEnumerable<Schema> ListAutoPagingAsync(SchemaListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Schema>($"/v2/data/schemas", options, requestOptions, cancellationToken);
        }
    }
}
