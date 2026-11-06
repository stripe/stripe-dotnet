// File generated from our OpenAPI spec
namespace Stripe.V2.Extend.ObjectDefinitions
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class VersionService : Service
    {
        internal VersionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal VersionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieves an object definition version.
        /// </summary>
        public virtual V2.Extend.ObjectDefinitionVersion Get(string parentId, string id, VersionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Extend.ObjectDefinitionVersion>(BaseAddress.Api, HttpMethod.Get, $"/v2/extend/object_definitions/{WebUtility.UrlEncode(parentId)}/versions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves an object definition version.
        /// </summary>
        public virtual Task<V2.Extend.ObjectDefinitionVersion> GetAsync(string parentId, string id, VersionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Extend.ObjectDefinitionVersion>(BaseAddress.Api, HttpMethod.Get, $"/v2/extend/object_definitions/{WebUtility.UrlEncode(parentId)}/versions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Lists a page of object definition versions in descending semantic version order.
        /// </summary>
        public virtual V2.StripeList<V2.Extend.ObjectDefinitionVersion> List(string id, VersionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.Extend.ObjectDefinitionVersion>>(BaseAddress.Api, HttpMethod.Get, $"/v2/extend/object_definitions/{WebUtility.UrlEncode(id)}/versions", options, requestOptions);
        }

        /// <summary>
        /// Lists a page of object definition versions in descending semantic version order.
        /// </summary>
        public virtual Task<V2.StripeList<V2.Extend.ObjectDefinitionVersion>> ListAsync(string id, VersionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.Extend.ObjectDefinitionVersion>>(BaseAddress.Api, HttpMethod.Get, $"/v2/extend/object_definitions/{WebUtility.UrlEncode(id)}/versions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Lists a page of object definition versions in descending semantic version order.
        /// </summary>
        public virtual IEnumerable<V2.Extend.ObjectDefinitionVersion> ListAutoPaging(string id, VersionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.Extend.ObjectDefinitionVersion>($"/v2/extend/object_definitions/{WebUtility.UrlEncode(id)}/versions", options, requestOptions);
        }

        /// <summary>
        /// Lists a page of object definition versions in descending semantic version order.
        /// </summary>
        public virtual IAsyncEnumerable<V2.Extend.ObjectDefinitionVersion> ListAutoPagingAsync(string id, VersionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.Extend.ObjectDefinitionVersion>($"/v2/extend/object_definitions/{WebUtility.UrlEncode(id)}/versions", options, requestOptions, cancellationToken);
        }
    }
}
