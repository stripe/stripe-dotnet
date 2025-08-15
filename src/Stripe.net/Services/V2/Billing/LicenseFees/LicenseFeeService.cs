// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class LicenseFeeService : Service
    {
        private V2.Billing.LicenseFees.VersionService versions;

        internal LicenseFeeService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal LicenseFeeService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Billing.LicenseFees.VersionService Versions => this.versions ??= new V2.Billing.LicenseFees.VersionService(
            this.Requestor);

        /// <summary>
        /// Create a LicenseFee object.
        /// </summary>
        public virtual LicenseFee Create(LicenseFeeCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<LicenseFee>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/license_fees", options, requestOptions);
        }

        /// <summary>
        /// Create a LicenseFee object.
        /// </summary>
        public virtual Task<LicenseFee> CreateAsync(LicenseFeeCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<LicenseFee>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/license_fees", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a LicenseFee object.
        /// </summary>
        public virtual LicenseFee Get(string id, LicenseFeeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<LicenseFee>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/license_fees/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a LicenseFee object.
        /// </summary>
        public virtual Task<LicenseFee> GetAsync(string id, LicenseFeeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<LicenseFee>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/license_fees/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all LicenseFee objects.
        /// </summary>
        public virtual V2.StripeList<LicenseFee> List(LicenseFeeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<LicenseFee>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/license_fees", options, requestOptions);
        }

        /// <summary>
        /// List all LicenseFee objects.
        /// </summary>
        public virtual Task<V2.StripeList<LicenseFee>> ListAsync(LicenseFeeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<LicenseFee>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/license_fees", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all LicenseFee objects.
        /// </summary>
        public virtual IEnumerable<LicenseFee> ListAutoPaging(LicenseFeeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<LicenseFee>($"/v2/billing/license_fees", options, requestOptions);
        }

        /// <summary>
        /// List all LicenseFee objects.
        /// </summary>
        public virtual IAsyncEnumerable<LicenseFee> ListAutoPagingAsync(LicenseFeeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<LicenseFee>($"/v2/billing/license_fees", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Update a LicenseFee object.
        /// </summary>
        public virtual LicenseFee Update(string id, LicenseFeeUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<LicenseFee>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/license_fees/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Update a LicenseFee object.
        /// </summary>
        public virtual Task<LicenseFee> UpdateAsync(string id, LicenseFeeUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<LicenseFee>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/license_fees/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
