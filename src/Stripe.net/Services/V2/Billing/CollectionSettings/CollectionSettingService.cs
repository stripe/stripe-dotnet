// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CollectionSettingService : Service
    {
        private V2.Billing.CollectionSettings.VersionService versions;

        internal CollectionSettingService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal CollectionSettingService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Billing.CollectionSettings.VersionService Versions => this.versions ??= new V2.Billing.CollectionSettings.VersionService(
            this.Requestor);

        /// <summary>
        /// Create a CollectionSetting object.
        /// </summary>
        public virtual CollectionSetting Create(CollectionSettingCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CollectionSetting>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/collection_settings", options, requestOptions);
        }

        /// <summary>
        /// Create a CollectionSetting object.
        /// </summary>
        public virtual Task<CollectionSetting> CreateAsync(CollectionSettingCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CollectionSetting>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/collection_settings", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a CollectionSetting by ID.
        /// </summary>
        public virtual CollectionSetting Get(string id, CollectionSettingGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CollectionSetting>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/collection_settings/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a CollectionSetting by ID.
        /// </summary>
        public virtual Task<CollectionSetting> GetAsync(string id, CollectionSettingGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CollectionSetting>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/collection_settings/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all CollectionSetting objects.
        /// </summary>
        public virtual V2.StripeList<CollectionSetting> List(CollectionSettingListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<CollectionSetting>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/collection_settings", options, requestOptions);
        }

        /// <summary>
        /// List all CollectionSetting objects.
        /// </summary>
        public virtual Task<V2.StripeList<CollectionSetting>> ListAsync(CollectionSettingListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<CollectionSetting>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/collection_settings", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all CollectionSetting objects.
        /// </summary>
        public virtual IEnumerable<CollectionSetting> ListAutoPaging(CollectionSettingListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CollectionSetting>($"/v2/billing/collection_settings", options, requestOptions);
        }

        /// <summary>
        /// List all CollectionSetting objects.
        /// </summary>
        public virtual IAsyncEnumerable<CollectionSetting> ListAutoPagingAsync(CollectionSettingListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CollectionSetting>($"/v2/billing/collection_settings", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Update fields on an existing CollectionSetting.
        /// </summary>
        public virtual CollectionSetting Update(string id, CollectionSettingUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CollectionSetting>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/collection_settings/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Update fields on an existing CollectionSetting.
        /// </summary>
        public virtual Task<CollectionSetting> UpdateAsync(string id, CollectionSettingUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CollectionSetting>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/collection_settings/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
