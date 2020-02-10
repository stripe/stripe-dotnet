namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

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

        public override string BasePath => "/v1/sources/{PARENT_ID}/source_transactions";

        public virtual StripeList<SourceTransaction> List(string parentId, SourceTransactionsListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(parentId, options, requestOptions);
        }

        public virtual Task<StripeList<SourceTransaction>> ListAsync(string parentId, SourceTransactionsListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAsync(parentId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<SourceTransaction> ListAutoPaging(string parentId, SourceTransactionsListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(parentId, options, requestOptions);
        }
    }
}
