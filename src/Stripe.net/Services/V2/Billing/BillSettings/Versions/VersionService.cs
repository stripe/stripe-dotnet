// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.BillSettings
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
        /// Retrieve a BillSettingVersion by ID.
        /// </summary>
        public virtual V2.Billing.BillSettingVersion Get(string parentId, string id, VersionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Billing.BillSettingVersion>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/bill_settings/{WebUtility.UrlEncode(parentId)}/versions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a BillSettingVersion by ID.
        /// </summary>
        public virtual Task<V2.Billing.BillSettingVersion> GetAsync(string parentId, string id, VersionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Billing.BillSettingVersion>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/bill_settings/{WebUtility.UrlEncode(parentId)}/versions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all BillSettingVersions by BillSetting ID.
        /// </summary>
        public virtual V2.StripeList<V2.Billing.BillSettingVersion> List(string id, VersionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.Billing.BillSettingVersion>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/bill_settings/{WebUtility.UrlEncode(id)}/versions", options, requestOptions);
        }

        /// <summary>
        /// List all BillSettingVersions by BillSetting ID.
        /// </summary>
        public virtual Task<V2.StripeList<V2.Billing.BillSettingVersion>> ListAsync(string id, VersionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.Billing.BillSettingVersion>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/bill_settings/{WebUtility.UrlEncode(id)}/versions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all BillSettingVersions by BillSetting ID.
        /// </summary>
        public virtual IEnumerable<V2.Billing.BillSettingVersion> ListAutoPaging(string id, VersionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.Billing.BillSettingVersion>($"/v2/billing/bill_settings/{WebUtility.UrlEncode(id)}/versions", options, requestOptions);
        }

        /// <summary>
        /// List all BillSettingVersions by BillSetting ID.
        /// </summary>
        public virtual IAsyncEnumerable<V2.Billing.BillSettingVersion> ListAutoPagingAsync(string id, VersionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.Billing.BillSettingVersion>($"/v2/billing/bill_settings/{WebUtility.UrlEncode(id)}/versions", options, requestOptions, cancellationToken);
        }
    }
}
