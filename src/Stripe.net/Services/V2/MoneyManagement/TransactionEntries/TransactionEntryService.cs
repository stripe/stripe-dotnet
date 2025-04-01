// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TransactionEntryService : Service
    {
        internal TransactionEntryService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal TransactionEntryService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieves the details of a TransactionEntry by ID.
        /// </summary>
        public virtual TransactionEntry Get(string id, TransactionEntryGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TransactionEntry>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/transaction_entries/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the details of a TransactionEntry by ID.
        /// </summary>
        public virtual Task<TransactionEntry> GetAsync(string id, TransactionEntryGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TransactionEntry>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/transaction_entries/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of TransactionEntries that match the provided filters.
        /// </summary>
        public virtual V2.StripeList<TransactionEntry> List(TransactionEntryListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<TransactionEntry>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/transaction_entries", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of TransactionEntries that match the provided filters.
        /// </summary>
        public virtual Task<V2.StripeList<TransactionEntry>> ListAsync(TransactionEntryListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<TransactionEntry>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/transaction_entries", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of TransactionEntries that match the provided filters.
        /// </summary>
        public virtual IEnumerable<TransactionEntry> ListAutoPaging(TransactionEntryListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<TransactionEntry>($"/v2/money_management/transaction_entries", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of TransactionEntries that match the provided filters.
        /// </summary>
        public virtual IAsyncEnumerable<TransactionEntry> ListAutoPagingAsync(TransactionEntryListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<TransactionEntry>($"/v2/money_management/transaction_entries", options, requestOptions, cancellationToken);
        }
    }
}
