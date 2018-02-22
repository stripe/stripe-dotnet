using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeTransferReversalService : StripeBasicService<StripeTransferReversal>
    {
        public StripeTransferReversalService() : base(null) { }
        public StripeTransferReversalService(string apiKey) : base(apiKey) { }

        public bool ExpandBalanceTransaction { get; set; }
        public bool ExpandTransfer { get; set; }



        //Sync
        public virtual StripeTransferReversal Create(string transferId, StripeTransferReversalCreateOptions options = null, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/transfers/{transferId}/reversals", requestOptions, options);
        }
        
        public virtual StripeTransferReversal Get(string transferId, string reversalId, StripeRequestOptions requestOptions = null)
        {
            return GetEntity($"{Urls.BaseUrl}/transfers/{transferId}/reversals/{reversalId}", requestOptions);
        }

        public virtual StripeTransferReversal Update(string transferId,  string reversalId, StripeTransferReversalUpdateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/transfers/{transferId}/reversals/{reversalId}", requestOptions, options);
        }

        public virtual StripeList<StripeTransferReversal> List(string transferId, StripeTransferReversalListOptions options = null, StripeRequestOptions requestOptions = null)
        {
            return GetEntityList($"{Urls.BaseUrl}/transfers/{transferId}/reversals", requestOptions, options);
        }



        // Async
        public virtual Task<StripeTransferReversal> CreateAsync(string transferId, StripeTransferReversalCreateOptions options = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/transfers/{transferId}/reversals", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeTransferReversal> GetAsync(string transferId, string reversalId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityAsync($"{Urls.BaseUrl}/transfers/{transferId}/reversals/{reversalId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeTransferReversal> UpdateAsync(string transferId,  string reversalId, StripeTransferReversalUpdateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/transfers/{transferId}/reversals/{reversalId}", requestOptions, cancellationToken, options);      
        }

        public virtual Task<StripeList<StripeTransferReversal>> ListAsync(string transferId, StripeTransferReversalListOptions options = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityListAsync($"{Urls.BaseUrl}/transfers/{transferId}/reversals", requestOptions, cancellationToken, options);
        }
    }
}
