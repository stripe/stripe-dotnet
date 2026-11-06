// File generated from our OpenAPI spec
namespace Stripe.V2.Extend
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ObjectDefinitionService : Service
    {
        private V2.Extend.ObjectDefinitions.VersionService versions;

        internal ObjectDefinitionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ObjectDefinitionService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Extend.ObjectDefinitions.VersionService Versions => this.versions ??= new V2.Extend.ObjectDefinitions.VersionService(
            this.Requestor);

        /// <summary>
        /// Retrieves an object definition.
        /// </summary>
        public virtual ObjectDefinition Get(string id, ObjectDefinitionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ObjectDefinition>(BaseAddress.Api, HttpMethod.Get, $"/v2/extend/object_definitions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves an object definition.
        /// </summary>
        public virtual Task<ObjectDefinition> GetAsync(string id, ObjectDefinitionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ObjectDefinition>(BaseAddress.Api, HttpMethod.Get, $"/v2/extend/object_definitions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Lists a page of object definitions.
        /// </summary>
        public virtual V2.StripeList<ObjectDefinition> List(ObjectDefinitionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<ObjectDefinition>>(BaseAddress.Api, HttpMethod.Get, $"/v2/extend/object_definitions", options, requestOptions);
        }

        /// <summary>
        /// Lists a page of object definitions.
        /// </summary>
        public virtual Task<V2.StripeList<ObjectDefinition>> ListAsync(ObjectDefinitionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<ObjectDefinition>>(BaseAddress.Api, HttpMethod.Get, $"/v2/extend/object_definitions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Lists a page of object definitions.
        /// </summary>
        public virtual IEnumerable<ObjectDefinition> ListAutoPaging(ObjectDefinitionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ObjectDefinition>($"/v2/extend/object_definitions", options, requestOptions);
        }

        /// <summary>
        /// Lists a page of object definitions.
        /// </summary>
        public virtual IAsyncEnumerable<ObjectDefinition> ListAutoPagingAsync(ObjectDefinitionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ObjectDefinition>($"/v2/extend/object_definitions", options, requestOptions, cancellationToken);
        }
    }
}
