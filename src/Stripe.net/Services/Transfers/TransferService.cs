namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class TransferService : BasicService<Transfer>,
        ICreatable<Transfer, TransferCreateOptions>,
        IListable<Transfer, TransferListOptions>,
        IRetrievable<Transfer>,
        IUpdatable<Transfer, TransferUpdateOptions>
    {
        public TransferService()
            : base(null)
        {
        }

        public TransferService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandBalanceTransaction { get; set; }

        public bool ExpandDestination { get; set; }

        public bool ExpandDestinationPayment { get; set; }

        public bool ExpandSourceTransaction { get; set; }

        public virtual Transfer Create(TransferCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/transfers", requestOptions, options);
        }

        public virtual Transfer Get(string payoutId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/transfers/{payoutId}", requestOptions);
        }

        public virtual Transfer Update(string transferId, TransferUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/transfers/{transferId}", requestOptions, options);
        }

        public virtual StripeList<Transfer> List(TransferListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/transfers", requestOptions, listOptions);
        }

        public virtual Task<Transfer> CreateAsync(TransferCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/transfers", requestOptions, cancellationToken, options);
        }

        public virtual Task<Transfer> GetAsync(string payoutId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/transfers/{payoutId}", requestOptions, cancellationToken);
        }

        public virtual Task<Transfer> UpdateAsync(string transferId, TransferUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/transfers/{transferId}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeList<Transfer>> ListAsync(TransferListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/transfers", requestOptions, cancellationToken, listOptions);
        }
    }
}
