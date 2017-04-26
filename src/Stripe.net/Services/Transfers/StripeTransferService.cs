using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeTransferService : StripeBasicService<StripeTransfer>
    {
        public StripeTransferService(string apiKey = null) : base(apiKey) { }

        public bool ExpandBalanceTransaction { get; set; }

        //Sync
        public virtual StripeTransfer Create(StripeTransferCreateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.Transfers}", requestOptions, options);
        }

        public virtual StripeTransfer Get(string payoutId, StripeRequestOptions requestOptions = null)
        {
            return GetEntity($"{Urls.Transfers}/{payoutId}", requestOptions);
        }

        public virtual StripeTransfer Update(string transferId, StripeTransferUpdateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.Transfers}/{transferId}", requestOptions, options);
        }

        public virtual IEnumerable<StripeTransfer> List(StripeTransferListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return GetEntityList($"{Urls.Transfers}", requestOptions, listOptions);
        }



        // Async
        public virtual Task<StripeTransfer> CreateAsync(StripeTransferCreateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.Transfers}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeTransfer> GetAsync(string payoutId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityAsync($"{Urls.Transfers}/{payoutId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeTransfer> UpdateAsync(string transferId, StripeTransferUpdateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.Transfers}/{transferId}", requestOptions, cancellationToken, options);
        }

        public virtual Task<IEnumerable<StripeTransfer>> ListAsync(StripeTransferListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityListAsync($"{Urls.Transfers}", requestOptions, cancellationToken, listOptions);
        }
    }
}
