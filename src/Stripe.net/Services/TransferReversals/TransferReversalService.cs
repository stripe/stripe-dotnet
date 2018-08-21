namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class TransferReversalService : BasicService<StripeTransferReversal>
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

        public virtual StripeTransferReversal Create(string transferId, TransferReversalCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/transfers/{transferId}/reversals", requestOptions, options);
        }

        public virtual StripeTransferReversal Get(string transferId, string reversalId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/transfers/{transferId}/reversals/{reversalId}", requestOptions);
        }

        public virtual StripeTransferReversal Update(string transferId,  string reversalId, TransferReversalUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/transfers/{transferId}/reversals/{reversalId}", requestOptions, options);
        }

        public virtual StripeList<StripeTransferReversal> List(string transferId, TransferReversalListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/transfers/{transferId}/reversals", requestOptions, options);
        }

        public virtual Task<StripeTransferReversal> CreateAsync(string transferId, TransferReversalCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/transfers/{transferId}/reversals", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeTransferReversal> GetAsync(string transferId, string reversalId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/transfers/{transferId}/reversals/{reversalId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeTransferReversal> UpdateAsync(string transferId,  string reversalId, TransferReversalUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/transfers/{transferId}/reversals/{reversalId}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeList<StripeTransferReversal>> ListAsync(string transferId, TransferReversalListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/transfers/{transferId}/reversals", requestOptions, cancellationToken, options);
        }
    }
}
