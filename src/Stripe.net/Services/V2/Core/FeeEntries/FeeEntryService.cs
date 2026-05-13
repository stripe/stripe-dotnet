// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class FeeEntryService : Service
    {
        internal FeeEntryService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal FeeEntryService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieve a FeeEntry by id.
        /// </summary>
        public virtual FeeEntry Get(string id, FeeEntryGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FeeEntry>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/fee_entries/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a FeeEntry by id.
        /// </summary>
        public virtual Task<FeeEntry> GetAsync(string id, FeeEntryGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FeeEntry>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/fee_entries/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List FeeEntries optionally filtered by incurred_by, fee_batch, or collection_record (at
        /// most one filter at a time).
        /// </summary>
        public virtual V2.StripeList<FeeEntry> List(FeeEntryListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<FeeEntry>>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/fee_entries", options, requestOptions);
        }

        /// <summary>
        /// List FeeEntries optionally filtered by incurred_by, fee_batch, or collection_record (at
        /// most one filter at a time).
        /// </summary>
        public virtual Task<V2.StripeList<FeeEntry>> ListAsync(FeeEntryListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<FeeEntry>>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/fee_entries", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List FeeEntries optionally filtered by incurred_by, fee_batch, or collection_record (at
        /// most one filter at a time).
        /// </summary>
        public virtual IEnumerable<FeeEntry> ListAutoPaging(FeeEntryListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<FeeEntry>($"/v2/core/fee_entries", options, requestOptions);
        }

        /// <summary>
        /// List FeeEntries optionally filtered by incurred_by, fee_batch, or collection_record (at
        /// most one filter at a time).
        /// </summary>
        public virtual IAsyncEnumerable<FeeEntry> ListAutoPagingAsync(FeeEntryListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<FeeEntry>($"/v2/core/fee_entries", options, requestOptions, cancellationToken);
        }
    }
}
