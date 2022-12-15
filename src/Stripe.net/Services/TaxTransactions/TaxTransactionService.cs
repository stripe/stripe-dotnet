// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TaxTransactionService : Service<TaxTransaction>,
        ICreatable<TaxTransaction, TaxTransactionCreateOptions>,
        IRetrievable<TaxTransaction, TaxTransactionGetOptions>
    {
        public TaxTransactionService()
            : base(null)
        {
        }

        public TaxTransactionService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/tax/transactions";

        public virtual TaxTransaction Create(TaxTransactionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<TaxTransaction> CreateAsync(TaxTransactionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual TaxTransaction CreateReversal(TaxTransactionCreateReversalOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl("create_reversal")}", options, requestOptions);
        }

        public virtual Task<TaxTransaction> CreateReversalAsync(TaxTransactionCreateReversalOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl("create_reversal")}", options, requestOptions, cancellationToken);
        }

        public virtual TaxTransaction Get(string id, TaxTransactionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<TaxTransaction> GetAsync(string id, TaxTransactionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
