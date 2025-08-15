// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class BillSettingService : Service
    {
        private V2.Billing.BillSettings.VersionService versions;

        internal BillSettingService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal BillSettingService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Billing.BillSettings.VersionService Versions => this.versions ??= new V2.Billing.BillSettings.VersionService(
            this.Requestor);

        /// <summary>
        /// Create a BillSetting object.
        /// </summary>
        public virtual BillSetting Create(BillSettingCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<BillSetting>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/bill_settings", options, requestOptions);
        }

        /// <summary>
        /// Create a BillSetting object.
        /// </summary>
        public virtual Task<BillSetting> CreateAsync(BillSettingCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BillSetting>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/bill_settings", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a BillSetting object by ID.
        /// </summary>
        public virtual BillSetting Get(string id, BillSettingGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<BillSetting>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/bill_settings/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a BillSetting object by ID.
        /// </summary>
        public virtual Task<BillSetting> GetAsync(string id, BillSettingGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BillSetting>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/bill_settings/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all BillSetting objects.
        /// </summary>
        public virtual V2.StripeList<BillSetting> List(BillSettingListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<BillSetting>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/bill_settings", options, requestOptions);
        }

        /// <summary>
        /// List all BillSetting objects.
        /// </summary>
        public virtual Task<V2.StripeList<BillSetting>> ListAsync(BillSettingListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<BillSetting>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/bill_settings", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all BillSetting objects.
        /// </summary>
        public virtual IEnumerable<BillSetting> ListAutoPaging(BillSettingListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<BillSetting>($"/v2/billing/bill_settings", options, requestOptions);
        }

        /// <summary>
        /// List all BillSetting objects.
        /// </summary>
        public virtual IAsyncEnumerable<BillSetting> ListAutoPagingAsync(BillSettingListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<BillSetting>($"/v2/billing/bill_settings", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Update fields on an existing BillSetting object.
        /// </summary>
        public virtual BillSetting Update(string id, BillSettingUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<BillSetting>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/bill_settings/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Update fields on an existing BillSetting object.
        /// </summary>
        public virtual Task<BillSetting> UpdateAsync(string id, BillSettingUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BillSetting>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/bill_settings/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
