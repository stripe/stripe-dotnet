// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class InferredBalanceService : ServiceNested<InferredBalance>,
        INestedListable<InferredBalance, InferredBalanceListOptions>
    {
        public InferredBalanceService()
            : base(null)
        {
        }

        public InferredBalanceService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/financial_connections/accounts/{PARENT_ID}/inferred_balances";

        public virtual StripeList<InferredBalance> List(string parentId, InferredBalanceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(parentId, options, requestOptions);
        }

        public virtual Task<StripeList<InferredBalance>> ListAsync(string parentId, InferredBalanceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAsync(parentId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<InferredBalance> ListAutoPaging(string parentId, InferredBalanceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(parentId, options, requestOptions);
        }

        public virtual IAsyncEnumerable<InferredBalance> ListAutoPagingAsync(string parentId, InferredBalanceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAutoPagingAsync(parentId, options, requestOptions, cancellationToken);
        }
    }
}
