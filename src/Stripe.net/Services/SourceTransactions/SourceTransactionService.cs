// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class SourceTransactionService : ServiceNested<SourceTransaction>,
        INestedListable<SourceTransaction, SourceTransactionListOptions>
    {
        public SourceTransactionService()
        {
        }

        internal SourceTransactionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public SourceTransactionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>List source transactions for a given source.</p>.
        /// </summary>
        public virtual StripeList<SourceTransaction> List(string parentId, SourceTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<SourceTransaction>>(BaseAddress.Api, HttpMethod.Get, $"/v1/sources/{WebUtility.UrlEncode(parentId)}/source_transactions", options, requestOptions);
        }

        /// <summary>
        /// <p>List source transactions for a given source.</p>.
        /// </summary>
        public virtual Task<StripeList<SourceTransaction>> ListAsync(string parentId, SourceTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<SourceTransaction>>(BaseAddress.Api, HttpMethod.Get, $"/v1/sources/{WebUtility.UrlEncode(parentId)}/source_transactions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List source transactions for a given source.</p>.
        /// </summary>
        public virtual IEnumerable<SourceTransaction> ListAutoPaging(string parentId, SourceTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<SourceTransaction>($"/v1/sources/{WebUtility.UrlEncode(parentId)}/source_transactions", options, requestOptions);
        }

        /// <summary>
        /// <p>List source transactions for a given source.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<SourceTransaction> ListAutoPagingAsync(string parentId, SourceTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<SourceTransaction>($"/v1/sources/{WebUtility.UrlEncode(parentId)}/source_transactions", options, requestOptions, cancellationToken);
        }
    }
}
