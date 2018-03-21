using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeTransferService : StripeBasicService<StripeTransfer>
    {
        public StripeTransferService() : base(null) { }
        public StripeTransferService(string apiKey) : base(apiKey) { }

        public bool ExpandBalanceTransaction { get; set; }
        public bool ExpandDestination { get; set; }
        public bool ExpandDestinationPayment { get; set; }
        public bool ExpandSourceTransaction { get; set; }



        //Sync
        public virtual StripeTransfer Create(StripeTransferCreateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/transfers", requestOptions, options);
        }

        public virtual StripeTransfer Get(string payoutId, StripeRequestOptions requestOptions = null)
        {
            return GetEntity($"{Urls.BaseUrl}/transfers/{payoutId}", requestOptions);
        }

        public virtual StripeTransfer Update(string transferId, StripeTransferUpdateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/transfers/{transferId}", requestOptions, options);
        }

        public virtual StripeList<StripeTransfer> List(StripeTransferListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return GetEntityList($"{Urls.BaseUrl}/transfers", requestOptions, listOptions);
        }



        // Async
        public virtual Task<StripeTransfer> CreateAsync(StripeTransferCreateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/transfers", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeTransfer> GetAsync(string payoutId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityAsync($"{Urls.BaseUrl}/transfers/{payoutId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeTransfer> UpdateAsync(string transferId, StripeTransferUpdateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/transfers/{transferId}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeList<StripeTransfer>> ListAsync(StripeTransferListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityListAsync($"{Urls.BaseUrl}/transfers", requestOptions, cancellationToken, listOptions);
        }
    }
}
