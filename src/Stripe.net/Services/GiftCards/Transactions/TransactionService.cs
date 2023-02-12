// File generated from our OpenAPI spec
namespace Stripe.GiftCards
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TransactionService : Service<Transaction>,
        ICreatable<Transaction, TransactionCreateOptions>,
        IListable<Transaction, TransactionListOptions>,
        IRetrievable<Transaction, TransactionGetOptions>,
        IUpdatable<Transaction, TransactionUpdateOptions>
    {
        public TransactionService()
            : base(null)
        {
        }

        public TransactionService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/gift_cards/transactions";

        public virtual Transaction Cancel(string id, TransactionCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/cancel", options, requestOptions);
        }

        public virtual Task<Transaction> CancelAsync(string id, TransactionCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/cancel", options, requestOptions, cancellationToken);
        }

        public virtual Transaction Confirm(string id, TransactionConfirmOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/confirm", options, requestOptions);
        }

        public virtual Task<Transaction> ConfirmAsync(string id, TransactionConfirmOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/confirm", options, requestOptions, cancellationToken);
        }

        public virtual Transaction Create(TransactionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Transaction> CreateAsync(TransactionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Transaction Get(string id, TransactionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<Transaction> GetAsync(string id, TransactionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Transaction> List(TransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Transaction>> ListAsync(TransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Transaction> ListAutoPaging(TransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<Transaction> ListAutoPagingAsync(TransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }

        public virtual Transaction Update(string id, TransactionUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<Transaction> UpdateAsync(string id, TransactionUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
