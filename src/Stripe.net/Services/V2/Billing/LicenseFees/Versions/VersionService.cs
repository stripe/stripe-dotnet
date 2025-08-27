// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.LicenseFees
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
        /// Retrieve a License Fee Version object.
        /// </summary>
        public virtual V2.Billing.LicenseFeeVersion Get(string parentId, string id, VersionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Billing.LicenseFeeVersion>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/license_fees/{WebUtility.UrlEncode(parentId)}/versions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a License Fee Version object.
        /// </summary>
        public virtual Task<V2.Billing.LicenseFeeVersion> GetAsync(string parentId, string id, VersionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Billing.LicenseFeeVersion>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/license_fees/{WebUtility.UrlEncode(parentId)}/versions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all versions of a License Fee object.
        /// </summary>
        public virtual V2.StripeList<V2.Billing.LicenseFeeVersion> List(string id, VersionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.Billing.LicenseFeeVersion>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/license_fees/{WebUtility.UrlEncode(id)}/versions", options, requestOptions);
        }

        /// <summary>
        /// List all versions of a License Fee object.
        /// </summary>
        public virtual Task<V2.StripeList<V2.Billing.LicenseFeeVersion>> ListAsync(string id, VersionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.Billing.LicenseFeeVersion>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/license_fees/{WebUtility.UrlEncode(id)}/versions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all versions of a License Fee object.
        /// </summary>
        public virtual IEnumerable<V2.Billing.LicenseFeeVersion> ListAutoPaging(string id, VersionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.Billing.LicenseFeeVersion>($"/v2/billing/license_fees/{WebUtility.UrlEncode(id)}/versions", options, requestOptions);
        }

        /// <summary>
        /// List all versions of a License Fee object.
        /// </summary>
        public virtual IAsyncEnumerable<V2.Billing.LicenseFeeVersion> ListAutoPagingAsync(string id, VersionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.Billing.LicenseFeeVersion>($"/v2/billing/license_fees/{WebUtility.UrlEncode(id)}/versions", options, requestOptions, cancellationToken);
        }
    }
}
