// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.CollectionSettings
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
        /// Retrieve a CollectionSetting Version by ID.
        /// </summary>
        public virtual V2.Billing.CollectionSettingVersion Get(string parentId, string id, VersionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Billing.CollectionSettingVersion>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/collection_settings/{WebUtility.UrlEncode(parentId)}/versions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a CollectionSetting Version by ID.
        /// </summary>
        public virtual Task<V2.Billing.CollectionSettingVersion> GetAsync(string parentId, string id, VersionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Billing.CollectionSettingVersion>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/collection_settings/{WebUtility.UrlEncode(parentId)}/versions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all CollectionSettingVersions by CollectionSetting ID.
        /// </summary>
        public virtual V2.StripeList<V2.Billing.CollectionSettingVersion> List(string id, VersionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.Billing.CollectionSettingVersion>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/collection_settings/{WebUtility.UrlEncode(id)}/versions", options, requestOptions);
        }

        /// <summary>
        /// List all CollectionSettingVersions by CollectionSetting ID.
        /// </summary>
        public virtual Task<V2.StripeList<V2.Billing.CollectionSettingVersion>> ListAsync(string id, VersionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.Billing.CollectionSettingVersion>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/collection_settings/{WebUtility.UrlEncode(id)}/versions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all CollectionSettingVersions by CollectionSetting ID.
        /// </summary>
        public virtual IEnumerable<V2.Billing.CollectionSettingVersion> ListAutoPaging(string id, VersionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.Billing.CollectionSettingVersion>($"/v2/billing/collection_settings/{WebUtility.UrlEncode(id)}/versions", options, requestOptions);
        }

        /// <summary>
        /// List all CollectionSettingVersions by CollectionSetting ID.
        /// </summary>
        public virtual IAsyncEnumerable<V2.Billing.CollectionSettingVersion> ListAutoPagingAsync(string id, VersionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.Billing.CollectionSettingVersion>($"/v2/billing/collection_settings/{WebUtility.UrlEncode(id)}/versions", options, requestOptions, cancellationToken);
        }
    }
}
