namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SourceTransactionService : ServiceNested<SourceTransaction>,
        INestedListable<SourceTransaction, SourceTransactionsListOptions>
    {
        public SourceTransactionService()
            : base(null)
        {
        }

        public SourceTransactionService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/sources/{PARENT_ID}/source_transactions";

        public virtual StripeList<SourceTransaction> List(string sourceId, SourceTransactionsListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<SourceTransaction>>(HttpMethod.Get, $"/v1/sources/{sourceId}/source_transactions", options, requestOptions);
        }

        public virtual Task<StripeList<SourceTransaction>> ListAsync(string sourceId, SourceTransactionsListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<SourceTransaction>>(HttpMethod.Get, $"/v1/sources/{sourceId}/source_transactions", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<SourceTransaction> ListAutoPaging(string sourceId, SourceTransactionsListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<SourceTransaction>($"/v1/sources/{sourceId}/source_transactions", options, requestOptions);
        }

        public virtual IAsyncEnumerable<SourceTransaction> ListAutoPagingAsync(string sourceId, SourceTransactionsListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<SourceTransaction>($"/v1/sources/{sourceId}/source_transactions", options, requestOptions, cancellationToken);
        }
    }
}
