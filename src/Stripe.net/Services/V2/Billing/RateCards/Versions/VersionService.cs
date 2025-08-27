// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.RateCards
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
        /// Retrieve a specific version of a Rate Card object.
        /// </summary>
        public virtual V2.Billing.RateCardVersion Get(string parentId, string id, VersionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Billing.RateCardVersion>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/rate_cards/{WebUtility.UrlEncode(parentId)}/versions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a specific version of a Rate Card object.
        /// </summary>
        public virtual Task<V2.Billing.RateCardVersion> GetAsync(string parentId, string id, VersionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Billing.RateCardVersion>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/rate_cards/{WebUtility.UrlEncode(parentId)}/versions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List the versions of a Rate Card object. Results are sorted in reverse chronological
        /// order (most recent first).
        /// </summary>
        public virtual V2.StripeList<V2.Billing.RateCardVersion> List(string id, VersionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.Billing.RateCardVersion>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/rate_cards/{WebUtility.UrlEncode(id)}/versions", options, requestOptions);
        }

        /// <summary>
        /// List the versions of a Rate Card object. Results are sorted in reverse chronological
        /// order (most recent first).
        /// </summary>
        public virtual Task<V2.StripeList<V2.Billing.RateCardVersion>> ListAsync(string id, VersionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.Billing.RateCardVersion>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/rate_cards/{WebUtility.UrlEncode(id)}/versions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List the versions of a Rate Card object. Results are sorted in reverse chronological
        /// order (most recent first).
        /// </summary>
        public virtual IEnumerable<V2.Billing.RateCardVersion> ListAutoPaging(string id, VersionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.Billing.RateCardVersion>($"/v2/billing/rate_cards/{WebUtility.UrlEncode(id)}/versions", options, requestOptions);
        }

        /// <summary>
        /// List the versions of a Rate Card object. Results are sorted in reverse chronological
        /// order (most recent first).
        /// </summary>
        public virtual IAsyncEnumerable<V2.Billing.RateCardVersion> ListAutoPagingAsync(string id, VersionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.Billing.RateCardVersion>($"/v2/billing/rate_cards/{WebUtility.UrlEncode(id)}/versions", options, requestOptions, cancellationToken);
        }
    }
}
