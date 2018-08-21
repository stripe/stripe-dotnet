namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class TransferReversalService : BasicService<TransferReversal>
    {
        public TransferReversalService()
            : base(null)
        {
        }

        public TransferReversalService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandBalanceTransaction { get; set; }

        public bool ExpandTransfer { get; set; }

        public virtual TransferReversal Create(string transferId, TransferReversalCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/transfers/{transferId}/reversals", requestOptions, options);
        }

        public virtual TransferReversal Get(string transferId, string reversalId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/transfers/{transferId}/reversals/{reversalId}", requestOptions);
        }

        public virtual TransferReversal Update(string transferId,  string reversalId, TransferReversalUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/transfers/{transferId}/reversals/{reversalId}", requestOptions, options);
        }

        public virtual StripeList<TransferReversal> List(string transferId, TransferReversalListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/transfers/{transferId}/reversals", requestOptions, options);
        }

        public virtual Task<TransferReversal> CreateAsync(string transferId, TransferReversalCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/transfers/{transferId}/reversals", requestOptions, cancellationToken, options);
        }

        public virtual Task<TransferReversal> GetAsync(string transferId, string reversalId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/transfers/{transferId}/reversals/{reversalId}", requestOptions, cancellationToken);
        }

        public virtual Task<TransferReversal> UpdateAsync(string transferId,  string reversalId, TransferReversalUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/transfers/{transferId}/reversals/{reversalId}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeList<TransferReversal>> ListAsync(string transferId, TransferReversalListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/transfers/{transferId}/reversals", requestOptions, cancellationToken, options);
        }
    }
}
