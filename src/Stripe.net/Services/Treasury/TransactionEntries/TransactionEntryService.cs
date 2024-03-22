// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TransactionEntryService : Service<TransactionEntry>,
        IListable<TransactionEntry, TransactionEntryListOptions>,
        IRetrievable<TransactionEntry, TransactionEntryGetOptions>
    {
        public TransactionEntryService()
        {
        }

        public TransactionEntryService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/treasury/transaction_entries";

        /// <summary>
        /// <p>Retrieves a TransactionEntry object.</p>.
        /// </summary>
        public virtual TransactionEntry Get(string id, TransactionEntryGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TransactionEntry>(HttpMethod.Get, $"/v1/treasury/transaction_entries/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a TransactionEntry object.</p>.
        /// </summary>
        public virtual Task<TransactionEntry> GetAsync(string id, TransactionEntryGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TransactionEntry>(HttpMethod.Get, $"/v1/treasury/transaction_entries/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a list of TransactionEntry objects.</p>.
        /// </summary>
        public virtual StripeList<TransactionEntry> List(TransactionEntryListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<TransactionEntry>>(HttpMethod.Get, $"/v1/treasury/transaction_entries", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a list of TransactionEntry objects.</p>.
        /// </summary>
        public virtual Task<StripeList<TransactionEntry>> ListAsync(TransactionEntryListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<TransactionEntry>>(HttpMethod.Get, $"/v1/treasury/transaction_entries", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a list of TransactionEntry objects.</p>.
        /// </summary>
        public virtual IEnumerable<TransactionEntry> ListAutoPaging(TransactionEntryListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<TransactionEntry>($"/v1/treasury/transaction_entries", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a list of TransactionEntry objects.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<TransactionEntry> ListAutoPagingAsync(TransactionEntryListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<TransactionEntry>($"/v1/treasury/transaction_entries", options, requestOptions, cancellationToken);
        }
    }
}
