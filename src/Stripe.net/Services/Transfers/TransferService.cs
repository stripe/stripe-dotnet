namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class TransferService : BasicService<StripeTransfer>
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

        public virtual StripeTransfer Create(TransferCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/transfers", requestOptions, options);
        }

        public virtual StripeTransfer Get(string payoutId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/transfers/{payoutId}", requestOptions);
        }

        public virtual StripeTransfer Update(string transferId, TransferUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/transfers/{transferId}", requestOptions, options);
        }

        public virtual StripeList<StripeTransfer> List(TransferListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/transfers", requestOptions, listOptions);
        }

        public virtual Task<StripeTransfer> CreateAsync(TransferCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/transfers", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeTransfer> GetAsync(string payoutId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/transfers/{payoutId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeTransfer> UpdateAsync(string transferId, TransferUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/transfers/{transferId}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeList<StripeTransfer>> ListAsync(TransferListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/transfers", requestOptions, cancellationToken, listOptions);
        }
    }
}
